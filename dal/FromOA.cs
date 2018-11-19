using common;
using Helpers;
using model;
using Model;
using Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal
{
    public class FromOA
    { /// <summary>
      /// 获取科目大纲
      /// </summary>
      /// <returns></returns>
        public List<form_enumvalue> getCode(string type)
        {
            using (var db = new v3xEntities())
            {
                var code = (from v in db.form_enumvalue join k in db.form_enumlist on v.ref_enumid equals k.id where k.enumname.Equals(type) orderby v.sortnumber ascending select v).ToList();
                return code;
            }
        }

        public object getChunaBianhao(string id)
        {
            using (var ent = new OAtoU8DATAEntities())
            {
                var tes= (from r in ent.RecordTable
                            where r.Pid.Contains(id)
                            select r).ToList();
                return tes;
            }
        }
        /* public  FromOA() {
             SqlHelper sql =new SqlHelper(ConfigurationManager.AppSettings["slqserver"].ToString());
         }*/

        private static string democonfig = ConfigurationManager.AppSettings["demoId"].ToString();
        private static string config = ConfigurationManager.AppSettings["OAslqserver"].ToString();
        /// <summary>
        /// 流程签字
        /// </summary>
        /// <param name="pro"></param>
        /// <returns></returns>
        public List<WriteModel> getProcessList(WriteModel pro)
        {
            string sql = "select m.name,d.name as 'depatement',l.name as 'leave',c.attitude,c.create_date FROM  [dbo].[col_opinion] c left join v3x_org_member m on c.writer_id = m.id left join v3x_org_department d on d.id = m.org_department_id left join v3x_org_level l on l.id = m.org_level_id     where col_id='" + pro.col_id + "' order by c.create_date ";
            DataTable dt = SqlHelper.ExecuteDataTable(config, sql);
            WriteModel result = new WriteModel();
            string[] field = new string[] { "name", "depatement", "leave", "create_date", "attitude" };
            List<WriteModel> list = ModelHelper.PutAllVal<WriteModel>(result, dt, field);
            return list;
        }
        /// <summary>
        /// 获取关联的预支单
        /// </summary>
        public List<v3x_attachment> getV3x_attachment(ResultListModel model){
             using (var db = new v3xEntities())
            {
                var col_id = Convert.ToInt64(model.colId);
                return (from a in db.v3x_attachment where a.reference == col_id select a).ToList();
            }
        }
        /// <summary>
        /// 获取关联的预支单（用于预支单报销）
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<YuzhiAttachment> getSunByattachment(ResultListModel model) {
            using (var db = new v3xEntities())
            {
                using (var myent = new OAtoU8DATAEntities())
                {
                    var col_id = Convert.ToInt64(model.colId);
                    var colBody = (from c in db.col_body
                                   join a in db.v3x_affair on c.col_id equals a.object_id
                                   join t in db.v3x_attachment on a.id equals t.genesis_id
                                   where t.reference == col_id
                                   select c).ToList();
                    ResultListModel models = new ResultListModel();
                    models.type = "上海悦目-预支单";//预支单才能冲账
                    models.list = new List<Detail>();
                    var yuzhiAttachmentList = new List<YuzhiAttachment>();
                    foreach (var body in colBody)
                    {
                        var yuzhiAttachment = new YuzhiAttachment();
                        yuzhiAttachment.Id = body.content;
                        yuzhiAttachment.detailList = new List<Detail>();
                        yuzhiAttachment.col_id = body.col_id;
                        models.Id = body.content;//预支单才能冲账
                        models.colId = body.col_id.ToString();
                        var t = getDetail(models);
                        if (t != null)
                        {
                            //model.list.Concat(t.list);//Union去重
                            foreach (var de in t.list)
                            {
                                yuzhiAttachment.detailList.Add(de);
                            }
                        }
                        yuzhiAttachment.record = myent.RecordTable.Where(o => o.Pid.Contains(models.Id)).ToList();
                        yuzhiAttachmentList.Add(yuzhiAttachment);
                    }
                    return yuzhiAttachmentList;
                }
            }
        }

        /// <summary>
        /// 获取每个单据的详细金额和说明
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ResultListModel getDetail(ResultListModel model)
        {
            ResultListModel result = new ResultListModel();
            string sql = "";
            if (model.type.Equals("上海悦目-差旅费报销单"))
            {
                sql = string.Format("SELECT  '' as kemu,'' as shouyibumen, '' as miaoshu ,'' as xianqing ,field0030 as jine ,field0031 as shijin,field0030 as jinexiaoji ,field0031 as riqi ,field0032 as qita ,field0033 as jintie ,field0034 as shineijiaotong , field0035 as chuchaijiaotong , field0036 as zhusu , field0037 as chechuan , field0038 as jipiao , field0039 as tianshu , field0040 as qizhididian ,field0030 shuihoujine, 0 shuidian, 0 shuie   FROM formson_0560  where  formmain_0559Id = {0}", model.Id);
            }
            else if (model.type.Equals("上海悦目-预支单"))
            {
                sql = string.Format("SELECT  field0028 as kemu,field0027 as shouyibumen, field0026 as miaoshu ,field0029 as xianqing ,field0031 as jine ,'' as shijin,'' as jinexiaoji ,'' as riqi ,'' as qita ,'' as jintie ,'' as shineijiaotong , '' as chuchaijiaotong , '' as zhusu , '' as chechuan , '' as jipiao , '' as tianshu , '' as qizhididian,field0031 shuihoujine, 0 shuidian, 0 shuie FROM formson_0594 f where  formmain_0593Id = {0}", model.Id);

            }
            else if (model.type.Equals("上海悦目-付款审批单"))
            {

                sql = string.Format("SELECT  field0030 as kemu,field0029 as shouyibumen, field0028 as miaoshu ,field0031 as xianqing ,field0036 as jine ,field0033 as shijin,'' as jinexiaoji ,field0033 as riqi ,'' as qita ," +
                    "'' as jintie ,'' as shineijiaotong , '' as chuchaijiaotong , '' as zhusu , '' as chechuan , '' as jipiao , '' as tianshu , '' as qizhididian,field0032 shuihoujine," +
                    "showValue shuidian, field0034  shuie  FROM formson_0616 left join form_enumvalue on enumvalue=field0035  where   ref_enumid=4866995226575588265 and formmain_0615Id = {0}", model.Id);
            }
            else if (model.type.Equals("上海悦目-费用报销单"))
            {
                sql = string.Format("SELECT  field0030 as kemu,field0029 as shouyibumen, field0028 as miaoshu ,field0031 as xianqing ,field0036 as jine ,field0033 as shijin,'' as jinexiaoji ,field0033 as riqi ,'' as qita ," +
                    "'' as jintie ,'' as shineijiaotong , '' as chuchaijiaotong , '' as zhusu , '' as chechuan , '' as jipiao , '' as tianshu , '' as qizhididian,field0032 shuihoujine," +
                    "showValue shuidian, field0034  shuie  FROM formson_0564 left join form_enumvalue on enumvalue=field0035  where   ref_enumid=4866995226575588265 and formmain_0563Id = {0}", model.Id);
            }
            else
            {
            }
            if (!string.IsNullOrEmpty(sql))
            {
                DataTable dt = SqlHelper.ExecuteDataTable(config, sql);
                Detail detail = new Detail();
                string[] field = new string[] { "kemu", "shouyibumen", "jine", "miaoshu", "xianqing", "jinexiaoji", "riqi", "qita", "jintie", "shineijiaotong", "chuchaijiaotong", "zhusu", "chechuan", "jipiao", "tianshu", "qizhididian", "shuihoujine", "shuidian", "shuie" };


                List<Detail> list = ModelHelper.PutAllVal<Detail>(detail, dt, field);
                result.list = list;
            }
            else { }
            return result;
        }
        /// <summary>
        /// 获取单据列表
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public List<ResultListModel> getList(Condition condition)
        {
            try
            {
                if (condition.startDate == null)
                {
                    condition.startDate = new DateTime(1990, 01, 01);
                }
                if (condition.endDate == null)
                {
                    condition.endDate = DateTime.Now.AddDays(1);
                }
                else
                {
                    DateTime dt = Convert.ToDateTime(condition.endDate);
                    condition.endDate = dt.AddDays(1);
                }
                /*if (string.IsNullOrEmpty(condition.start))
                {
                    condition.start = "1";//正式数据改成1
                }
                else if (condition.start.Equals("完成"))
                {//finishedflag为审核状态，如果审核结束成功状态为1，审核未结束的状态为0，终止的为3
                    condition.start = "1";
                }
                else if (condition.start.Equals("审核中"))
                {
                    condition.start = "0";
                }
                else { condition.start = "3"; }//被终止掉的3*/
                if (string.IsNullOrEmpty(condition.menberName))
                {
                    condition.menberName = "";
                }
                if (string.IsNullOrEmpty(condition.Id))
                {
                    condition.Id = "";
                }
                if (string.IsNullOrEmpty(condition.liuShui)) {//根据流水号查询
                    condition.liuShui = "";
                }
                if (condition.userInfo.type == 2) {//普通员工
                    condition.menberName = condition.userInfo.name;
                }
                //只查询Form内容
                string sql = "";
                if (condition.type.IndexOf("上海悦目-差旅费报销单") > -1)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("select* from (");
                    sb.Append(" select chunabianhao, danjubianhao,pingzhenhao,level.name zhiwu,IsIntoBook shifouPingzhen,outo.contents contentId,IsIntoCloseBill shifouShengdan,IsIntoAccvouch shifouZhidan , CAST(body.content as varchar(100))bodycontent,CAST( formmain.id as varchar(100)) as Id, '" + condition.type + "'[type], col.finish_date finish_date, col.id colId,");
                    sb.Append("col.subject title, col.create_date chuangjinshijin, m.id mid, m.name faqiren, d.name faqibumen, enumvalue.showValue shouyibumen,");
                    sb.Append("formmain.field0021 liuShui,formmain.field0012  lAmount, formmain.field0013  cAmount, '' phone, formmain.field0001 company,");
                    sb.Append("formmain.field0006 chuchaishiyou, formmain.field0014 starDate, formmain.field0015 endDate, formmain.field0016 gongjitianshu,");
                    sb.Append("formmain.field0018 yuzhi, formmain.field0019 yinhuan,");
                    sb.Append("formmain.field0022 shoukuandanwei, formmain.field0023 shoukuanyh, formmain.field0024 zhanhao, formmain.field0025 fukuanriqi ,formmain.field0018 feiyongleixing ");
                    sb.Append("from col_summary col ");
                    sb.Append("left join col_body body on col.id = body.col_id ");
                    sb.Append("left join v3x_org_member m on m.id = col.start_member_id ");
                    sb.Append("left join v3x_org_department d on m.org_department_id = d.id ");
                    sb.Append("left join v3x_org_level level on level.id = m.org_level_id  ");
                    sb.Append("left join formmain_0559 formmain on formmain.start_member_id = col.start_member_id ");//正式的资源表formmain_0559 
                    sb.Append("left join form_enumvalue enumvalue on enumvalue.enumvalue = formmain.field0005 ");
                    sb.Append("left join form_enumlist enumlist on enumvalue.ref_enumid = enumlist.id ");
                    sb.Append("left join OAtoU8DATA.dbo.RecordTable outo on formmain.id= outo.pid ");
                    //  sb.Append("left join v3x_org_department d1 on d1.id = formmain.field0005 ");
                    sb.Append("where ");//col.form_appid = -2287409120319815238 （正式的模板id）
                    sb.Append(" col.create_date >= '" + condition.startDate + "' and col.create_date <= '" + condition.endDate + "' ");
                    sb.Append("and enumlist.enumname = 'U8部门枚举' ");
                    sb.Append("and m.name like '%" + condition.menberName + "%' ");
                    sb.Append("and formmain.id like '%" + condition.Id + "%' ");
                    sb.Append("and formmain.field0021 like '%" + condition.liuShui + "%'");
                    // sb.Append("and formmain.finishedflag = " + condition.start);由于流程出现变化，当流程跑到黄山或者金额大于1000000时候跑到总经理的时候就能打印，再考虑到有些流程比较紧急所以等后续补签提前打印，所以不再设置在完成时候才能打印
                    sb.Append(") as a  where a.Id = '' + a.bodycontent ");
                    sql = sb.ToString();
                }
                else if (condition.type.IndexOf("上海悦目-预支单") > -1)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("select* from (");
                    sb.Append("select  chunabianhao, danjubianhao,pingzhenhao, level.name zhiwu, IsIntoBook shifouPingzhen,IsIntoCloseBill shifouShengdan,IsIntoAccvouch shifouZhidan ,outo.contents contentId, CAST(body.content as varchar(100)) bodycontent,CAST( formmain.id as varchar(100)) as Id, '" + condition.type + "'[type], col.finish_date finish_date, col.id colId,");
                    sb.Append("col.subject title, col.create_date chuangjinshijin, m.id mid, m.name faqiren, d.name faqibumen, enumvalue.showValue shouyibumen,");
                    sb.Append("formmain.field0001 liuShui,formmain.field0010  lAmount ,formmain.field0011  cAmount,formmain.field0007 phone,formmain.field0002 company , ");
                    sb.Append("'' chuchaishiyou,'' starDate,'' endDate,'' gongjitianshu,");
                    sb.Append("'0.00' yuzhi,'0.00' yinhuan,");
                    sb.Append("formmain.field0021 shoukuandanwei,formmain.field0019 shoukuanyh,formmain.field0020 zhanhao,formmain.field0009 fukuanriqi,formmain.field0018 feiyongleixing  ");
                    sb.Append("from col_summary col ");
                    sb.Append("left join col_body body on col.id = body.col_id ");
                    sb.Append("left join v3x_org_member m on m.id = col.start_member_id ");
                    sb.Append("left join v3x_org_department d on m.org_department_id = d.id ");
                    sb.Append("left join v3x_org_level level on level.id = m.org_level_id  ");
                    sb.Append("left join formmain_0593 formmain on formmain.start_member_id = col.start_member_id ");//formmain_0567正式
                    //sb.Append("left join v3x_org_department d1 on d1.id = formmain.field0006 ");
                    sb.Append("left join form_enumvalue enumvalue on enumvalue.enumvalue = formmain.field0006 ");
                    sb.Append("left join form_enumlist enumlist on enumvalue.ref_enumid = enumlist.id ");
                    sb.Append("left join OAtoU8DATA.dbo.RecordTable outo on formmain.id= outo.pid ");
                    sb.Append("where ");//正式col.form_appid = 7918552077698879263
                    sb.Append(" col.create_date >= '" + condition.startDate + "' and col.create_date <= '" + condition.endDate + "'");
                    sb.Append("and enumlist.enumname = 'U8部门枚举' ");
                    sb.Append("and m.name like '%" + condition.menberName + "%'");
                    sb.Append("and formmain.id like '%" + condition.Id + "%'");
                    if (condition.form_enumvalue != null) {//财务操作
                        sb.Append("and formmain.field0018 = '" + condition.form_enumvalue.enumvalue + "'");
                    }
                    sb.Append("and formmain.field0001 like '%" + condition.liuShui + "%'");
                    //  sb.Append("and formmain.finishedflag = " + condition.start);
                    sb.Append(") as a  where a.Id = '' + a.bodycontent ");
                    sql = sb.ToString();
                }
                else if (condition.type.IndexOf("上海悦目-费用报销单") > -1)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("select* from (");
                    sb.Append("select  chunabianhao, danjubianhao,pingzhenhao,level.name zhiwu, IsIntoBook shifouPingzhen,IsIntoCloseBill shifouShengdan,IsIntoAccvouch shifouZhidan , outo.contents contentId,CAST(body.content as varchar(100))bodycontent,CAST( formmain.id as varchar(100)) as Id, '" + condition.type + "'[type], col.finish_date finish_date, col.id colId,");
                    sb.Append("col.subject title, col.create_date chuangjinshijin, m.id mid, m.name faqiren, d.name faqibumen, enumvalue.showValue shouyibumen,");
                    sb.Append("formmain.field0001 liuShui,formmain.field0010  lAmount ,formmain.field0011  cAmount,formmain.field0007 phone,formmain.field0002 company ,");
                    sb.Append("'' chuchaishiyou,'' starDate,'' endDate,'' gongjitianshu,");
                    sb.Append("formmain.field0016 yuzhi,formmain.field0017 yinhuan,");
                    sb.Append("formmain.field0018 shoukuandanwei, formmain.field0014 shoukuanyh, formmain.field0015 zhanhao, formmain.field0009 fukuanriqi,formmain.field0018 feiyongleixing ");
                    sb.Append("from col_summary col ");
                    sb.Append("left join col_body body on col.id = body.col_id ");
                    sb.Append("left join v3x_org_member m on m.id = col.start_member_id ");
                    sb.Append("left join v3x_org_level level on level.id = m.org_level_id  ");
                    sb.Append("left join v3x_org_department d on m.org_department_id = d.id ");
                    sb.Append("left join formmain_0563 formmain on formmain.start_member_id = col.start_member_id ");//正式formmain_0563
                    //sb.Append("left join v3x_org_department d1 on d1.id = formmain.field0006 ");
                    sb.Append("left join form_enumvalue enumvalue on enumvalue.enumvalue = formmain.field0006 ");
                    sb.Append("left join form_enumlist enumlist on enumvalue.ref_enumid = enumlist.id ");
                    sb.Append("left join OAtoU8DATA.dbo.RecordTable outo on formmain.id= outo.pid ");
                    sb.Append("where"); //正式表单col.form_appid = 6030205033455177463 
                    sb.Append("  col.create_date >= '" + condition.startDate + "' and col.create_date <= '" + condition.endDate + "' ");
                    sb.Append("and enumlist.enumname = 'U8部门枚举' ");
                    sb.Append("and m.name like '%" + condition.menberName + "%' ");
                    sb.Append("and formmain.id like '%" + condition.Id + "%' ");
                    if (condition.form_enumvalue != null) {//财务操作
                        sb.Append("and formmain.field0013 = '" + condition.form_enumvalue.enumvalue + "'");
                    }
                    sb.Append("and m.name like '%" + condition.menberName + "%' ");
                    sb.Append("and formmain.field0001 like '%" + condition.liuShui + "%'");
                    // sb.Append("and formmain.finishedflag = " + condition.start);
                    sb.Append(") as a  where a.Id = '' + a.bodycontent ");
                    sql = sb.ToString();
                }
                else if (condition.type.IndexOf("上海悦目-付款审批单") > -1)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("select* from (");
                    sb.Append("select chunabianhao, danjubianhao,pingzhenhao, level.name zhiwu, IsIntoBook shifouPingzhen,IsIntoCloseBill shifouShengdan,IsIntoAccvouch shifouZhidan , outo.contents contentId,CAST(body.content as varchar(100))bodycontent,CAST( formmain.id as varchar(100)) as Id, '" + condition.type + "'[type], col.finish_date finish_date, col.id colId,");
                    sb.Append("col.subject title, col.create_date chuangjinshijin, m.id mid, m.name faqiren, d.name faqibumen, enumvalue.showValue shouyibumen,");
                    sb.Append("formmain.field0001 liuShui,formmain.field0010  lAmount ,formmain.field0011  cAmount,formmain.field0007 phone,formmain.field0002 company ,");
                    sb.Append("'' chuchaishiyou,'' starDate,'' endDate,'' gongjitianshu,");
                    sb.Append("formmain.field0016 yuzhi,formmain.field0017 yinhuan,");
                    sb.Append("formmain.field0018 shoukuandanwei, formmain.field0014 shoukuanyh, formmain.field0015 zhanhao, formmain.field0009 fukuanriqi,formmain.field0018 feiyongleixing ");
                    sb.Append("from col_summary col ");
                    sb.Append("left join col_body body on col.id = body.col_id ");
                    sb.Append("left join v3x_org_member m on m.id = col.start_member_id ");
                    sb.Append("left join v3x_org_level level on level.id = m.org_level_id  ");
                    sb.Append("left join v3x_org_department d on m.org_department_id = d.id ");
                    sb.Append("left join formmain_0615  formmain on formmain.start_member_id = col.start_member_id "); //正式formmain_0571 
                    //sb.Append("left join v3x_org_department d1 on d1.id = formmain.field0006 ");
                    sb.Append("left join form_enumvalue enumvalue on enumvalue.enumvalue = formmain.field0006 ");
                    sb.Append("left join form_enumlist enumlist on enumvalue.ref_enumid = enumlist.id ");
                    sb.Append("left join OAtoU8DATA.dbo.RecordTable outo on formmain.id= outo.pid ");
                    sb.Append("where "); //正式 col.form_appid = -1166138112544715333
                    sb.Append(" col.create_date >= '" + condition.startDate + "' and col.create_date <= '" + condition.endDate + "' ");
                    sb.Append("and enumlist.enumname = 'U8部门枚举' ");
                    sb.Append("and m.name like '%" + condition.menberName + "%' ");
                    sb.Append("and formmain.id like '%" + condition.Id + "%' ");
                    sb.Append("and formmain.field0001 like '%" + condition.liuShui + "%'");
                    if (condition.form_enumvalue != null)
                    {//财务操作
                        sb.Append("and formmain.field0013 = '" + condition.form_enumvalue.enumvalue + "'");
                    }
                    // sb.Append("and formmain.finishedflag = " + condition.start);
                    sb.Append(") as a  where a.Id = '' + a.bodycontent ");
                    sql = sb.ToString();
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    //差旅费
                    sb.Append("select* from (");
                    sb.Append("select  chunabianhao, danjubianhao,pingzhenhao, level.name zhiwu, IsIntoBook shifouPingzhen,IsIntoCloseBill shifouShengdan,IsIntoAccvouch shifouZhidan , outo.contents contentId,CAST(body.content as varchar(100))bodycontent,CAST( formmain.id as varchar(100)) as Id, '上海悦目-差旅费报销单'[type], col.finish_date finish_date, col.id colId,");
                    sb.Append("col.subject title, col.create_date chuangjinshijin, m.id mid, m.name faqiren, d.name faqibumen, enumvalue.showValue shouyibumen,");
                    sb.Append("formmain.field0021 liuShui,formmain.field0012  lAmount, formmain.field0013  cAmount, '' phone, formmain.field0001 company,");
                    sb.Append("formmain.field0006 chuchaishiyou, formmain.field0014 starDate, formmain.field0015 endDate, formmain.field0016 gongjitianshu,");
                    sb.Append("formmain.field0018 yuzhi, formmain.field0019 yinhuan,");
                    sb.Append("formmain.field0022 shoukuandanwei, formmain.field0023 shoukuanyh, formmain.field0024 zhanhao, formmain.field0025 fukuanriqi ,formmain.field0018 feiyongleixing ");
                    sb.Append("from col_summary col ");
                    sb.Append("left join col_body body on col.id = body.col_id ");
                    sb.Append("left join v3x_org_member m on m.id = col.start_member_id ");
                    sb.Append("left join v3x_org_department d on m.org_department_id = d.id ");
                    sb.Append("left join v3x_org_level level on level.id = m.org_level_id  ");
                    sb.Append("left join formmain_0559 formmain on formmain.start_member_id = col.start_member_id ");//正式的资源表formmain_0559 
                    sb.Append("left join form_enumvalue enumvalue on enumvalue.enumvalue = formmain.field0005 ");
                    sb.Append("left join form_enumlist enumlist on enumvalue.ref_enumid = enumlist.id ");
                    sb.Append("left join OAtoU8DATA.dbo.RecordTable outo on formmain.id= outo.pid ");
                    //  sb.Append("left join v3x_org_department d1 on d1.id = formmain.field0005 ");
                    sb.Append("where ");//col.form_appid = -2287409120319815238 （正式的模板id）
                    sb.Append(" col.create_date >= '" + condition.startDate + "' and col.create_date <= '" + condition.endDate + "' ");
                    sb.Append("and enumlist.enumname = 'U8部门枚举' ");
                    sb.Append("and m.name like '%" + condition.menberName + "%' ");
                    sb.Append("and formmain.id like '%" + condition.Id + "%' ");
                    sb.Append("and formmain.field0001 like '%" + condition.liuShui + "%'");
                    // sb.Append("and formmain.finishedflag = " + condition.start);由于流程出现变化，当流程跑到黄山或者金额大于1000000时候跑到总经理的时候就能打印，再考虑到有些流程比较紧急所以等后续补签提前打印，所以不再设置在完成时候才能打印
                    sb.Append(") as a  where a.Id = '' + a.bodycontent; ");
                    //预支单
                    sb.Append("select* from (");
                    sb.Append("select  chunabianhao, danjubianhao,pingzhenhao,level.name zhiwu, IsIntoBook shifouPingzhen,IsIntoCloseBill shifouShengdan,IsIntoAccvouch shifouZhidan ,outo.contents contentId, CAST(body.content as varchar(100)) bodycontent,CAST( formmain.id as varchar(100)) as Id, '上海悦目-预支单'[type], col.finish_date finish_date, col.id colId,");
                    sb.Append("col.subject title, col.create_date chuangjinshijin, m.id mid, m.name faqiren, d.name faqibumen, enumvalue.showValue shouyibumen,");
                    sb.Append("formmain.field0001 liuShui,formmain.field0010  lAmount ,formmain.field0011  cAmount,formmain.field0007 phone,formmain.field0002 company , ");
                    sb.Append("'' chuchaishiyou,'' starDate,'' endDate,'' gongjitianshu,");
                    sb.Append("'0.00' yuzhi,'0.00' yinhuan,");
                    sb.Append("formmain.field0021 shoukuandanwei,formmain.field0019 shoukuanyh,formmain.field0020 zhanhao,formmain.field0009 fukuanriqi,formmain.field0018 feiyongleixing  ");
                    sb.Append("from col_summary col ");
                    sb.Append("left join col_body body on col.id = body.col_id ");
                    sb.Append("left join v3x_org_member m on m.id = col.start_member_id ");
                    sb.Append("left join v3x_org_department d on m.org_department_id = d.id ");
                    sb.Append("left join v3x_org_level level on level.id = m.org_level_id  ");
                    sb.Append("left join formmain_0593 formmain on formmain.start_member_id = col.start_member_id ");//formmain_0567正式
                    //sb.Append("left join v3x_org_department d1 on d1.id = formmain.field0006 ");
                    sb.Append("left join form_enumvalue enumvalue on enumvalue.enumvalue = formmain.field0006 ");
                    sb.Append("left join form_enumlist enumlist on enumvalue.ref_enumid = enumlist.id ");
                    sb.Append("left join OAtoU8DATA.dbo.RecordTable outo on formmain.id= outo.pid ");
                    sb.Append("where ");//正式col.form_appid = 7918552077698879263
                    sb.Append(" col.create_date >= '" + condition.startDate + "' and col.create_date <= '" + condition.endDate + "'");
                    sb.Append("and enumlist.enumname = 'U8部门枚举' ");
                    sb.Append("and m.name like '%" + condition.menberName + "%'");
                    sb.Append("and formmain.id like '%" + condition.Id + "%'");
                    if (condition.form_enumvalue != null)
                    {//财务操作
                        sb.Append("and formmain.field0018= '" + condition.form_enumvalue.enumvalue + "'");
                    }
                    //  sb.Append("and formmain.finishedflag = " + condition.start);
                    sb.Append("and formmain.field0001 like '%" + condition.liuShui + "%'");
                    sb.Append(") as a  where a.Id = '' + a.bodycontent; ");
                    //费用报销单
                    sb.Append("select* from (");
                    sb.Append("select  chunabianhao, danjubianhao,pingzhenhao,level.name zhiwu, IsIntoBook shifouPingzhen,IsIntoCloseBill shifouShengdan,IsIntoAccvouch shifouZhidan ,outo.contents contentId, CAST(body.content as varchar(100))bodycontent,CAST( formmain.id as varchar(100)) as Id, '上海悦目-费用报销单'[type], col.finish_date finish_date, col.id colId,");
                    sb.Append("col.subject title, col.create_date chuangjinshijin, m.id mid, m.name faqiren, d.name faqibumen, enumvalue.showValue shouyibumen,");
                    sb.Append("formmain.field0001 liuShui,formmain.field0010  lAmount ,formmain.field0011  cAmount,formmain.field0007 phone,formmain.field0002 company ,");
                    sb.Append("'' chuchaishiyou,'' starDate,'' endDate,'' gongjitianshu,");
                    sb.Append("formmain.field0016 yuzhi,formmain.field0017 yinhuan,");
                    sb.Append("formmain.field0018 shoukuandanwei, formmain.field0014 shoukuanyh, formmain.field0015 zhanhao, formmain.field0009 fukuanriqi,formmain.field0013 feiyongleixing ");
                    sb.Append("from col_summary col ");
                    sb.Append("left join col_body body on col.id = body.col_id ");
                    sb.Append("left join v3x_org_member m on m.id = col.start_member_id ");
                    sb.Append("left join v3x_org_department d on m.org_department_id = d.id ");
                    sb.Append("left join v3x_org_level level on level.id = m.org_level_id  ");
                    sb.Append("left join formmain_0563 formmain on formmain.start_member_id = col.start_member_id ");//正式formmain_0563
                    //sb.Append("left join v3x_org_department d1 on d1.id = formmain.field0006 ");
                    sb.Append("left join form_enumvalue enumvalue on enumvalue.enumvalue = formmain.field0006 ");
                    sb.Append("left join form_enumlist enumlist on enumvalue.ref_enumid = enumlist.id ");
                    sb.Append("left join OAtoU8DATA.dbo.RecordTable outo on formmain.id= outo.pid ");
                    sb.Append("where"); //正式表单col.form_appid = 6030205033455177463 
                    sb.Append("  col.create_date >= '" + condition.startDate + "' and col.create_date <= '" + condition.endDate + "' ");
                    sb.Append("and enumlist.enumname = 'U8部门枚举' ");
                    sb.Append("and m.name like '%" + condition.menberName + "%' ");
                    sb.Append("and formmain.id like '%" + condition.Id + "%' ");
                    if (condition.form_enumvalue != null)
                    {//财务操作
                        sb.Append("and formmain.field0013 = '" + condition.form_enumvalue.enumvalue + "'");
                    }
                    sb.Append("and m.name like '%" + condition.menberName + "%' ");
                    sb.Append("and formmain.field0001 like '%" + condition.liuShui + "%'");
                    // sb.Append("and formmain.finishedflag = " + condition.start);
                    sb.Append(") as a  where a.Id = '' + a.bodycontent; ");
                    //付款审批单
                    sb.Append("select* from (");
                    sb.Append("select  chunabianhao, danjubianhao,pingzhenhao,level.name zhiwu, IsIntoBook shifouPingzhen,IsIntoCloseBill shifouShengdan,IsIntoAccvouch shifouZhidan ,outo.contents contentId, CAST(body.content as varchar(100))bodycontent,CAST( formmain.id as varchar(100)) as Id, '上海悦目-付款审批单'[type], col.finish_date finish_date, col.id colId,");
                    sb.Append("col.subject title, col.create_date chuangjinshijin, m.id mid, m.name faqiren, d.name faqibumen, enumvalue.showValue shouyibumen,");
                    sb.Append("formmain.field0001 liuShui,formmain.field0010  lAmount ,formmain.field0011  cAmount,formmain.field0007 phone,formmain.field0002 company ,");
                    sb.Append("'' chuchaishiyou,'' starDate,'' endDate,'' gongjitianshu,");
                    sb.Append("formmain.field0016 yuzhi,formmain.field0017 yinhuan,");
                    sb.Append("formmain.field0018 shoukuandanwei, formmain.field0014 shoukuanyh, formmain.field0015 zhanhao, formmain.field0009 fukuanriqi,formmain.field0018 feiyongleixing ");
                    sb.Append("from col_summary col ");
                    sb.Append("left join col_body body on col.id = body.col_id ");
                    sb.Append("left join v3x_org_member m on m.id = col.start_member_id ");
                    sb.Append("left join v3x_org_department d on m.org_department_id = d.id ");
                    sb.Append("left join v3x_org_level level on level.id = m.org_level_id  ");
                    sb.Append("left join formmain_0615  formmain on formmain.start_member_id = col.start_member_id "); //正式formmain_0571 
                    //sb.Append("left join v3x_org_department d1 on d1.id = formmain.field0006 ");
                    sb.Append("left join form_enumvalue enumvalue on enumvalue.enumvalue = formmain.field0006 ");
                    sb.Append("left join form_enumlist enumlist on enumvalue.ref_enumid = enumlist.id ");
                    sb.Append("left join OAtoU8DATA.dbo.RecordTable outo on formmain.id= outo.pid ");
                    sb.Append("where "); //正式 col.form_appid = -1166138112544715333
                    sb.Append(" col.create_date >= '" + condition.startDate + "' and col.create_date <= '" + condition.endDate + "' ");
                    sb.Append("and enumlist.enumname = 'U8部门枚举' ");
                    sb.Append("and m.name like '%" + condition.menberName + "%' ");
                    sb.Append("and formmain.id like '%" + condition.Id + "%' ");
                    if (condition.form_enumvalue != null)
                    {//财务操作
                        sb.Append("and formmain.field0013 = '" + condition.form_enumvalue.enumvalue + "'");
                    }
                    sb.Append("and formmain.field0001 like '%" + condition.liuShui + "%'");
                    // sb.Append("and formmain.finishedflag = " + condition.start);
                    sb.Append(") as a  where a.Id = '' + a.bodycontent ;");
                    sql = sb.ToString();
                }

                if (!string.IsNullOrEmpty(sql))
                {
                    DataSet ds = SqlHelper.ExecuteDataSet(config, sql);
                    ResultListModel s = new ResultListModel();
                    string[] field = new string[] { "chunabianhao", "danjubianhao","pingzhenhao", "zhiwu", "liuShui", "shifouPingzhen","contentId", "shifouShengdan", "shifouZhidan", "feiyongleixing", "chuchaishiyou", "gongjitianshu", "starDate", "endDate", "yuzhi", "yinhuan", "shoukuandanwei", "shoukuanyh", "zhanhao", "fukuanriqi", "title", "chuangjinshijin", "faqiren", "faqibumen", "colId", "finish_date", "Id", "company", "phone", "lAmount", "cAmount", "shouyibumen", "type" };
                    return ModelHelper.PutAllVal<ResultListModel>(s, ds, field);
                }
                else
                {
                    return new List<ResultListModel>();
                }

            }
            catch (Exception ex)
            {
                return new List<ResultListModel>();
            }
        }
    }
}
