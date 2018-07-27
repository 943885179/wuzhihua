using model;
using Model;
using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace dal
{
 public   class OAApplyDal
    { /// <summary>
      /// 获取单据列表
      /// </summary>
      /// <param name="condition"></param>
      /// <returns></returns>
        public object getList(ConditionModel condition)
        {
            List <ResultDateModel> resultList= new List<ResultDateModel>();
            if (condition.startDate == null)
            {
                condition.startDate = new DateTime(1990, 01, 01);
            }
            if (condition.endDate == null)
            {
                condition.endDate = DateTime.Now;
            }
            //开始读取了
            using (var db = new v3xEntities())
            {
                var summaryList = (from col in db.col_summary
                                   join f in db.form_appmain on col.form_appid equals f.id
                                   join m in db.v3x_org_member on col.start_member_id equals m.id
                                   join d in db.form_data_state on col.id equals d.summary_id
                                   where col.create_date >= condition.startDate && col.create_date <= condition.endDate
                                      && f.id == condition.form_appid && m.name.Contains(condition.menberName)
                                      && ((condition.col_Id != 0 && col.id == condition.col_Id) || condition.col_Id == 0)
                                      && d.finishedflag == condition.finishedflag_id
                                   select new Col_summaryModel {
                                       id=col.id,
                                       idStr = col.id+"",
                                       subject = col.subject,
                                       finish_date = col.finish_date,
                                       start_member_id = col.start_member_id,
                                       create_date=col.create_date,
                                       form_appid=col.form_appid+""
                                   })
                               .ToList();
                foreach (var summary in summaryList) {
                    ResultDateModel result = new ResultDateModel();
                    var body = db.col_body.Where(o => o.col_id == summary.id).FirstOrDefault();
                    var member = db.v3x_org_member.Where(o => o.id == summary.start_member_id).FirstOrDefault();//获取人员信息（发起人）
                    var depatement = db.v3x_org_department.Where(o => o.id == member.org_department_id).FirstOrDefault();//获取部门（发起部门，报销部门）
                   result.col_body = body;
                   result.col_summary = summary;
                    result.v3x_org_member = member;
                    result.v3x_org_department = depatement;
                    long content = Convert.ToInt64(body.content);
                    if (condition.form_appid==-2287409120319815238)
                    {//差旅费报销单
                        result.ChailvList = new ChailvList();
                        result.ChailvList.formmain_0559 = db.formmain_0545.Where(o => o.id==content).FirstOrDefault();//获取单据大体描述
                        result.ChailvList.formson_0560List = db.formson_0546.Where(o => o.formmain_0545Id == result.ChailvList.formmain_0559.id).ToList();//明细
                        
                    }
                    else if (condition.form_appid == 7918552077698879263)
                    {//预支单
                        result.YuzhiList = new YuzhiList();
                        result.YuzhiList.formmain_0567 = db.formmain_0545.Where( o => o.id==content).FirstOrDefault();//获取单据大体描述
                        result.YuzhiList.formson_0568List = new List<formson_0568List>();
                      var list= db.formson_0546.Where(o => o.formmain_0545Id == result.YuzhiList.formmain_0567.id).ToList();//明细
                        foreach (var formson in list) {
                            formson_0568List f = new formson_0568List();
                            f.formson_0568 = formson;
                            f.v3x_org_department = db.v3x_org_department.Where(o => o.id.Equals(formson.field0027)).FirstOrDefault();
                            result.YuzhiList.formson_0568List.Add(f);
                        }
                    }
                    else if (condition.form_appid == 6030205033455177463)
                    {//费用报销单
                        result.BaoxiaoList = new BaoxiaoList();
                        result.BaoxiaoList.formmain_0563 = db.formmain_0545.Where(o => o.id==content).FirstOrDefault();//获取单据大体描述
                        result.BaoxiaoList.formson_0564List = new List<formson_0564List>();
                        var list = db.formson_0546.Where(o => o.formmain_0545Id == result.BaoxiaoList.formmain_0563.id).ToList();//明细
                        foreach (var formson in list)
                        {
                            formson_0564List f = new formson_0564List();
                            f.formson_0564 = formson;
                            f.v3x_org_department = db.v3x_org_department.Where(o => o.id.Equals(formson.field0029)).FirstOrDefault();
                            result.BaoxiaoList.formson_0564List.Add(f);
                        }
                    }
                    else if (condition.form_appid == -1166138112544715333)
                    {//付款审批单
                        result.ShenpiList = new ShenpiList();
                        result.ShenpiList.formmain_0571 = db.formmain_0545.Where( o => o.id==content).FirstOrDefault();//获取单据大体描述

                        result.ShenpiList.formson_0572List = new List<formson_0572List>();
                        var list = db.formson_0546.Where(o => o.formmain_0545Id == result.ShenpiList.formmain_0571.id).ToList();//明细
                        foreach (var formson in list)
                        {
                            formson_0572List f = new formson_0572List();
                            f.formson_0572 = formson;
                            f.v3x_org_department = db.v3x_org_department.Where(o => o.id.Equals(formson.field0029)).FirstOrDefault();
                            f.v3x_org_department.v3x_org_account = null;
                            result.ShenpiList.formson_0572List.Add(f);
                        }
                    }
                    else
                    {
                        result.ShenqianbiaoList = new ShenqianbiaoList();
                        result.ShenqianbiaoList.formmain_0190= db.formmain_0190.Where(o => o.id == content).FirstOrDefault();
                        result.ShenqianbiaoList.formson_0191List = db.formson_0191.Where(o => o.formmain_0190Id == result.ShenqianbiaoList.formmain_0190.id).ToList();
                     }
                    //签字流程
                    result.WriteList = (from o in db.col_opinion
                                        join m in db.v3x_org_member on o.writer_id equals m.id
                                      //  join d in db.v3x_org_department on m.org_department_id equals d.id
                                        join l in db.v3x_org_level on m.org_level_id equals l.id
                                        where o.col_id == summary.id
                                        select new Write
                                        {
                                            date = o.create_date,
                                            userName = m.name,
                                            leave = l.name
                                  }).ToList();
                    result.v3x_org_member.v3x_org_account = new v3x_org_account();
                    result.v3x_org_department.v3x_org_account = new v3x_org_account();
                    result.col_body.col_summary = new col_summary();
                    resultList.Add(result);
                }
            }
            return resultList;
        }

        public string getXml() {
            using (var db =new v3xEntities()) {
                var appmain= db.form_appmain.Where(f=>f.id== 4521840191946311758).FirstOrDefault();
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(appmain.datadefine);
                string jsonText = JsonConvert.SerializeXmlNode(doc);
                return jsonText;
            }
        }
    }
}
