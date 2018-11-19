using common;
using Helpers;
using Log;
using model;
using Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal
{
    public class FromU8
    {

        private static string config = ConfigurationManager.AppSettings["U8slqserver"].ToString();
        /// <summary>
        /// 获取付款银行，只做第四期的，
        /// </summary>
        public List<Content> getAccInfo(int acctType)
        {
            using (var db = new UFDATA_048_2017Entities())
            {
                //第一次加载太慢了，增加个暖机操作试试水
                /*  var objectContext = ((IObjectContextAdapter)db).ObjectContext;
                  var mappingCollection = (StorageMappingItemCollection)objectContext.MetadataWorkspace.GetItemCollection(DataSpace.CSSpace);
                  mappingCollection.GenerateViews(new List<EdmSchemaError>());*/
                try
                {
                    var year = DateTime.Now.Year;
                    var request = (from c in db.CN_AcctInfo
                                       join code in db.code on  c.SubjectCode equals code.ccode
                                       where c.AcctType == acctType && c.lYear == year && c.IsUsed==1 && code.iyear==year
                                       select new Content
                                       {
                                          ID= c.ID,
                                           AcctName= c.AcctName,
                                           SubjectCode=  c.SubjectCode,
                                           ccode_name=code.ccode_name
                                       }).ToList();

                        return request;
                }
                catch (Exception ex)
                {
                    LogHelper.WriteLog(GetIP.getIP() + "------------------------" + ex.Message);

                    return null;
                }
            }
        }
        /// <summary>
        /// 获取现金交易还是转账交易
        /// </summary>
        /// <returns></returns>
        public object getSettleStyle()
        {
            using (var db = new UFDATA_048_2017Entities()) {

                return (from a in db.SettleStyle
                        orderby a.cSSCode descending
                       select new {
                            a.cSSCode,
                            a.cSSName
                       } ).ToList();
            }
            /*
            string sql = "select * from SettleStyle";
            DataTable dt = SqlHelper.ExecuteDataTable(config, sql);
            List<SettleStyleModel> list = ModelHelper.PutAllVal<SettleStyleModel>(new SettleStyleModel(), dt);
            return list;*/
        }
        /// <summary>
        /// 获取科目
        /// </summary>
        /// <param name="ccode_name">科目描述（根据OA归类大纲来）</param>
        /// <returns></returns>
        public code getCode(string ccode_name)
        {
            using (var db = new UFDATA_048_2017Entities())
            {
                var codes = (from c in db.code where c.iyear == (DateTime.Now.Year) && c.ccode_name == ccode_name select c).FirstOrDefault();
                return codes;
            }
        }

        /// <summary>
        /// 获取u8单个科目明细
        /// </summary>
        /// <param name="ccode"></param>
        /// <returns></returns>
        public code getCodeInU8Byccode(string ccode)
        {
            using (var db = new UFDATA_048_2017Entities())
            {
                return (from c in db.code where c.iyear == (DateTime.Now.Year) && c.ccode.Equals(ccode) select c).FirstOrDefault();
            }
        }
        /// <summary>
        /// 获取常用的科目便于操作人员修改
        /// </summary>
        /// <returns></returns>
        public List<code> getCodeList()
        {
            using (var db = new UFDATA_048_2017Entities())
            {
                var codes = (from c in db.code where c.cclass.Equals("损益") && c.bend == true select c).ToList();
                return codes;
            }
        }
        /// <summary>
        /// 获取流量科目
        /// </summary>
        /// <param name="citemname"></param>
        /// <returns></returns>
        public fitemss98 getProject(string citemname)
        {
            using (var db = new UFDATA_048_2017Entities())
            {
                return (from f in db.fitemss98 where f.citemname.Equals(citemname) select f).FirstOrDefault();
            }
        }
        /// <summary>
        /// 获取流量科目
        /// </summary>
        /// <param name="citemcode"></param>
        /// <returns></returns>
        public fitemss98 getProjectBycode(string citemcode)
        {
            using (var db = new UFDATA_048_2017Entities())
            {
                return (from f in db.fitemss98 where f.citemcode.Equals(citemcode) select f).FirstOrDefault();
            }
        }
        /// <summary>
        /// 获取科目
        /// </summary>
        /// <returns></returns>
        public List<fitemss98> getProject()
        {
            using (var db = new UFDATA_048_2017Entities())
            {
                return db.fitemss98.ToList();
            }
        }
        /// <summary>
        /// 获取部门List
        /// </summary>
        /// <returns></returns>
        public object getDepatementList()
        {
            using (var db = new UFDATA_048_2017Entities())
            {
                try
                {
                    var request = (from d in db.Department
                                   select new
                                   {
                                       d.cDepName,
                                       d.cDepCode
                                   }).ToList();
                    return request;
                }
                catch (Exception ex)
                {
                    LogHelper.WriteLog(GetIP.getIP() + "------------------------" + ex.Message);
                    return null;
                }
            }

        }

        /// <summary>
        /// 获取出纳类别字（收、付）
        /// </summary>
        /// <returns></returns>
        public List<CashSerialNumberModel> getCashSerialNumberBySql()
        {
            string sql = "select * from [CN_CashSerialNumber] ";//只做付款 where [SNWord] like '%付'
            DataTable dt = SqlHelper.ExecuteDataTable(config, sql);
            List<CashSerialNumberModel> list = ModelHelper.PutAllVal<CashSerialNumberModel>(new CashSerialNumberModel(), dt);
            return list;
        }
        /// <summary>
        /// 如何已经生成付款单则不允许再修改付款银行
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        public RecordTable getRecordTableByPid(string pid)
        {
            using (var ent = new OAtoU8DATAEntities())
            {
                var list = (from r in ent.RecordTable
                            where r.Pid.Equals(pid)
                            select r).FirstOrDefault();

                return list;
            }
        }
        /// <summary>
        /// 获取U8发起部门的编码 CN_LevelListID（部门和oa有差异导致有些部门取不到，所以要调整公司架构）
        /// </summary>
        /// <param name="departementName"></param>
        /// <returns></returns>
        public int getDepatement(string departementName)
        {
            using (var db = new UFDATA_048_2017Entities())
            {
                try
                {
                    var request = (from c in db.CN_LevelListID
                                   join d in db.Department on c.LoadID equals d.cDepCode
                                   where d.cDepName.Contains(departementName) && c.ClassID == 2
                                   select c).FirstOrDefault();
                    return request.ID;
                }
                catch (Exception ex)
                {
                   // LogHelper.WriteLog(GetIP.getIP() + "------------------------" + ex.Message);
                    return 0;
                }
            }
        }
        /// <summary>
        /// 获取部门 Department
        /// </summary>
        /// <param name="departementName"></param>
        /// <returns></returns>
        public Department getDepatements(string departementName)
        {
            using (var db = new UFDATA_048_2017Entities())
            {
                try
                {
                    //部门一般都是xxx-xxx，只取最后一个
                    string[] dirName = departementName.Split('-');
                    departementName = dirName[dirName.Length - 1];
                     var request = (from c in db.CN_LevelListID
                                   join d in db.Department on c.LoadID equals d.cDepCode
                                   where d.cDepName.Contains(departementName)
                                   select d).FirstOrDefault();
                    return request;
                }
                catch (Exception ex)
                {
                    LogHelper.WriteLog(GetIP.getIP() + "------------------------" + ex.Message);
                    return null;
                }
            }
        }
        public Department getDepatementByDepCode(string cDepCode)
        {
            using (var db = new UFDATA_048_2017Entities())
            {
               
                    return  (from c in db.CN_LevelListID
                                   join d in db.Department on c.LoadID equals d.cDepCode
                                   where d.cDepCode.Contains(cDepCode)
                                   select d).FirstOrDefault();
               
            }
        }
        /// <summary>
        /// 获取供应商的UnitID，但是呢由于OA没有此表，顾后续打算放入部门表中，根据部门名称来作为查询(供应商)
        /// </summary>
        /// <param name="departementName"></param>
        /// <returns></returns>
        public CN_UnitID geVendortUnit(string shoukuandanwei)
        {
            using (var db = new UFDATA_048_2017Entities())
            {
                try
                {
                    var request = (from v in db.Vendor
                                   join c in db.CN_UnitID on v.cVenCode equals c.LoadVenID
                                   where v.cVenName.Equals(shoukuandanwei)
                                   select c).FirstOrDefault();
                    return request;
                }
                catch (Exception ex)
                {
                    LogHelper.WriteLog(GetIP.getIP() + "------------------------" + ex.Message);
                    return null;
                }
            }
        }
        /// <summary>
        /// 获取供应商的UnitID，但是呢由于OA没有此表，顾后续打算放入部门表中，根据部门名称来作为查询（客户）
        /// </summary>
        /// <param name="departementName"></param>
        /// <returns></returns>
        public CN_UnitID geCustomertUnit(string shoukuandanwei)
        {
            using (var db = new UFDATA_048_2017Entities())
            {
                try
                {
                    var request = (from v in db.Customer
                                   join c in db.CN_UnitID on v.cCusCode equals c.LoadCusID
                                   where v.cCusName.Equals(shoukuandanwei)
                                   select c).FirstOrDefault();
                    return request;
                }
                catch (Exception ex)
                {
                    LogHelper.WriteLog(GetIP.getIP() + "------------------------" + ex.Message);
                    return null;
                }
            }
        }
        /// <summary>
        /// 获取收付出纳编号（收xxxx或者付xxxx）
        /// </summary>
        /// <param name="content"></param>
        /// <param name="shoufu">输入收/付</param>
        /// <returns></returns>
        public string getCashSerialNumber(string content, string shoufu)
        {
            //截取银行的前面数字内容
            //string result = System.Text.RegularExpressions.Regex.Replace(content, @"[^0-9]+", "");
            string result = content.Substring(0, 5);
            using (var db = new UFDATA_048_2017Entities())
            {
                try
                {
                    var request = (from c in db.CN_CashSerialNumber
                                   where c.SNWord.Contains(result) && c.SNWord.Contains(shoufu)
                                   select c).FirstOrDefault();
                    return request.SNWord;
                }
                catch (Exception ex)
                {
                    LogHelper.WriteLog(GetIP.getIP() + "------------------------" + ex.Message);
                    return "010101付";
                }
            }
        }
        /// <summary>
        /// duiqudiyigeshoufukemu
        /// </summary>
        /// <param name="shoufu"></param>
        /// <returns></returns>
        public string getCashSerialNumber(string shoufu)
        {
            //截取银行的前面数字内容
            //string result = System.Text.RegularExpressions.Regex.Replace(content, @"[^0-9]+", "");
            using (var db = new UFDATA_048_2017Entities())
            {
                try
                {
                    var request = (from c in db.CN_CashSerialNumber
                                   where c.SNWord.Contains(shoufu)
                                   select c).FirstOrDefault();
                    return request.SNWord;
                }
                catch (Exception ex)
                {
                    LogHelper.WriteLog(GetIP.getIP() + "------------------------" + ex.Message);
                    return null;
                }
            }
        }
        /// <summary>
        /// 获取U8人员信息
        /// </summary>
        /// <returns></returns>
        public hr_hi_person getPerson(string userName)
        {
            using (var db = new UFDATA_048_2017Entities())
            {
                try
                {
                    var request = (from c in db.hr_hi_person
                                   where c.cPsn_Name.Equals(userName)
                                   select c).FirstOrDefault();
                    return request;
                }
                catch (Exception ex)
                {
                    LogHelper.WriteLog(GetIP.getIP() + "------------------------" + ex.Message);
                    return null;
                }
            }
        }
        #region 生成日记账
        /// <summary>
        /// 单据只做付款操作，收款的后续更新
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public string addToAcctBook(ResultListModel model)
        {
            using (var ent = new OAtoU8DATAEntities())
            {//读取到自己设计表的数据,存在说明已经录入到U8，阻止继续录入;
                var list = (from r in ent.RecordTable
                            where r.Pid.Contains(model.Id)
                            select r).FirstOrDefault();
                if (list != null)
                {
                    //存在数据，返回值
                    return "数据已经提交到U8，禁止重复提交";
                }
            }
            //收款单位是供应商还是客户，用收款单位来确定
            var kehu = geCustomertUnit(model.shoukuandanwei);//客户
            var UnitID = 0; //客户/供应商id
            var UnitType =2;//客户为1，供应商为2
            string UnitMsg = "";//提示给操作员是客户还是供应商
            CN_AcctBook book = new CN_AcctBook();
            if (kehu != null)
            {
                UnitID = kehu.ID;
                UnitType = 1;
                UnitMsg = "，生成的是客户";
                book.CustomerID = UnitID;
            }
            else
            {
                var gonyingshang = geVendortUnit(model.shoukuandanwei);//供应商
                if (gonyingshang != null)
                {
                    UnitID = gonyingshang.ID;
                    UnitType = 2;
                    UnitMsg = "，生成的是供应商";
                    book.VendorID = UnitID;
                }
            }
            var user = getPerson(model.shoukuandanwei);//个人支付
            /*if ((model.feiyongleixing == 0 || model.feiyongleixing == 1 || model.feiyongleixing == 2) && UnitID == 0)
            {//包材原料委外商必须要先制单
                return "收款单位存在异常，未在客户和供应商中查询到改收款单位/人,请核实！";
            }*/
            book.UnitID = UnitID;
            book.UnitType = UnitType;//客户为1，供应商为2
            book.AcctID = model.content.ID;//getAccInfo传过来的Id
            book.AcctType = 1;//日记账类型 
            book.AcctDate = DateTime.Now;//添加时间
            book.Period = DateTime.Now.Month;//期数
            book.ExchangeRate = 1;//汇率 
            book.SettleTypeID = 2;//转账或者现金（统一设置为转账）
            book.Cashier = GetIP.getIP().userName;//出纳员，统一设置Ip出纳
            book.ProjectClass = 25;//CN_LevelClass
            book.lYear = DateTime.Now.Year;//年份设为当前年
            book.lParentID = model.content.ID;//出纳选择银行
         //   CN_AcctInfo cont = getAccInfo(model.content,2);
            book.CSNCashSign = getCashSerialNumber("付");
            //暂时只做支付的，收款的不做，付款的编号确定，如果需要更新，请查询getCashSerialNumber（context）
            book.DeptID = getDepatement(model.faqibumen);
            //一些选项没有值得话默认为0，不然不会显示出来
            book.VoucherNum = book.VoucherNum == null ? 0 : book.VoucherNum;
            book.Debit = book.Debit == null ? 0.0000M : book.Debit;
            book.Credit = book.Credit == null ? 0.0000M : book.Credit;
            book.FDebit = book.FDebit == null ? 0.0000M : book.FDebit;
            book.FCredit = book.FCredit == null ? 0.0000M : book.FCredit;
            book.PersonID = book.PersonID == null ? 0 : book.PersonID;
            book.SourceType = book.SourceType == null ? 0 : book.SourceType;
            book.IsAudited = book.IsAudited == null ? 0 : book.IsAudited;
            book.IsDelete = book.IsDelete == null ? 0 : book.IsDelete;
            book.IsRegGLVouch = book.IsRegGLVouch == null ? 0 : book.IsRegGLVouch;
            book.RectifyID = book.RectifyID == null ? 0 : book.RectifyID;
            book.RectifyType = book.RectifyType == null ? "0" : book.RectifyType;
            book.CACheckFlag = book.CACheckFlag == null ? 0 : book.CACheckFlag;
            book.CBCheckFlag = book.CBCheckFlag == null ? 0 : book.CBCheckFlag;
            book.CustomCol1 = book.CustomCol1 == null ? 0 : book.CustomCol1;
            book.CustomCol2 = book.CustomCol2 == null ? 0 : book.CustomCol2;
            book.CustomCol3 = book.CustomCol3 == null ? 0 : book.CustomCol3;
            book.CashNum = book.CashNum == null ? 0 : book.CashNum;
            book.CustomerID = book.CustomerID == null ? 0 : book.CustomerID;
            book.VendorID = book.VendorID == null ? 0 : book.VendorID;
            book.cDefine7 = book.cDefine7 == null ? 0 : book.cDefine7;
            book.cDefine15 = book.cDefine15 == null ? 0 : book.cDefine15;
            book.cDefine16 = book.cDefine16 == null ? 0 : book.cDefine16;
            book.RateCalType = book.RateCalType == null ? 0 : book.RateCalType;
            using (var db = new UFDATA_048_2017Entities())
            {
                using (var tran = db.Database.BeginTransaction())

                {
                    try
                    {
                        for (int i = 0; i < model.piaoju.Count; i++)
                        {
                            
                            Piaoju piaoju = model.piaoju[i];
                            string Summary = "";
                            decimal credit = Convert.ToDecimal(piaoju.yinhuan); //读取票据的应还金额
                            //银行日记账银行付款为0不添加进去
                            if (credit == 0)
                            {
                                continue;//付款金额为0就没必要添加了；
                            }
                            foreach (Detail list in piaoju.Detail)
                            {
                                if (model.type.Equals("上海悦目-差旅费报销单"))
                                {
                                    list.miaoshu = model.chuangjinshijin + model.chuchaishiyou;//将差旅费报销单的出差事由转移给描述
                                    list.shouyibumen = model.shouyibumen;

                                }
                                if (!string.IsNullOrEmpty(list.miaoshu) && list.kemu.Substring(0, list.kemu.Length - 2) == "220201" && UnitID == 0)
                                {//包材，原料，委外商
                                    return "收款单位存在异常，未在客户和供应商中查询到改收款单位/人,请核实！";
                                }
                                else if (!string.IsNullOrEmpty(list.miaoshu) && list.kemu.Substring(0, list.kemu.Length - 2) == "112301" && (UnitID == 0 || UnitType==1))//费用类型为其他,必须要有供应商
                                {//不要后两位为科目
                                    return "收款单位存在异常，其他费用的供应商未在U8搜索到,请核实！";
                                }
                                else if (!string.IsNullOrEmpty(list.miaoshu) && list.kemu.Substring(0, list.kemu.Length - 2) == "122101" && user == null)//个人借支
                                {//不要后两位为科目
                                    
                                    return "收款单位存在异常，个人借支项目的收款人未在U8搜索到,请核实！";
                                }
                                else {
                                }
                                if (model.type.Equals("上海悦目-差旅费报销单"))
                                {
                                    Summary = model.starDate + "到" + model.endDate + model.chuchaishiyou + ",";
                                    break;
                                }
                                else
                                {
                                    if (!string.IsNullOrEmpty(list.miaoshu))
                                    {//没有摘要的一律不添加
                                        Summary += list.miaoshu + ",";
                                    }
                                }
                            }
                            Summary = Summary.Substring(0, Summary.Length - 1);
                            if (model.type.Equals("上海悦目-费用报销单") || model.type.Equals("上海悦目-付款审批单"))
                            {
                                Summary = model.faqibumen + model.faqiren + "报销" + model.shouyibumen + Summary + "的费用";
                            }
                            if (model.type.Equals("上海悦目-预支单"))
                            {
                                Summary = model.faqibumen + model.faqiren + "预支" + model.shouyibumen + Summary + "的费用";
                            }
                            if (model.type.Equals("上海悦目-差旅费报销单"))
                            {
                                Summary = model.faqibumen + model.faqiren + "报销" + model.shouyibumen + model.faqiren + Summary + "的差旅费";
                            }
                            book.Credit = credit;//需要银行支付的支付金额
                            book.FCredit = credit;//需要银行支付的支付金额
                            book.Summary = Summary;//描述
                            var last = (from b in db.CN_AcctBook
                                        where b.CSNCashSign == book.CSNCashSign
                                        orderby b.CSNCashID descending
                                        select b
                                       ).FirstOrDefault();
                            book.CSNCashID = last == null ? 1 : last.CSNCashID + 1;//编号自动加一
                            db.CN_AcctBook.Add(book);
                            db.SaveChanges();
                            var s = (from b in db.CN_AcctBook
                                     where b.ID == book.ID
                                     select b).FirstOrDefault();
                            s.ID_Old = book.ID;
                            db.SaveChanges();
                            using (var ent = new OAtoU8DATAEntities())
                            {//插入到自己的数据库表进行记录
                                RecordTable record = new RecordTable();
                                record.IsIntoBook = 1;
                                record.piaojuId = i;
                                record.Pid = model.Id;
                                record.Bid = book.ID;
                                record.ip = GetIP.getIP().userName;
                                record.updateTime = DateTime.Now;
                                record.contents = model.content.ToString();
                                ent.RecordTable.Add(record);
                                ent.SaveChanges();
                            }
                        }
                        tran.Commit();
                        return "数据已经更新到U8" + UnitMsg;
                    }
                    catch (Exception ex)
                    {
                        LogHelper.WriteLog(GetIP.getIP() + "------------------------" + ex.Message);
                        tran.Rollback();
                        return "数据更新错误！";
                    }
                }

            }
        }
        #endregion
        #region 生单（拥有收款单位为供应商或者个人时才有）
        /// <summary>
        /// 生单
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public string addToCloseBill(ResultListModel model)
        {
            using (var ent = new OAtoU8DATAEntities())
            {
                var chengchengFUkuandan = (from r in ent.RecordTable
                                           where r.Pid.Contains(model.Id)
                                           select r).FirstOrDefault();
                if (chengchengFUkuandan == null)
                {
                    return "还未生成付款单，无法进行生单操作";
                }
                var RecordTable = (from r in ent.RecordTable
                                   where r.Pid.Contains(model.Id) && r.IsIntoCloseBill != null
                                   select r).FirstOrDefault();
                if (RecordTable != null)
                {
                    return "已经生单到U8，禁止重复提交";
                }
            }
            List<RecordTable> list = new List<RecordTable>();
            using (var ent = new OAtoU8DATAEntities())
            {//读取到自己设计表的数据
                list = (from r in ent.RecordTable
                        where r.Pid.Contains(model.Id)
                        select r).ToList();
            }
            using (var db = new UFDATA_048_2017Entities())
            {
                using (var tran = db.Database.BeginTransaction())
                {
                    try
                    {
                        foreach (var r in list)
                        {
                            var book = (from b in db.CN_AcctBook
                                        where b.ID == r.Bid
                                        select b
                                       ).First();
                            var closeBills = (from c in db.Ap_CloseBills orderby c.iID descending select c).FirstOrDefault();//获取最后一个数据
                            Ap_CloseBills clo = new Ap_CloseBills();
                            clo.iID = closeBills == null ? 10001674 : closeBills.iID + 1;
                            clo.ID = closeBills == null ? 10001739 : closeBills.ID + 1;
                            clo.iType = 0;
                            clo.bPrePay = false;
                            var kehu = (from v in db.Customer
                                        join c in db.CN_UnitID on v.cCusCode equals c.LoadCusID
                                        where v.cCusName.Equals(model.shoukuandanwei)
                                        select v).FirstOrDefault();//获取客户类型的收益部门
                            var cCusVen = "";//
                            var VT_ID = 8055;// 8051收供应商 8055 付客户
                            if (kehu != null)
                            {
                                cCusVen = kehu.cCusCode;
                                VT_ID = 8055;
                            }
                            else
                            {///获取供应商类型的收款类型
                                var gonyingshang = (from v in db.Vendor
                                                    join c in db.CN_UnitID on v.cVenCode equals c.LoadVenID
                                                    where v.cVenName.Equals(model.shoukuandanwei)
                                                    select v).FirstOrDefault();
                                if (gonyingshang != null)
                                {
                                    cCusVen = gonyingshang.cVenCode;
                                    VT_ID = 8051;
                                }
                            }
                            if (string.IsNullOrEmpty(cCusVen))
                            {
                                return "无法搜索到客户或者供应商，无法生单";
                            }
                            clo.cCusVen = cCusVen;//客户或供应商编码
                            clo.iAmt = Convert.ToDecimal(book.Credit);
                            clo.iAmt_f = Convert.ToDecimal(book.Credit);
                            clo.iRAmt = Convert.ToDecimal(book.Credit);
                            clo.iRAmt_f = Convert.ToDecimal(book.Credit);
                            clo.cKm = null;
                            clo.cXmClass = null;
                            clo.cDepCode = getDepatements(model.faqibumen).cDepCode;
                            clo.cPersonCode = null;
                            clo.cItemName = null;
                            clo.iAmt_s = 0;
                            clo.iRAmt_s = 0;
                            clo.iOrderType = null;
                            clo.ifaresettled_f = 0.00M;
                            clo.iOrderType = null;
                            clo.ccItemCode = null;
                            Ap_CloseBill closeBill = new Ap_CloseBill(); //暂时U8数据库设计的是48收供应商，49付客户
                            closeBill.cVouchType = "49";
                            DateTime now = DateTime.Now;
                            DateTime d1 = new DateTime(now.Year, now.Month, 1);
                            DateTime d2 = d1.AddMonths(1).AddDays(-1); //d1是本月的第一天，d2本月的最后一天，
                            var oldLast = (from c in db.Ap_CloseBill
                                           where c.cVouchType.Equals(closeBill.cVouchType) && closeBill.dVouchDate >= d1 &&
                                           closeBill.dVouchDate <= d2
                                           orderby c.cVouchID descending
                                           select c).FirstOrDefault();
                            var cvouchId = DateTime.Now.ToString("yyMM") + "00000001";
                            closeBill.cVouchID = oldLast == null ? cvouchId : (Convert.ToInt64(oldLast.cVouchID) + 1).ToString();
                            closeBill.dVouchDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));
                            closeBill.iPeriod = Convert.ToByte(DateTime.Now.Month);
                            closeBill.cDwCode = cCusVen;//"010001"
                            closeBill.cDeptCode = getDepatements(model.faqibumen).cDepCode;//获取部门 //外键Department表的cDepCode
                            closeBill.cPerson = null;
                            //var fitem = (from f in db.fitem where f.citem_name.Equals("现金流量项目") select f).First();//获取现金流量项目的CLass
                            closeBill.cItem_Class = null; //fitem.citem_class;// 获取项目名称 外键fitem表的 citem_class
                            var settleStyle = (from s in db.SettleStyle where s.cSSName.Equals("转账") select s);
                            closeBill.cSSCode = settleStyle.First().cSSCode;//结算方式编码 01现金 02 转账 //外键SettleStyle表的cSSCode
                            closeBill.cNoteNo = null;
                            closeBill.cCoVouchType = "SC";//对应单据类型 
                            closeBill.cDigest = book.Summary;//摘要
                            closeBill.cexch_name = "人民币";//币种名称
                            closeBill.iExchRate = 1;//汇率 
                            closeBill.iAmount = book.Credit;//本币金额 
                            closeBill.iAmount_f = book.Credit;//原币金额 
                            closeBill.iRAmount = book.Credit;//本币余额 
                            closeBill.iRAmount_f = book.Credit;//原币金额
                            closeBill.cOperator = GetIP.getIP().userName;//录入人 
                            closeBill.bStartFlag = false;//期初标志 
                            var acctInfo = (from a in db.CN_AcctInfo where a.ID == book.AcctID select a).FirstOrDefault();
                            if (acctInfo == null)
                            {
                                return "未设置付款账号";
                            }
                            closeBill.cCode = acctInfo.SubjectCode;//结算科目编码 
                            closeBill.iPayForOther = false;//代付标志
                            closeBill.cFlag = "AP";//AR 应收款管理 AP:应付款管理 
                            closeBill.iID = clo.iID;
                            closeBill.bFromBank = false;//银行导入标志 
                            closeBill.bToBank = false;//导出银行标志 
                            closeBill.bSure = false;//银行确认标志 
                            closeBill.VT_ID = VT_ID;//单据模版号 8051收供应商 8055 付客户
                            closeBill.iAmount_s = 0;//数量 
                            closeBill.IsWfControlled = false;//是否工作流控制 
                            closeBill.iSource = null;
                            closeBill.dmodifysystime = DateTime.Now;
                            closeBill.cmodifier = GetIP.getIP().userName;
                            closeBill.dmoddate = DateTime.Now;
                            closeBill.iPayType = 0;
                            closeBill.csysbarcode = "||ap49|" + closeBill.cVouchID;

                            /*  closeBill.ibg_ctrl = false;//是否预算控制 
                              closeBill.ibg_overflag = 0;//预算审批状态 
                              closeBill.dcreatesystime = DateTime.Now;
                              closeBill.RegisterFlag = 0;//登记标志
                              closeBill.Ufts = TimeHelp.DateToByte(DateTime.Now);//时间转byte
                              closeBill.bReceived = false;//是否接收 
                              closeBill.bSend = false;//是否发送标志                           
                              closeBill.bPrePay = false;//预收预付标志 */
                            CN_PayedRecord pay = new CN_PayedRecord();//支付金额记录,生单中间表
                            pay.iMainID = clo.iID;
                            pay.iSubID = clo.ID;
                            pay.iAcctBookID = book.ID;
                            pay.fMoney = Convert.ToDouble(book.Credit);
                            pay.fMoneyF = Convert.ToDouble(book.Credit);
                            pay.lMakeVouch = 11;//设置成11后就表示已经生单无法修改
                            db.Ap_CloseBill.Add(closeBill);//添加主表
                            db.SaveChanges();
                            db.Ap_CloseBills.Add(clo);//添加子表
                            db.SaveChanges();
                            db.CN_PayedRecord.Add(pay);//添加中间表
                            db.SaveChanges();
                            //添加成功一个更新自定义表数据
                            using (var ent = new OAtoU8DATAEntities())
                            {
                                var request = (from re in ent.RecordTable
                                               where re.Bid == book.ID
                                               select re).FirstOrDefault();
                                request.ip2 = GetIP.getIP().userName;
                                request.updateTime2 = DateTime.Now;
                                request.IsIntoCloseBill = 1;
                                ent.SaveChanges();
                            }

                        }
                        tran.Commit();
                        return "生单成功";
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        LogHelper.WriteLog(GetIP.getIP() + "------------------------" + ex.Message);
                        return "生单失败";
                    }
                }
            }
        }
        #endregion
        #region 制单
        /// <summary>
        /// 制单
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public string addToCashSignRelate(ResultListModel model)
        {
            Boolean shifouShendan = false;
            using (var ent = new OAtoU8DATAEntities())
            {
                var RecordTables = (from r in ent.RecordTable
                                    where r.Pid.Contains(model.Id) && r.IsIntoAccvouch != null
                                    select r).FirstOrDefault();
                if (RecordTables != null)
                {
                    //存在数据，返回值
                    return "已经制单到U8，禁止重复提交";
                }
                if (model.feiyongleixing == 1 || model.feiyongleixing == 2 || model.feiyongleixing == 3)
                {//包材原料委外商会计审核的单必须要先生单
                    var shengdan = (from r in ent.RecordTable
                                    where r.Pid.Contains(model.Id) && r.IsIntoCloseBill != null
                                    select r).FirstOrDefault();
                    if (shengdan == null)
                    {
                        //存在数据，返回值
                        return "必须先生单才能制单";
                    }
                    shifouShendan = true;
                }
            }
            List<RecordTable> RecordTableList = new List<RecordTable>();
            using (var ent = new OAtoU8DATAEntities())
            {//读取到自己设计表的数据
                RecordTableList = (from r in ent.RecordTable
                                   where r.Pid.Contains(model.Id)
                                   select r).ToList();
            }
            using (var db = new UFDATA_048_2017Entities())
            {
                using (var tran = db.Database.BeginTransaction())
                {
                    using (var ent = new OAtoU8DATAEntities())
                    {
                        using (var trans = ent.Database.BeginTransaction())
                        {
                            try
                            {
                                for (int i = 0; i < RecordTableList.Count; i++)
                                {
                                    var RecordTable = RecordTableList[i];
                                    var piaoju = model.piaoju[Convert.ToInt32(RecordTable.piaojuId)];//获取对应生成的票据
                                    var book = (from b in db.CN_AcctBook
                                                where b.ID == RecordTable.Bid
                                                select b
                                                     ).First();

                                    var clobil = (from cb in db.Ap_CloseBill
                                                  join c in db.Ap_CloseBills on cb.iID equals c.iID
                                                  join cp in db.CN_PayedRecord on c.iID equals cp.iMainID
                                                  where cp.iAcctBookID == book.ID
                                                  select cb).FirstOrDefault();
                                    string sign = book.CSNCashSign.Substring(0, 5);
                                    var dsign = (from d in db.dsign where d.csign.Contains(sign) select d).FirstOrDefault();
                                    GL_accvouch acc = new GL_accvouch();
                                    var time = TimeHelp.ConvertDateTimeToInt(DateTime.Now);
                                    var acctInfo = (from a in db.CN_AcctInfo where a.ID == book.AcctID select a).FirstOrDefault();
                                    if (acctInfo == null)
                                    {
                                        return "未设置付款账号";
                                    }
                                    var kehu = (from cu in db.Customer
                                                join c in db.CN_UnitID on cu.cCusCode equals c.LoadCusID
                                                where c.ID == book.UnitID
                                                select cu).FirstOrDefault();//获取客户类型的收益部门
                                    var cCusVen = "";
                                    var unitType = 0;//0表示客户
                                    if (kehu != null)
                                    {
                                        unitType = 0;
                                        cCusVen = kehu.cCusCode;
                                    }
                                    else
                                    {///获取供应商类型的收款类型
                                        var gonyingshang = (from ve in db.Vendor
                                                            join c in db.CN_UnitID on ve.cVenCode equals c.LoadVenID
                                                            where c.ID == book.UnitID
                                                            select ve).FirstOrDefault();
                                        if (gonyingshang != null)
                                        {
                                            unitType = 1;
                                            cCusVen = gonyingshang.cVenCode;
                                        }
                                    }
                                    var user = getPerson(model.shoukuandanwei);
                                    //先遍历增加付款明细账单
                                    int inid = 0;//明细排序位置
                                    var ccodeList = "";
                                    Dictionary<string, Decimal> cashList = new Dictionary<string, Decimal>();//流量集合
                                    ArrayList students = new ArrayList();
                                    // var shenyuZhifu = piaoju.yinhuanQuanbu;
                                    var coutno_id = (from g in db.GL_accvouch
                                                     where g.coutsysname.Equals("AP")
                                                     orderby g.coutno_id descending
                                                     select g.coutno_id).FirstOrDefault();
                                    if (coutno_id == null)
                                    {
                                        coutno_id = "01AP00000000001";
                                    }
                                    else
                                    {
                                        if (coutno_id.Equals("01AP"))
                                        {
                                            var last = Convert.ToInt32(coutno_id.Replace("01AP", ""));
                                            last++;
                                            coutno_id = "01AP" + last.ToString().PadLeft(11, '0');
                                        }
                                    }  //收款单位是供应商还是客户，用收款单位来确定
                                    foreach (var detail in piaoju.Detail)
                                    {//付款明细遍历
                                        if (model.type.Equals("上海悦目-差旅费报销单"))
                                        {
                                            detail.miaoshu = detail.riqi + model.chuchaishiyou;//将差旅费报销单的出差事由转移给描述
                                            detail.kemu = "660118";//差旅费
                                            detail.jine = detail.jinexiaoji;
                                            detail.shouyibumen = model.shouyibumen;

                                        }

                                        if (string.IsNullOrEmpty(detail.miaoshu))
                                        {//没有摘要消息默认为填充票据
                                            continue;
                                        }
                                        if (detail.shouyibumen.Length == 1) {//部门代码只有一位数的话需要替补成两位
                                            detail.shouyibumen="0"+ detail.shouyibumen;
                                        }
                                        var dep = detail.shouyibumen;
                                        if (!string.IsNullOrEmpty(detail.miaoshu))
                                        {//获取流量集合
                                            inid++;
                                            if (string.IsNullOrEmpty(detail.kemu))
                                            {
                                                return "请确认每一条明细都选择了对应科目";
                                            }
                                            if (model.type.Equals("上海悦目-预支单"))
                                            {//预支单获取到的科目的最后两位为对应的流量，所以要单独拆分
                                                var oldKemu = detail.kemu;
                                                detail.kemu = detail.kemu.Substring(0, detail.kemu.Length - 2);
                                                var kemu = oldKemu.Replace(detail.kemu, "");//获取科目
                                                if (!cashList.ContainsKey(kemu))
                                                {
                                                    cashList[kemu] = Convert.ToDecimal(detail.jine);
                                                }
                                                else
                                                {
                                                    cashList[kemu] = cashList[kemu] + Convert.ToDecimal(detail.jine);
                                                }
                                            }
                                            else
                                            {
                                                var kemu = new CashHelp().getCash(Convert.ToInt32(detail.kemu));//获取科目
                                                if (!cashList.ContainsKey(kemu))
                                                {
                                                    cashList[kemu] = Convert.ToDecimal(detail.jine);
                                                }
                                                else
                                                {
                                                    cashList[kemu] = cashList[kemu] + Convert.ToDecimal(detail.jine);
                                                }
                                            }
                                            ccodeList = detail.kemu + ",";
                                            if (detail.shuie != 0)
                                            {//当需要交税额的时候
                                                acc = new GL_accvouch()
                                                {
                                                    iperiod = Convert.ToByte(DateTime.Now.Month),
                                                    csign = dsign == null ? "010101记" : dsign.csign,//凭证类别字
                                                    isignseq = 1,//凭证类别排序号 
                                                    ino_id = Convert.ToInt16(book.ID),//凭证编号 
                                                    inid = Convert.ToInt16(inid),//在12循环行号 
                                                    dbill_date = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd")),//制单日期
                                                    idoc = shifouShendan == false ? (short)0 : (short)1,//附单据数 (不生单为0生单为1)
                                                    cbill = GetIP.getIP().userName,//制单人
                                                    ccheck = null,
                                                    cbook = null,
                                                    ibook = 0,
                                                    ccashier = shifouShendan == false ? book.Cashier : null,//出纳签字人(不生单的签字了，生单的没有)
                                                    iflag = null,
                                                    ctext1 = null,
                                                    ctext2 = null,
                                                    cdigest = model.faqibumen + model.faqiren + "报销" + model.shouyibumen + detail.miaoshu,//摘要 
                                                    ccode = detail.kemu,//科目编码 ，付款的用申请表里的付款科目来做查询(付款为你选择的科目编号)
                                                    cexch_name = null,
                                                    md = Convert.ToDecimal(detail.shuihoujine), //借方金额 
                                                    mc = 0.00M, //  mc = i == 1 ? Convert.ToDecimal(book.Credit) : 0.00M,//和上面一个有值它就为0.00M 贷方金额 
                                                    mc_f = 0.00M,//外币贷方金额  
                                                    md_f = 0.00M,//外币借方金额 
                                                    nfrat = 0,//汇率 
                                                    nc_s = 0,//数量贷方 
                                                    nd_s = 0,//数量借方 
                                                    csettle = null,// (from s in db.SettleStyle where s.cSSName.Equals("转账") select s).First().cSSCode,//结算方式编码 
                                                    cn_id = null,
                                                    dt_date = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd")),
                                                    cdept_id = user==null? detail.shouyibumen:user.cDept_num, //getDepatements(r.shouyibumen).cDepCode,
                                                    cperson_id = user == null ? null:user.cPsn_Num,
                                                    csup_id = (book.UnitID != 0 && unitType == 1) ? cCusVen : null,
                                                    ccus_id = (book.UnitID != 0 && unitType == 0) ? cCusVen : null,
                                                    citem_id = null,
                                                    citem_class = null,
                                                    cname = shifouShendan == false ? null : "-",
                                                    ccode_equal = acctInfo.SubjectCode,//科目编码 ，付款的用申请表里的付款科目来做查询(付款为你选择的科目编号)
                                                    iflagbank = null,
                                                    iflagPerson = null,
                                                    coutaccset = "046",//上海悦目046，广东悦肌048
                                                    ioutyear = (short)DateTime.Now.Year,//外部凭证会计年度 
                                                    coutsysname = book.UnitID == 0 ? "SC" : "AP",//外部凭证系统名称
                                                    coutsysver = null,
                                                    doutbilldate = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd")),//外部凭证制单日期
                                                    ioutperiod = Convert.ToByte(DateTime.Now.Month),//外部凭证会计期间 
                                                    coutsign = shifouShendan == false ? "出纳管理" : "RP",//外部凭证账套号 RP AP
                                                    coutno_id = shifouShendan == false ? "SC" + time : coutno_id,//外部凭证业务号 
                                                    doutdate = DateTime.Now,
                                                    coutbillsign = shifouShendan == false ? null : "49",
                                                    coutid = clobil == null ? null : clobil.cVouchID + "                  " + inid,
                                                    bvouchedit = true,//凭证是否可修改 
                                                    bvouchAddordele = true,//凭证分录是否可增删
                                                    bvouchmoneyhold = false,//凭证合计金额是否保值
                                                    bvalueedit = false,//分录数值是否可修改
                                                    bcodeedit = true,//分录科目是否可修改 
                                                    ccodecontrol = "AP",
                                                    bPCSedit = false,//分录往来项是否可修改 
                                                    bDeptedit = true,//分录部门是否可修改 
                                                    bItemedit = true,//分录项目是否可修改 
                                                    bCusSupInput = false,//分录往来项是否必输
                                                    iyear = Convert.ToInt16(DateTime.Now.Year),//凭证的会计年度
                                                    cblueoutno_id = null,

                                                    ccodeexch_equal = acctInfo.SubjectCode,//对方科目编码 ，付款的用申请表里的付款科目来做查询(付款为你选择的科目编号) 
                                                    tvouchtime = DateTime.Now,//凭证保存时间 
                                                    iYPeriod = Convert.ToInt32(DateTime.Now.Year + "" + (DateTime.Now.Month >= 10 ? DateTime.Now.Month.ToString() : "0" + DateTime.Now.Month)),
                                                    RowGuid = Guid.NewGuid().ToString(),//包括年度的会计期间 //行标识.规律不知道
                                                    bFlagOut = false,//公司对帐是否导出过对帐单
                                                    bdelete = false,//是否核销 
                                                };
                                                db.GL_accvouch.Add(acc);
                                                //存在税额添加一条税额摘要
                                                inid++;
                                                detail.kemu = "22210101";//22210101进项税额
                                                acc = new GL_accvouch()
                                                {
                                                    iperiod = Convert.ToByte(DateTime.Now.Month),
                                                    csign = dsign == null ? "010101记" : dsign.csign,//凭证类别字
                                                    isignseq = 1,//凭证类别排序号 
                                                    ino_id = Convert.ToInt16(book.ID),//凭证编号 
                                                    inid = Convert.ToInt16(inid),//在12循环行号 
                                                    dbill_date = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd")),//制单日期
                                                    idoc = shifouShendan == false ? (short)0 : (short)1,//附单据数 (不生单为0生单为1)
                                                    cbill = GetIP.getIP().userName,//制单人
                                                    ccheck = null,
                                                    cbook = null,
                                                    ibook = 0,
                                                    ccashier = shifouShendan == false ? book.Cashier : null,//出纳签字人(不生单的签字了，生单的没有)
                                                    iflag = null,
                                                    ctext1 = null,
                                                    ctext2 = null,
                                                    cdigest = model.faqibumen + model.faqiren + "报销" + model.shouyibumen + detail.miaoshu + "的税费",//摘要 
                                                    ccode = detail.kemu,//科目编码 ，付款的用申请表里的付款科目来做查询(付款为你选择的科目编号)
                                                    cexch_name = null,
                                                    md = Convert.ToDecimal(detail.shuie),//借方金额 (需缴税额)
                                                    mc = 0.00M, //  mc = i == 1 ? Convert.ToDecimal(book.Credit) : 0.00M,//和上面一个有值它就为0.00M 贷方金额 
                                                    mc_f = 0.00M,//外币贷方金额  
                                                    md_f = 0.00M,//外币借方金额 
                                                    nfrat = 0,//汇率 
                                                    nc_s = 0,//数量贷方 
                                                    nd_s = 0,//数量借方 
                                                    csettle = null,// (from s in db.SettleStyle where s.cSSName.Equals("转账") select s).First().cSSCode,//结算方式编码 
                                                    cn_id = null,
                                                    dt_date = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd")),
                                                    cdept_id = user == null ? detail.shouyibumen : user.cDept_num, //getDepatements(r.shouyibumen).cDepCode,
                                                    cperson_id = user == null ? null : user.cPsn_Num,
                                                    csup_id = (book.UnitID != 0 && unitType == 1) ? cCusVen : null,
                                                    ccus_id = (book.UnitID != 0 && unitType == 0) ? cCusVen : null,
                                                    citem_id = null,
                                                    citem_class = null,
                                                    cname = shifouShendan == false ? null : "-",
                                                    ccode_equal = acctInfo.SubjectCode,//科目编码 ，付款的用申请表里的付款科目来做查询(付款为你选择的科目编号)
                                                    iflagbank = null,
                                                    iflagPerson = null,
                                                    coutaccset = "046",//上海悦目046，广东悦肌048
                                                    ioutyear = (short)DateTime.Now.Year,//外部凭证会计年度 
                                                    coutsysname = book.UnitID == 0 ? "SC" : "AP",//外部凭证系统名称
                                                    coutsysver = null,
                                                    doutbilldate = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd")),//外部凭证制单日期
                                                    ioutperiod = Convert.ToByte(DateTime.Now.Month),//外部凭证会计期间 
                                                    coutsign = shifouShendan == false ? "出纳管理" : "RP",//外部凭证账套号 RP AP
                                                    coutno_id = shifouShendan == false ? "SC" + time : coutno_id,//外部凭证业务号 
                                                    doutdate = DateTime.Now,
                                                    coutbillsign = shifouShendan == false ? null : "49",
                                                    coutid = clobil == null ? null : clobil.cVouchID + "                  " + inid,
                                                    bvouchedit = true,//凭证是否可修改 
                                                    bvouchAddordele = true,//凭证分录是否可增删
                                                    bvouchmoneyhold = false,//凭证合计金额是否保值
                                                    bvalueedit = false,//分录数值是否可修改
                                                    bcodeedit = true,//分录科目是否可修改 
                                                    ccodecontrol = "AP",
                                                    bPCSedit = false,//分录往来项是否可修改 
                                                    bDeptedit = true,//分录部门是否可修改 
                                                    bItemedit = true,//分录项目是否可修改 
                                                    bCusSupInput = false,//分录往来项是否必输
                                                    iyear = Convert.ToInt16(DateTime.Now.Year),//凭证的会计年度
                                                    cblueoutno_id = null,

                                                    ccodeexch_equal = acctInfo.SubjectCode,//对方科目编码 ，付款的用申请表里的付款科目来做查询(付款为你选择的科目编号) 
                                                    tvouchtime = DateTime.Now,//凭证保存时间 
                                                    iYPeriod = Convert.ToInt32(DateTime.Now.Year + "" + (DateTime.Now.Month >= 10 ? DateTime.Now.Month.ToString() : "0" + DateTime.Now.Month)),
                                                    RowGuid = Guid.NewGuid().ToString(),//包括年度的会计期间 //行标识.规律不知道
                                                    bFlagOut = false,//公司对帐是否导出过对帐单
                                                    bdelete = false,//是否核销 
                                                };
                                                db.GL_accvouch.Add(acc);
                                            }
                                            else
                                            {
                                                acc = new GL_accvouch()
                                                {
                                                    iperiod = Convert.ToByte(DateTime.Now.Month),
                                                    csign = dsign == null ? "010101记" : dsign.csign,//凭证类别字
                                                    isignseq = 1,//凭证类别排序号 
                                                    ino_id = Convert.ToInt16(book.ID),//凭证编号 
                                                    inid = Convert.ToInt16(inid),//在12循环行号 
                                                    dbill_date = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd")),//制单日期
                                                    idoc = shifouShendan == false ? (short)0 : (short)1,//附单据数 (不生单为0生单为1)
                                                    cbill = GetIP.getIP().userName,//制单人
                                                    ccheck = null,
                                                    cbook = null,
                                                    ibook = 0,
                                                    ccashier = shifouShendan == false ? book.Cashier : null,//出纳签字人(不生单的签字了，生单的没有)
                                                    iflag = null,
                                                    ctext1 = null,
                                                    ctext2 = null,
                                                    cdigest = model.faqibumen + model.faqiren + "报销" + model.shouyibumen + detail.miaoshu,//摘要 
                                                    ccode = detail.kemu,//科目编码 ，付款的用申请表里的付款科目来做查询(付款为你选择的科目编号)
                                                    cexch_name = null,
                                                    md = Convert.ToDecimal(detail.jine),//借方金额 
                                                    mc = 0.00M, //  mc = i == 1 ? Convert.ToDecimal(book.Credit) : 0.00M,//和上面一个有值它就为0.00M 贷方金额 
                                                    mc_f = 0.00M,//外币贷方金额  
                                                    md_f = 0.00M,//外币借方金额 
                                                    nfrat = 0,//汇率 
                                                    nc_s = 0,//数量贷方 
                                                    nd_s = 0,//数量借方 
                                                    csettle = null,// (from s in db.SettleStyle where s.cSSName.Equals("转账") select s).First().cSSCode,//结算方式编码 
                                                    cn_id = null,
                                                    dt_date = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd")),
                                                    cdept_id = user == null ? detail.shouyibumen : user.cDept_num, //getDepatements(r.shouyibumen).cDepCode,
                                                    cperson_id = user == null ? null : user.cPsn_Num,
                                                    csup_id = (book.UnitID != 0 && unitType == 1) ? cCusVen : null,
                                                    ccus_id = (book.UnitID != 0 && unitType == 0) ? cCusVen : null,
                                                    citem_id = null,
                                                    citem_class = null,
                                                    cname = shifouShendan == false ? null : "-",
                                                    ccode_equal = acctInfo.SubjectCode,//科目编码 ，付款的用申请表里的付款科目来做查询(付款为你选择的科目编号)
                                                    iflagbank = null,
                                                    iflagPerson = null,
                                                    coutaccset = "046",//上海悦目046，广东悦肌048
                                                    ioutyear = (short)DateTime.Now.Year,//外部凭证会计年度 
                                                    coutsysname = book.UnitID == 0 ? "SC" : "AP",//外部凭证系统名称
                                                    coutsysver = null,
                                                    doutbilldate = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd")),//外部凭证制单日期
                                                    ioutperiod = Convert.ToByte(DateTime.Now.Month),//外部凭证会计期间 
                                                    coutsign = shifouShendan == false ? "出纳管理" : "RP",//外部凭证账套号 RP AP
                                                    coutno_id = shifouShendan == false ? "SC" + time : coutno_id,//外部凭证业务号 
                                                    doutdate = DateTime.Now,
                                                    coutbillsign = shifouShendan == false ? null : "49",
                                                    coutid = clobil == null ? null : clobil.cVouchID + "                  " + inid,
                                                    bvouchedit = true,//凭证是否可修改 
                                                    bvouchAddordele = true,//凭证分录是否可增删
                                                    bvouchmoneyhold = false,//凭证合计金额是否保值
                                                    bvalueedit = false,//分录数值是否可修改
                                                    bcodeedit = true,//分录科目是否可修改 
                                                    ccodecontrol = "AP",
                                                    bPCSedit = false,//分录往来项是否可修改 
                                                    bDeptedit = true,//分录部门是否可修改 
                                                    bItemedit = true,//分录项目是否可修改 
                                                    bCusSupInput = false,//分录往来项是否必输
                                                    iyear = Convert.ToInt16(DateTime.Now.Year),//凭证的会计年度
                                                    cblueoutno_id = null,

                                                    ccodeexch_equal = acctInfo.SubjectCode,//对方科目编码 ，付款的用申请表里的付款科目来做查询(付款为你选择的科目编号) 
                                                    tvouchtime = DateTime.Now,//凭证保存时间 
                                                    iYPeriod = Convert.ToInt32(DateTime.Now.Year + "" + (DateTime.Now.Month >= 10 ? DateTime.Now.Month.ToString() : "0" + DateTime.Now.Month)),
                                                    RowGuid = Guid.NewGuid().ToString(),//包括年度的会计期间 //行标识.规律不知道
                                                    bFlagOut = false,//公司对帐是否导出过对帐单
                                                    bdelete = false,//是否核销 
                                                };
                                                db.GL_accvouch.Add(acc);
                                            }
                                        }
                                    }
                                    if (!string.IsNullOrEmpty(piaoju.yuzhijine) && Convert.ToInt32(piaoju.yuzhijine) != 0)
                                    {//预支金额录入
                                        var users = db.Person.Where(p => p.cPersonName.Equals(model.faqiren)).FirstOrDefault();
                                        if (users == null)
                                        {
                                            return "该经手人无个人借款记录或者预支单还未能进行生单操作，无法进行借款操作，单据存在错误，请核实！";
                                        }
                                        //获取预支单数据
                                        col_summary yuzhidanColSummary = null;

                                        using (var v3x = new v3xEntities())
                                        { var colId = Convert.ToInt64(model.colId);
                                            yuzhidanColSummary = (from c in v3x.col_summary
                                                                  join a in v3x.v3x_affair on c.id equals a.object_id
                                                                  join af in v3x.v3x_attachment on a.id equals af.genesis_id
                                                                  join co in v3x.col_summary on af.sub_reference equals co.id
                                                                  where co.id == colId
                                                                  select c
                                                                ).FirstOrDefault();
                                            if (yuzhidanColSummary == null) {
                                                return "未关联预支单，无法进行制单";
                                            }

                                            var col_bodyYuzhi = (from body in v3x.col_body
                                                      join col in v3x.col_summary on body.col_id equals col.id
                                                      where col.id == yuzhidanColSummary.id
                                                      select body).FirstOrDefault();
                                            var content = Convert.ToInt64(col_bodyYuzhi.content);
                                            var formmain = v3x.formmain_0593.Where(o => o.id == content).FirstOrDefault();//formmain_0593预支单
                                            var formsonList = v3x.formson_0594.Where(o => o.formmain_0593Id == formmain.id).ToList();//formson_0594预支单明细
                                            if (piaoju.yuzhijine.Equals(formmain.field0010))
                                            {
                                                foreach (var formson in formsonList) {//循环读取预支单摘要录入到U8
                                                    inid++;
                                                    //后续可能要先根据关联的预支单查询到预支科目//122101为个人借支
                                                    GL_accvouch accJiezhi = new GL_accvouch()
                                                    {
                                                        iperiod = Convert.ToByte(DateTime.Now.Month),
                                                        csign = dsign == null ? "010101记" : dsign.csign,//凭证类别字
                                                        isignseq = 1,//凭证类别排序号 
                                                        ino_id = Convert.ToInt16(book.ID),//凭证编号 
                                                        inid = Convert.ToInt16(inid),//在12循环行号 
                                                        dbill_date = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd")),//制单日期
                                                        idoc = shifouShendan == false ? (short)0 : (short)1,//附单据数 (不生单为0生单为1)
                                                        cbill = GetIP.getIP().userName,//制单人
                                                        ccheck = null,
                                                        cbook = null,
                                                        ibook = 0,
                                                        ccashier = shifouShendan == false ? book.Cashier : null,//出纳签字人(不生单的签字了，生单的没有)
                                                        iflag = null,
                                                        ctext1 = null,
                                                        ctext2 = null,
                                                        cexch_name = null,
                                                        nc_s = 0,//数量贷方 
                                                        nd_s = 0,//数量借方 
                                                        nfrat = 0,//汇率 
                                                        mc_f = 0.00M,//外币贷方金额  
                                                        md_f = 0.00M,//外币借方金额
                                                        md = 0.00M, //借方金额 
                                                        csettle = null,// (from s in db.SettleStyle where s.cSSName.Equals("转账") select s).First().cSSCode,//结算方式编码 
                                                        cn_id = null,
                                                        dt_date = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd")),
                                                        cdept_id = user == null ? getDepatements(model.shouyibumen).cDepCode : user.cDept_num, //getDepatements(r.shouyibumen).cDepCode,
                                                        cperson_id = user == null ? null : user.cPsn_Num,
                                                        csup_id = (book.UnitID != 0 && unitType == 1) ? cCusVen : null,
                                                        ccus_id = (book.UnitID != 0 && unitType == 0) ? cCusVen : null,
                                                        citem_id = null,
                                                        citem_class = null,
                                                        cname = shifouShendan == false ? null : "-",
                                                        ccode_equal = ccodeList,//科目编码 ，付款的用申请表里的付款科目来做查询(付款为你选择的科目编号)
                                                        iflagbank = null,
                                                        iflagPerson = null,
                                                        coutaccset = "046",//上海悦目046，广东悦肌048
                                                        ioutyear = (short)DateTime.Now.Year,//外部凭证会计年度 
                                                        coutsysname = book.UnitID == 0 ? "SC" : "AP",//外部凭证系统名称
                                                        coutsysver = null,
                                                        doutbilldate = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd")),//外部凭证制单日期
                                                        ioutperiod = Convert.ToByte(DateTime.Now.Month),//外部凭证会计期间 
                                                        coutsign = shifouShendan == false ? "出纳管理" : "RP",//外部凭证账套号 RP AP
                                                        coutno_id = shifouShendan == false ? "SC" + time : coutno_id,//外部凭证业务号 
                                                        doutdate = DateTime.Now,
                                                        coutbillsign = shifouShendan == false ? null : "49",
                                                        coutid = clobil == null ? null : clobil.cVouchID + "                  " + inid,
                                                        bvouchedit = true,//凭证是否可修改 
                                                        bvouchAddordele = true,//凭证分录是否可增删
                                                        bvouchmoneyhold = false,//凭证合计金额是否保值
                                                        bvalueedit = false,//分录数值是否可修改
                                                        bcodeedit = true,//分录科目是否可修改 
                                                        ccodecontrol = "AP",
                                                        bPCSedit = false,//分录往来项是否可修改 
                                                        bDeptedit = true,//分录部门是否可修改 
                                                        bItemedit = true,//分录项目是否可修改 
                                                        bCusSupInput = false,//分录往来项是否必输
                                                        iyear = Convert.ToInt16(DateTime.Now.Year),//凭证的会计年度
                                                        cblueoutno_id = null,
                                                        ccodeexch_equal = acctInfo.SubjectCode,//对方科目编码 ，付款的用申请表里的付款科目来做查询(付款为你选择的科目编号)
                                                                                               // daudit_date = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd")),//凭证审核日期 
                                                        tvouchtime = DateTime.Now,//凭证保存时间 
                                                        iYPeriod = Convert.ToInt32(DateTime.Now.Year + "" + (DateTime.Now.Month >= 10 ? DateTime.Now.Month.ToString() : "0" + DateTime.Now.Month)),
                                                        RowGuid = Guid.NewGuid().ToString(),//包括年度的会计期间 
                                                        bFlagOut = false,//公司对帐是否导出过对帐单
                                                        bdelete = false,//是否核销 
                                                        mc = Convert.ToDecimal(piaoju.yuzhijine), //  mc = i == 1 ? Convert.ToDecimal(book.Credit) : 0.00M,//和上面一个有值它就为0.00M 贷方金额 
                                                        //ccode = "122101",//这个就重要了 对方科目编码 ，付款的用申请表里的付款科目来做查询(付款为你选择的科目编号)
                                                        ccode= formson.field0028.Substring(0, formson.field0028.Length-2),//获取预支单的明细科目
                                                        cdigest = model.faqiren + book.Summary + "借支"+ formson.field0026+"的借支",//摘要 
                                                    };
                                                    db.GL_accvouch.Add(accJiezhi);
                                                }

                                            }
                                            else
                                            {
                                                return "预支金额和提供的预支单金额不对应，无法制单";
                                            }
                                        }
                                    }
                                    ccodeList = ccodeList.Substring(0, ccodeList.Length - 1);
                                    //付款银行流水录入，保证收支平衡
                                    inid++;
                                    GL_accvouch accs = new GL_accvouch()
                                    {//付款方录入
                                        iperiod = Convert.ToByte(DateTime.Now.Month),
                                        csign = dsign == null ? "010101记" : dsign.csign,//凭证类别字
                                        isignseq = 1,//凭证类别排序号 
                                        ino_id = Convert.ToInt16(book.ID),//凭证编号 
                                        inid = Convert.ToInt16(inid),//在12循环行号 
                                        dbill_date = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd")),//制单日期
                                        idoc = shifouShendan == false ? (short)0 : (short)1,//附单据数 (不生单为0生单为1)
                                        cbill = GetIP.getIP().userName,//制单人
                                        ccheck = null,
                                        cbook = null,
                                        ibook = 0,
                                        ccashier = shifouShendan == false ? book.Cashier : null,//出纳签字人(不生单的签字了，生单的没有)
                                        iflag = null,
                                        ctext1 = null,
                                        ctext2 = null,
                                        cdigest = book.Summary,//摘要 
                                        ccode = acctInfo.SubjectCode,//科目编码 ，付款的用申请表里的付款科目来做查询(付款为你选择的科目编号)
                                        cexch_name = null,
                                        nc_s = 0,//数量贷方 
                                        nd_s = 0,//数量借方 
                                        nfrat = 0,//汇率 
                                        mc_f = 0.00M,//外币贷方金额  
                                        md_f = 0.00M,//外币借方金额
                                        md = 0.00M, //借方金额 
                                        mc = Convert.ToDecimal(piaoju.yinhuan),//贷方金额 
                                        csettle = null,// (from s in db.SettleStyle where s.cSSName.Equals("转账") select s).First().cSSCode,//结算方式编码 
                                        cn_id = null,
                                        dt_date = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd")),
                                        cdept_id = user == null ? getDepatements(model.shouyibumen).cDepCode : user.cDept_num, //getDepatements(r.shouyibumen).cDepCode,
                                        cperson_id = user == null ? null : user.cPsn_Num,
                                        csup_id = (book.UnitID != 0 && unitType == 1) ? cCusVen : null,
                                        ccus_id = (book.UnitID != 0 && unitType == 0) ? cCusVen : null,
                                        citem_id = null,
                                        citem_class = null,
                                        cname = shifouShendan == false ? null : "-",
                                        ccode_equal = ccodeList,//科目编码 ，付款的用申请表里的付款科目来做查询(付款为你选择的科目编号)
                                        iflagbank = null,
                                        iflagPerson = null,
                                        coutaccset = "046",//上海悦目046，广东悦肌048
                                        ioutyear = (short)DateTime.Now.Year,//外部凭证会计年度 
                                        coutsysname = book.UnitID == 0 ? "SC" : "AP",//外部凭证系统名称
                                        coutsysver = null,
                                        doutbilldate = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd")),//外部凭证制单日期
                                        ioutperiod = Convert.ToByte(DateTime.Now.Month),//外部凭证会计期间 
                                        coutsign = shifouShendan == false ? "出纳管理" : "RP",//外部凭证账套号 RP AP
                                        coutno_id = shifouShendan == false ? "SC" + time : coutno_id,//外部凭证业务号 
                                        doutdate = DateTime.Now,
                                        coutbillsign = shifouShendan == false ? null : "49",
                                        coutid = clobil == null ? null : clobil.cVouchID + "                  " + inid,
                                        bvouchedit = true,//凭证是否可修改 
                                        bvouchAddordele = true,//凭证分录是否可增删
                                        bvouchmoneyhold = false,//凭证合计金额是否保值
                                        bvalueedit = false,//分录数值是否可修改
                                        bcodeedit = true,//分录科目是否可修改 
                                        ccodecontrol = "AP",
                                        bPCSedit = false,//分录往来项是否可修改 
                                        bDeptedit = true,//分录部门是否可修改 
                                        bItemedit = true,//分录项目是否可修改 
                                        bCusSupInput = false,//分录往来项是否必输
                                        iyear = Convert.ToInt16(DateTime.Now.Year),//凭证的会计年度
                                        cblueoutno_id = null,
                                        ccodeexch_equal = acctInfo.SubjectCode,//对方科目编码 ，付款的用申请表里的付款科目来做查询(付款为你选择的科目编号)
                                                                               // daudit_date = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd")),//凭证审核日期 
                                        tvouchtime = DateTime.Now,//凭证保存时间 
                                        iYPeriod = Convert.ToInt32(DateTime.Now.Year + "" + (DateTime.Now.Month >= 10 ? DateTime.Now.Month.ToString() : "0" + DateTime.Now.Month)),
                                        RowGuid = Guid.NewGuid().ToString(),//包括年度的会计期间 
                                        bFlagOut = false,//公司对帐是否导出过对帐单
                                        bdelete = false,//是否核销 


                                    };
                                    if (shifouShendan == true)//book.UnitID != null && book.UnitID != 0 &&
                                    {
                                        Ap_Detail detail = new Ap_Detail()
                                        {
                                            iPeriod = Convert.ToByte(DateTime.Now.Month),
                                            cVouchType = "49",
                                            cVouchSType = null,
                                            cVouchID = DateTime.Now.ToString("yyMM") + book.VoucherNum.ToString().PadLeft(8, '0'),
                                            dVouchDate = DateTime.Now,
                                            dRegDate = DateTime.Now,
                                            cDwCode = cCusVen,
                                            iBVid = 0,
                                            cCode = "100202",
                                            isignseq = Convert.ToByte(DateTime.Now.Month),
                                            ino_id = Convert.ToInt16(book.ID),
                                            cDigest = book.Summary,
                                            iPrice = 0,
                                            cexch_name = "人民币",
                                            iExchRate = 1,
                                            iDAmount = 0.00M,
                                            iCAmount = book.Credit,
                                            iDAmount_f = 0.00M,
                                            iCAmount_s = (double)book.Credit,
                                            iDAmount_s = 0,
                                            iCAmount_f = 0,
                                            cSSCode = "02",
                                            cProcStyle = "49",
                                            cCancelNo = "AP49" + DateTime.Now.ToString("yyMM") + book.VoucherNum.ToString().PadLeft(8, '0'),
                                            bPrePay = true,
                                            iFlag = 6,
                                            cCoVouchType = "49",
                                            cCoVouchID = DateTime.Now.ToString("yyMM") + book.VoucherNum.ToString().PadLeft(8, '0'),
                                            cFlag = "AP",
                                            iClosesID = 0,
                                            iCoClosesID = 0,
                                            cGLSign = acc.csign,
                                            iGLno_id = (short)book.CSNCashID,
                                            dPZDate = DateTime.Now,
                                            cOperator = book.Cashier,
                                            cCheckMan = book.Cashier,
                                        };
                                        Ap_Detail details = new Ap_Detail()
                                        {
                                            iPeriod = Convert.ToByte(DateTime.Now.Month),
                                            cVouchType = "49",
                                            cVouchSType = null,
                                            cVouchID = DateTime.Now.ToString("yyMM") + book.VoucherNum.ToString().PadLeft(8, '0'),
                                            dVouchDate = DateTime.Now,
                                            dRegDate = DateTime.Now,
                                            cDwCode = cCusVen,
                                            iBVid = 0,
                                            ino_id = Convert.ToInt16(book.ID),
                                            cCode = "220201",
                                            isignseq = Convert.ToByte(DateTime.Now.Month),
                                            cDigest = book.Summary,
                                            iPrice = 0,
                                            cexch_name = "人民币",
                                            iExchRate = 1,
                                            iDAmount = book.Credit,
                                            iCAmount = 0.00M,
                                            iDAmount_f = book.Credit,
                                            iCAmount_s = 0.00,
                                            iDAmount_s = 0,
                                            iCAmount_f = 0,
                                            cSSCode = "02",
                                            cProcStyle = "49",
                                            cCancelNo = "AP49" + DateTime.Now.ToString("yyMM") + book.VoucherNum.ToString().PadLeft(8, '0'),
                                            bPrePay = true,
                                            iFlag = 6,
                                            cCoVouchType = "49",
                                            cCoVouchID = DateTime.Now.ToString("yyMM") + book.VoucherNum.ToString().PadLeft(8, '0'),
                                            cFlag = "AP",
                                            iClosesID = 0,
                                            iCoClosesID = 0,
                                            cGLSign = acc.csign,
                                            iGLno_id = (short)book.CSNCashID,
                                            dPZDate = DateTime.Now,
                                            cOperator = book.Cashier,
                                            cCheckMan = book.Cashier,
                                        };
                                        db.Ap_Detail.Add(detail);
                                        db.Ap_Detail.Add(details);
                                        //修改生单
                                        var col = (from c in db.Ap_CloseBills
                                                   join cp in db.CN_PayedRecord on c.iID equals cp.iMainID
                                                   where cp.iAcctBookID == book.ID
                                                   select c).First();
                                        col.cKm = cCusVen;
                                        db.SaveChanges();
                                    }
                                    db.GL_accvouch.Add(accs);
                                    Boolean isAddToCash = true;
                                    foreach (KeyValuePair<string, Decimal> cashMc in cashList)
                                    {//流量添加
                                        if (!isAddToCash)
                                        {
                                            break;
                                        }
                                        if (Convert.ToDecimal(cashMc.Value) >= Convert.ToDecimal(piaoju.yinhuan))
                                        {//需要付款的大于预支的金额，需要填写进去
                                            GL_CashTable cash = new GL_CashTable()
                                            {
                                                iPeriod = Convert.ToByte(DateTime.Now.Month),
                                                iSignSeq = 1,
                                                iNo_id = Convert.ToInt16(book.ID),
                                                inid = Convert.ToInt16(inid),
                                                cCashItem = cashMc.Key.ToString(),
                                                md = 0.00M,//收入金额时候才用，现在只做支出
                                                mc = Convert.ToDecimal(piaoju.yinhuan),
                                                //  ccode = cashMc.Key,
                                                ccode = acctInfo.SubjectCode,
                                                md_f = 0.00M,
                                                mc_f = 0.00M,
                                                nd_s = 0,
                                                nc_s = 0,
                                                dbill_date = DateTime.Now,
                                                csign = accs.csign,
                                                iyear = Convert.ToInt16(DateTime.Now.Year),
                                                iYPeriod = Convert.ToInt32(DateTime.Now.ToString("yyyyMM")),
                                                RowGuid = TimeHelp.ConvertDateTimeToInt(DateTime.Now) + "00000000",
                                            };
                                            db.GL_CashTable.Add(cash);
                                            isAddToCash = false;//后面就不让填了；
                                            break;
                                        }
                                        else
                                        {
                                            string haveOne = "";//报错能够一次就完成代替的
                                            foreach (KeyValuePair<string, Decimal> cashMcss in cashList)
                                            {
                                                //查看有没有可以一个类型就能代替的
                                                if (Convert.ToDecimal(cashMcss.Value) >= Convert.ToDecimal(piaoju.yinhuan))
                                                {
                                                    haveOne = cashMc.Key.ToString();
                                                }
                                            }
                                            if (string.IsNullOrEmpty(haveOne))
                                            {
                                                GL_CashTable cash = new GL_CashTable()
                                                {
                                                    iPeriod = Convert.ToByte(DateTime.Now.Month),
                                                    iSignSeq = 1,
                                                    iNo_id = Convert.ToInt16(book.ID),
                                                    inid = Convert.ToInt16(inid + 1),
                                                    cCashItem = cashMc.Key.ToString(),
                                                    md = 0.00M,//收入金额时候才用，现在只做支出
                                                    mc = Convert.ToDecimal(cashMc.Value),
                                                    //  ccode = cashMc.Key,
                                                    ccode = acctInfo.SubjectCode,
                                                    md_f = 0.00M,
                                                    mc_f = 0.00M,
                                                    nd_s = 0,
                                                    nc_s = 0,
                                                    dbill_date = DateTime.Now,
                                                    csign = accs.csign,
                                                    iyear = Convert.ToInt16(DateTime.Now.Year),
                                                    iYPeriod = Convert.ToInt32(DateTime.Now.Year + "" + (DateTime.Now.Month)),
                                                    RowGuid = TimeHelp.ConvertDateTimeToInt(DateTime.Now) + "00000000",
                                                };
                                                db.GL_CashTable.Add(cash);
                                                piaoju.yinhuan = (Convert.ToDecimal(piaoju.yinhuan) - Convert.ToDecimal(cashMc.Value)).ToString();//剩余应还的
                                            }
                                            else
                                            {//需要付款的大于预支的金额，需要填写进去
                                                GL_CashTable cash = new GL_CashTable()
                                                {
                                                    iPeriod = Convert.ToByte(DateTime.Now.Month),
                                                    iSignSeq = 1,
                                                    iNo_id = Convert.ToInt16(book.ID),
                                                    inid = Convert.ToInt16(inid + 1),
                                                    cCashItem = haveOne,
                                                    md = 0.00M,//收入金额时候才用，现在只做支出
                                                    mc = Convert.ToDecimal(piaoju.yinhuan),
                                                    //  ccode = cashMc.Key,
                                                    ccode = acctInfo.SubjectCode,
                                                    md_f = 0.00M,
                                                    mc_f = 0.00M,
                                                    nd_s = 0,
                                                    nc_s = 0,
                                                    dbill_date = DateTime.Now,
                                                    csign = accs.csign,
                                                    iyear = Convert.ToInt16(DateTime.Now.Year),
                                                    iYPeriod = Convert.ToInt32(DateTime.Now.Year + "" + (DateTime.Now.Month)),
                                                    RowGuid = TimeHelp.ConvertDateTimeToInt(DateTime.Now) + "00000000",
                                                };
                                                db.GL_CashTable.Add(cash);
                                                isAddToCash = false;//后面就不让填了；
                                                break;
                                            }
                                        }
                                    }
                                    db.SaveChanges();
                                    CN_VARelate v = new CN_VARelate()
                                    {
                                        AcctID = book.AcctID,
                                        VouchID = acc.i_id,
                                        IsPrint = 0
                                    };//凭证开票对应关系
                                    db.CN_VARelate.Add(v);
                                    db.SaveChanges();
                                    var CN_CashSignRelate = (from c in db.CN_CashSignRelate orderby c.ID descending select c).FirstOrDefault();
                                    string sql = string.Format(@"insert into CN_CashSignRelate(AcctBookID,JobID,VouchID,AccountID) values({0},{1},{2},{3})", book.ID, CN_CashSignRelate == null ? 1 : CN_CashSignRelate.ID + 1, acc.i_id, book.AcctID);
                                    int dt = SqlHelper.ExecuteNonQuery(config, sql);
                                    if (dt < 1)
                                    {//这张表未改变
                                        throw new Exception("CN_CashSignRelate未成功添加数据，终止操作");
                                    }
                                    book.VoucherStr = accs.csign + "  " + book.CSNCashID;
                                    book.VoucherNum = book.CSNCashID;
                                    book.IsRegGLVouch = 1;//制单成功
                                    book.VouchOutSignNum = acc.coutno_id;
                                    db.SaveChanges();
                                    //科目备查表添加数据
                                    GL_CodeRemark coderremark = new GL_CodeRemark();
                                    coderremark.iPeriod = Convert.ToByte(DateTime.Now.Month);
                                    coderremark.iyear = Convert.ToInt16(DateTime.Now.Year);
                                    coderremark.iYPeriod = Convert.ToInt32(DateTime.Now.ToString("yyyyMM"));
                                    coderremark.inid = 1;
                                    coderremark.csign = accs.csign;
                                    coderremark.iNo_id = Convert.ToInt16(book.CSNCashID);
                                    GL_CodeRemark coderremark1 = new GL_CodeRemark();
                                    coderremark1.iPeriod = Convert.ToByte(DateTime.Now.Month);
                                    coderremark1.iyear = Convert.ToInt16(DateTime.Now.Year);
                                    coderremark1.iYPeriod = Convert.ToInt32(DateTime.Now.ToString("yyyyMM"));
                                    coderremark1.inid = 2;
                                    coderremark1.csign = accs.csign;
                                    coderremark1.iNo_id = Convert.ToInt16(book.CSNCashID);
                                    db.GL_CodeRemark.Add(coderremark);
                                    db.GL_CodeRemark.Add(coderremark1);
                                    db.SaveChanges();
                                    var request = (from re in ent.RecordTable
                                                   where re.Bid == book.ID
                                                   select re).FirstOrDefault();
                                    request.ip2 = GetIP.getIP().userName;
                                    request.updateTime2 = DateTime.Now;
                                    request.IsIntoAccvouch = 1;
                                    ent.SaveChanges();
                                }
                                trans.Commit();
                                tran.Commit();
                                return "制单成功";
                            }
                            catch (Exception ex)
                            {
                                tran.Rollback();
                                LogHelper.WriteLog(GetIP.getIP() + "------------------------" + ex.Message);
                                return "制单失败";
                            }
                        }
                    }
                }
            }
        }
        #endregion
        #region 签字（本来是和制单一起的）
        /// <summary>
        /// 签字
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public string addToCcashier(ResultListModel model)
        {
            using (var ent = new OAtoU8DATAEntities())
            {//读取到自己设计表的数据
                var list = (from r in ent.RecordTable
                            where r.Pid.Contains(model.Id)
                            select r).ToList();

                using (var db = new UFDATA_048_2017Entities())
                {
                    using (var tran = db.Database.BeginTransaction())

                    {
                        try
                        {
                            var RecordTables = (from r in ent.RecordTable
                                                where r.Pid.Contains(model.Id) && r.IsIntoAccvouch != null
                                                select r).FirstOrDefault();
                            if (RecordTables == null)
                            {
                                return "请先制单";
                            }
                            foreach (var r in list)
                            {
                                var cash = (from c in db.CN_CashSignRelate where c.AcctBookID == r.Bid select c).FirstOrDefault();
                                if (cash == null)
                                {
                                    return "请先制单";
                                }
                                var acc = (from a in db.GL_accvouch
                                           where a.i_id == cash.VouchID
                                           select a
                                       ).FirstOrDefault();
                                acc.ccashier = GetIP.getIP().userName;//签字步骤放到签字去 book.Cashier,//出纳签字人 
                                db.SaveChanges();
                            }
                            tran.Commit();
                            return "签字成功";
                        }
                        catch (Exception ex)
                        {
                            tran.Rollback();
                            LogHelper.WriteLog(GetIP.getIP() + "------------------------" + ex.Message);
                            return "签字失败";
                        }
                    }
                }
            }
        }
        #endregion
    }
}
