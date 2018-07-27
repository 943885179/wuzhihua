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
    public class U8DAL
    {
        private static string config = ConfigurationManager.AppSettings["U8slqserver"].ToString();
        private static FromU8 u8 = new FromU8();
        #region 生成日记账
        /// <summary>
        /// 单据只做付款操作，收款的后续更新
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public object addToAcctBook(ResultListModel model,userInfo userInfo)
        {
            if (model.content == null)
            {
                return new { errorMsg = "请选择账户" };
            }
            using (var ent = new OAtoU8DATAEntities())
            {
                var list = (from r in ent.RecordTable
                            where r.Pid.Contains(model.Id)
                            select r).FirstOrDefault();
                if (list != null)
                {
                    return new { errorMsg = "数据已经提交到U8，禁止重复提交" };
                }
            }
            //收款单位是供应商还是客户，用收款单位来确定
            var kehu = u8.geCustomertUnit(model.shoukuandanwei);//客户
            var gonyingshang = u8.geVendortUnit(model.shoukuandanwei);//供应商
            var UnitID = 0; //客户/供应商id
            var UnitType = 2;//客户为1，供应商为2
            CN_AcctBook book = new CN_AcctBook();
            if (kehu != null)
            {
                UnitID = kehu.ID;
                UnitType = 1;
                book.CustomerID = UnitID;
            }
            else
            {
                if (gonyingshang != null)
                {
                    UnitID = gonyingshang.ID;
                    UnitType = 2;
                    book.VendorID = UnitID;
                }
            }
            var user = u8.getPerson(model.shoukuandanwei);//个人支付
            book.UnitID = UnitID;
            book.UnitType = UnitType;//客户为1，供应商为2
            book.AcctID = model.content.ID;//getAccInfo传过来的Id
            book.AcctType = 1;//日记账类型 
            book.AcctDate = DateTime.Now;//添加时间
            book.Period = DateTime.Now.Month;//期数
            book.ExchangeRate = 1;//汇率 
            book.SettleTypeID = 2;//转账或者现金（统一设置为转账）
            book.Cashier = userInfo.name;//日记账人员
            book.ProjectClass = 25;//CN_LevelClass
            book.lYear = DateTime.Now.Year;//年份设为当前年
            book.lParentID = model.content.ID;//出纳选择银行
                                              //   CN_AcctInfo cont = getAccInfo(model.content,2);
            book.CSNCashSign = u8.getCashSerialNumber("付");
            //暂时只做支付的，收款的不做，付款的编号确定，如果需要更新，请查询getCashSerialNumber（context）
            book.DeptID = u8.getDepatement(model.faqibumen);
            if (book.DeptID == 0) {//报销部门在U8上找不到
                return new { errorMsg = model.faqibumen + "在U8上找不到" };
            }
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
                            if (piaoju.Yinhan.jiefan == 0) {//金额为0就不添加了
                                continue;
                            }
                            //读取票据明细，如果存在受控科目等需要先判断，不合法无法提交
                            //录入日记账时候添加科目控制，在当科目符合的时候才能插入，不能的话说明财务审核不认真科目没有核实正确
                            foreach (Detail list in piaoju.Detail)
                            {
                                var kemu = list.kemu.Substring(0, list.kemu.Length - 2);//获取科目
                                var thisCode = u8.getCodeInU8Byccode(kemu);
                                if (thisCode == null || piaoju.Yinhan.jiefan==0)
                                {//没找到这个科目
                                    continue;
                                }
                                if (thisCode.bcus && kehu == null)
                                {//客户往来核算 
                                    return new { errorMsg = thisCode.ccode + "是客户受控科目，但是在客户列表中无法查询到" + model.shoukuandanwei + "这个客户" };
                                }
                                if (thisCode.bsup && gonyingshang == null)
                                {//供应商往来核算项目 
                                    return new { errorMsg = thisCode.ccode + "是供应商受控科目，但是在供应商列表中无法查询到" + model.shoukuandanwei + "这个供应商" };
                                }
                                if (thisCode.bperson && user == null)
                                {//个人往来核算项目 
                                    return new { errorMsg = thisCode.ccode + "是个人往来受控科目，但是在供应商列表中无法查询到" + model.shoukuandanwei + "" };
                                }
                                if (thisCode.bdept && string.IsNullOrEmpty(list.shouyibumen))
                                {//部门往来核算项目 
                                    return new { errorMsg = thisCode.ccode + "部门受控,请选择部门" };
                                }
                            }
                            book.Credit = piaoju.Yinhan.jiefan;//需要银行支付的支付金额
                            book.FCredit = piaoju.Yinhan.jiefan;//需要银行支付的支付金额
                            book.Summary = piaoju.Yinhan.miaoshu;//描述
                            //获取最后一个录入的编号
                            var last = (from b in db.CN_AcctBook
                                        where b.AcctID== model.content.ID
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
                            var chunabianhao = book.CSNCashSign + "-" + book.CSNCashID.ToString().PadLeft(5, '0');
                            model.piaoju[i].chunabianhao = chunabianhao;
                            using (var ent = new OAtoU8DATAEntities())
                            {//插入到自己的数据库表进行记录
                                RecordTable record = new RecordTable();
                                record.IsIntoBook = 1;
                                record.piaojuId = i;
                                record.Pid = model.Id;
                                record.Bid = book.ID;
                                record.ip = userInfo.name;
                                record.updateTime = DateTime.Now;
                                record.contents = model.content.ID.ToString();
                                record.chunabianhao = chunabianhao;
                                record.piaojuId = piaoju.tabClass;
                                ent.RecordTable.Add(record);
                                ent.SaveChanges();
                            }
                        }
                        tran.Commit();
                        return new { model = model, sucess = "成功生成日记账" };
                    }
                    catch (Exception ex)
                    {
                        LogHelper.WriteLog(GetIP.getIP() + "------------------------" + ex.Message);
                        tran.Rollback();
                        return new { errorMsg = "数据更新错误！" };
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
        public object addToCloseBill(ResultListModel model, userInfo userInfo)
        {
            if (model.content == null)
            {
                return new { errorMsg = "请选择账户" };
            }
            using (var ent = new OAtoU8DATAEntities())
            {
                var chengchengFUkuandan = (from r in ent.RecordTable
                                           where r.Pid.Contains(model.Id)
                                           select r).FirstOrDefault();
                if (chengchengFUkuandan == null)
                {
                    return new { errorMsg = "还未生成付款单，无法进行生单操作" };
                }
                var RecordTable = (from r in ent.RecordTable
                                   where r.Pid.Contains(model.Id) && r.IsIntoCloseBill != null
                                   select r).FirstOrDefault();
                if (RecordTable != null)
                {
                    return new { errorMsg = "已经生单到U8，禁止重复提交" };
                }
            }
            using (var db = new UFDATA_048_2017Entities())
            {
                using (var tran = db.Database.BeginTransaction())
                {
                    try
                    {
                        for (int i = 0; i < model.piaoju.Count; i++)
                        {
                            var piaoju = model.piaoju[i];
                            if (piaoju.Yinhan.jiefan == 0) {
                                continue;
                            }
                            RecordTable oatab = new RecordTable();
                            using (var ent = new OAtoU8DATAEntities())
                            {//读取到自己设计表的数据
                                oatab = (from r in ent.RecordTable
                                         where r.Pid.Contains(model.Id) && r.piaojuId == piaoju.tabClass
                                         select r).FirstOrDefault();
                            }
                            if (oatab == null)
                            {
                                return new { errorMsg = "未查询到单据，无法生单" };
                            }
                            var book = (from b in db.CN_AcctBook
                                        where b.ID == oatab.Bid
                                        select b
                                       ).First();
                            if (model.content.ID != book.AcctID)
                            {
                                var acct = db.CN_AcctInfo.Where(o => o.ID == book.AcctID).FirstOrDefault();
                                return new { errorMsg = "生单账户和日记账账户不一致，日记账账户为" + acct.AcctName };
                            }
                            if ((book.CustomerID == null || book.CustomerID == 0) && (book.VendorID == null || book.VendorID == 0))
                            {
                                return new { errorMsg = "无法搜索到客户或者供应商，无法生单" };
                            }
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
                            clo.cCusVen = cCusVen;//客户或供应商编码
                            clo.iAmt = Convert.ToDecimal(book.Credit);
                            clo.iAmt_f = Convert.ToDecimal(book.Credit);
                            clo.iRAmt = Convert.ToDecimal(book.Credit);
                            clo.iRAmt_f = Convert.ToDecimal(book.Credit);
                            clo.cKm = null;
                            clo.cXmClass = null;
                            clo.cDepCode = u8.getDepatements(model.faqibumen).cDepCode;
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
                            var cvouchId = DateTime.Now.ToString("yyMM") + "00000001";
                            var oldLasts = (from c in db.Ap_CloseBill
                                            orderby c.cVouchID descending
                                            select c).FirstOrDefault();
                            if (oldLasts != null)
                            {
                                var date = oldLasts.cVouchID.Substring(0, 4);
                                if (date.Equals(DateTime.Now.ToString("yyMM")))
                                {
                                    closeBill.cVouchID = (Convert.ToInt64(oldLasts.cVouchID) + 1).ToString();
                                }
                                else
                                {
                                    closeBill.cVouchID = cvouchId;
                                }
                            }
                            else
                            {
                                closeBill.cVouchID = cvouchId;
                            }
                            closeBill.dVouchDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));
                            closeBill.iPeriod = Convert.ToByte(DateTime.Now.Month);
                            closeBill.cDwCode = cCusVen;//"010001"
                            closeBill.cDeptCode = u8.getDepatements(model.faqibumen).cDepCode;//获取部门 //外键Department表的cDepCode
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
                            closeBill.cOperator = userInfo.name;//录入人 
                            closeBill.bStartFlag = false;//期初标志 
                            closeBill.cCode = model.content.SubjectCode;//结算科目编码 
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
                            closeBill.cmodifier = userInfo.name;
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
                                request.ip2 = userInfo.name;
                                request.updateTime2 = DateTime.Now;
                                request.IsIntoCloseBill = 1;
                                request.danjubianhao = closeBill.cVouchID;
                                ent.SaveChanges();
                            }
                            model.piaoju[i].danjubianhao = closeBill.cVouchID;

                        }
                        tran.Commit();
                        return new { model = model, sucess = "成功生单" };
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        LogHelper.WriteLog(GetIP.getIP() + "------------------------" + ex.Message);
                        return new { errorMsg = "系统错误，生单失败" };
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
        public object addToCashSignRelate(ResultListModel model, userInfo userInfo)
        {
            if (model.content == null)
            {
                return new { errorMsg = "请选择账户" };
            }
            Boolean shifouShendan = false;
            using (var ent = new OAtoU8DATAEntities())
            {
                var RecordTables = (from r in ent.RecordTable
                                    where r.Pid.Contains(model.Id) && r.IsIntoAccvouch != null
                                    select r).FirstOrDefault();
                if (RecordTables != null)
                {
                    //存在数据，返回值
                    return new { errorMsg = "已经制单到U8，禁止重复提交" };
                }
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
                                FromOA oa = new FromOA();
                                var guanlingYuzhi = oa.getSunByattachment(model);//获取关联的预支单
                                for (int i=0;i < model.piaoju.Count;i++)
                                {//读取票据
                                     var piaoju = model.piaoju[i];
                                    if (piaoju.Yinhan.jiefan == 0)
                                    {
                                        continue;
                                    }
                                    var RecordTable = (from r in ent.RecordTable
                                                       where r.Pid.Contains(model.Id) && r.piaojuId == piaoju.tabClass
                                                       select r).FirstOrDefault();
                                    if (RecordTable == null)
                                    {
                                        return new { errorMsg = "单据错误，未找到" + piaoju.tabClass+"请先日记账" };
                                    }
                                    var book = (from b in db.CN_AcctBook where b.ID == RecordTable.Bid select b).First();
                                    if (model.content.ID != book.AcctID)
                                    {
                                        var acct = db.CN_AcctInfo.Where(o => o.ID == book.AcctID).FirstOrDefault();
                                        return new { errorMsg = "生成凭证账户和日记账账户不一致，日记账账户为" + acct.AcctName };
                                    }
                                    //收款单位是供应商还是客户，用收款单位来确定
                                    var kehu = u8.geCustomertUnit(model.shoukuandanwei);//客户
                                    var gonyingshang = u8.geVendortUnit(model.shoukuandanwei);//供应商
                                    var user = u8.getPerson(model.shoukuandanwei);//个人支付
                                    short inid = 0;
                                    var dsign = (from d in db.CN_CashSerialNumber where d.SNWord.Contains(book.CSNCashSign) select d).FirstOrDefault();//这里保存了记账凭证号
                                    var kehus = (from cu in db.Customer
                                                 join c in db.CN_UnitID on cu.cCusCode equals c.LoadCusID
                                                 where c.ID == book.UnitID
                                                 select cu).FirstOrDefault();//获取客户类型的收益部门
                                    var gonyingshangs = (from ve in db.Vendor
                                                         join c in db.CN_UnitID on ve.cVenCode equals c.LoadVenID
                                                         where c.ID == book.UnitID
                                                         select ve).FirstOrDefault();
                                    var time = TimeHelp.ConvertDateTimeToInt(DateTime.Now);
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
                                    }
                                    var clobil = (from cb in db.Ap_CloseBill
                                                  join c in db.Ap_CloseBills on cb.iID equals c.iID
                                                  join cp in db.CN_PayedRecord on c.iID equals cp.iMainID
                                                  where cp.iAcctBookID == book.ID
                                                  select cb).FirstOrDefault();
                                    string ccodeList = "";
                                    #region 科目明细录入
                                    foreach (Detail list in piaoju.Detail)
                                    {
                                        var detailjine = Convert.ToDecimal(list.jine);
                                        if (!string.IsNullOrEmpty(list.miaoshu)  && !string.IsNullOrEmpty(list.jine) && detailjine!=0)
                                        {//获取流量集合

                                            if (string.IsNullOrEmpty(list.kemu))
                                            {
                                                return "请确认每一条明细都选择了对应科目";
                                            }
                                            var oldKemu = list.kemu;
                                            var trueKemu = list.kemu.Equals("22210101")? list.kemu: list.kemu.Substring(0, list.kemu.Length - 2);

                                            var thisCode = u8.getCodeInU8Byccode(trueKemu);
                                            if (thisCode == null)
                                            {//没找到这个科目
                                                continue;
                                            }
                                            if (thisCode.bcus && (book.CustomerID == null || book.CustomerID == 0))
                                            {//客户往来核算 
                                                return new { errorMsg = thisCode.ccode + "是客户受控科目，但是在客户列表中无法查询到" + model.shoukuandanwei + "这个客户" };
                                            }
                                            if (thisCode.bsup && (book.VendorID == null || book.VendorID == 0))
                                            {//供应商往来核算项目 
                                                return new { errorMsg = thisCode.ccode + "是供应商受控科目，但是在供应商列表中无法查询到" + model.shoukuandanwei + "这个供应商" };
                                            }
                                            if (thisCode.bperson && user == null)
                                            {//个人往来核算项目 
                                                return new { errorMsg = thisCode.ccode + "是个人往来受控科目，但是在供应商列表中无法查询到" + model.shoukuandanwei + "" };
                                            }
                                            if (thisCode.bdept && string.IsNullOrEmpty(list.shouyibumen))
                                            {//部门往来核算项目 
                                                return new { errorMsg = thisCode.ccode + "部门受控,请选择部门" };
                                            }
                                            if (thisCode.ccode == "220201" && RecordTable.danjubianhao == null) {
                                                return new { errorMsg = thisCode.ccode + "科目为应付系统科目，请先生成收付款单" };
                                            }
                                            if (dsign == null)
                                            {
                                                return new { errorMsg = "无记账凭证" };
                                            }
                                            inid++;

                                            ccodeList = trueKemu + ",";
                                            GL_accvouch acc = new GL_accvouch()
                                            {
                                                iperiod = Convert.ToByte(DateTime.Now.Month),
                                                csign = dsign.U8VouchSign,//凭证类别字
                                                isignseq = 1,//凭证类别排序号 
                                                ino_id = Convert.ToInt16(book.ID),//凭证编号 
                                                inid = inid,//在12循环行号 
                                                dbill_date = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd")),//制单日期
                                                idoc = shifouShendan == false ? (short)0 : (short)1,//附单据数 (不生单为0生单为1)
                                                cbill = userInfo.name,//制单人
                                                ccheck = null,
                                                cbook = null,
                                                ibook = 0,
                                                ccashier = shifouShendan == false ? book.Cashier : null,//出纳签字人(不生单的签字了，生单的没有)
                                                iflag = null,
                                                ctext1 = null,
                                                ctext2 = null,
                                                cdigest = list.miaoshu,//摘要 
                                                ccode = trueKemu,//科目编码 ，付款的用申请表里的付款科目来做查询(付款为你选择的科目编号)
                                                cexch_name = null,
                                                md = list.kemu.Equals("22210101") ? Convert.ToDecimal(list.shuie): Convert.ToDecimal(list.jine),//借方金额 
                                                mc = 0M, //  mc = i == 1 ? Convert.ToDecimal(book.Credit) : 0.00M,//和上面一个有值它就为0.00M 贷方金额 
                                                mc_f = 0.00M,//外币贷方金额  
                                                md_f = 0.00M,//外币借方金额 
                                                nfrat = 0,//汇率 
                                                nc_s = 0,//数量贷方 
                                                nd_s = 0,//数量借方 
                                                csettle = null,// (from s in db.SettleStyle where s.cSSName.Equals("转账") select s).First().cSSCode,//结算方式编码 
                                                cn_id = null,
                                                dt_date = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd")),
                                                cdept_id = user == null ? list.shouyibumen : user.cDept_num, //getDepatements(r.shouyibumen).cDepCode,
                                                cperson_id = user == null ? null : user.cPsn_Num,
                                                ccus_id = kehus == null ? null : kehus.cCusCode,
                                                csup_id = gonyingshangs == null ? null : gonyingshangs.cVenCode,
                                                citem_id = null,
                                                citem_class = null,
                                                cname = shifouShendan == false ? null : "-",
                                                ccode_equal = model.content.SubjectCode,//科目编码 ，付款的用申请表里的付款科目来做查询(付款为你选择的科目编号)
                                                iflagbank = null,
                                                iflagPerson = null,
                                                coutaccset = "046",//上海悦目046，广东悦肌048
                                                ioutyear = (short)DateTime.Now.Year,//外部凭证会计年度 
                                                coutsysname = book.UnitID == 0 ? "SC" : "AP",//外部凭证系统名称
                                                coutsysver = null,
                                                doutbilldate = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd")),//外部凭证制单日期
                                                ioutperiod = Convert.ToByte(DateTime.Now.Month),//外部凭证会计期间 
                                                coutsign = RecordTable.danjubianhao == null ? "出纳管理" : "RP",//外部凭证账套号 RP AP
                                                coutno_id = RecordTable.danjubianhao == null ? "SC" + time : coutno_id,//外部凭证业务号 
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

                                                ccodeexch_equal = model.content.SubjectCode,//对方科目编码 ，付款的用申请表里的付款科目来做查询(付款为你选择的科目编号) 
                                                tvouchtime = DateTime.Now,//凭证保存时间 
                                                iYPeriod = Convert.ToInt32(DateTime.Now.Year + "" + (DateTime.Now.Month >= 10 ? DateTime.Now.Month.ToString() : "0" + DateTime.Now.Month)),
                                                RowGuid = Guid.NewGuid().ToString(),//包括年度的会计期间 //行标识.规律不知道
                                                bFlagOut = false,//公司对帐是否导出过对帐单
                                                bdelete = false,//是否核销 
                                            };
                                            db.GL_accvouch.Add(acc);
                                            db.SaveChanges();
                                        }
                                        else {
                                            return new { errorMsg = "请填写所有摘要信息" };
                                        }
                                    }
                                    #endregion

                                    book.VoucherNum = book.CSNCashID;

                                    db.SaveChanges();
                                    #region 添加个人记录表
                                    var request = (from re in ent.RecordTable
                                                   where re.Bid == book.ID
                                                   select re).FirstOrDefault();
                                    request.ip2 = userInfo.name;
                                    request.updateTime2 = DateTime.Now;
                                    request.IsIntoAccvouch = 1;
                                    request.pingzhenhao = dsign.U8VouchSign + "  " + book.VoucherNum;
                                    request.userName = model.faqiren;
                                    #endregion
                                    #region 预支冲账
                                    if (!model.type.Equals("上海悦目-预支单"))
                                    {
                                        foreach (Detail list in piaoju.Yuzhi)
                                        {
                                            if (!string.IsNullOrEmpty(list.miaoshu) && list.jiefan!=0)
                                            {//获取流量集合

                                                if (string.IsNullOrEmpty(list.kemu))
                                                {
                                                    return "请确认每一条明细都选择了对应科目";
                                                }
                                                var oldKemu = list.kemu;
                                                var trueKemu = list.kemu.Equals("22210101") ? list.kemu : list.kemu.Substring(0, list.kemu.Length - 2);
                                                var liuliang = oldKemu.Replace(trueKemu,"");
                                                var thisCode = u8.getCodeInU8Byccode(trueKemu);
                                                if (thisCode == null)
                                                {//没找到这个科目
                                                    continue;
                                                }
                                                if (thisCode.bcus && (book.CustomerID == null || book.CustomerID == 0))
                                                {//客户往来核算 
                                                    return new { errorMsg = thisCode.ccode + "是客户受控科目，但是在客户列表中无法查询到" + model.shoukuandanwei + "这个客户" };
                                                }
                                                if (thisCode.bsup && (book.VendorID == null || book.VendorID == 0))
                                                {//供应商往来核算项目 
                                                    return new { errorMsg = thisCode.ccode + "是供应商受控科目，但是在供应商列表中无法查询到" + model.shoukuandanwei + "这个供应商" };
                                                }
                                                if (thisCode.bperson && user == null)
                                                {//个人往来核算项目 
                                                    return new { errorMsg = thisCode.ccode + "是个人往来受控科目，但是在供应商列表中无法查询到" + model.shoukuandanwei + "" };
                                                }
                                                if (thisCode.bdept && string.IsNullOrEmpty(list.shouyibumen))
                                                {//部门往来核算项目 
                                                    return new { errorMsg = thisCode.ccode + "部门受控,请选择部门" };
                                                }
                                                if (dsign == null)
                                                {
                                                    return new { errorMsg = "无记账凭证" };
                                                }
                                                inid++;

                                                ccodeList = trueKemu + ",";
                                                GL_accvouch acc = new GL_accvouch()
                                                {
                                                    iperiod = Convert.ToByte(DateTime.Now.Month),
                                                    csign = dsign.U8VouchSign,//凭证类别字
                                                    isignseq = 1,//凭证类别排序号 
                                                    ino_id = Convert.ToInt16(book.ID),//凭证编号 
                                                    inid = inid,//在12循环行号 
                                                    dbill_date = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd")),//制单日期
                                                    idoc = shifouShendan == false ? (short)0 : (short)1,//附单据数 (不生单为0生单为1)
                                                    cbill = userInfo.name,//制单人
                                                    ccheck = null,
                                                    cbook = null,
                                                    ibook = 0,
                                                    ccashier = shifouShendan == false ? book.Cashier : null,//出纳签字人(不生单的签字了，生单的没有)
                                                    iflag = null,
                                                    ctext1 = null,
                                                    ctext2 = null,
                                                    cdigest = list.miaoshu,//摘要 
                                                    ccode = trueKemu,//科目编码 ，付款的用申请表里的付款科目来做查询(付款为你选择的科目编号)
                                                    cexch_name = null,
                                                    md = 0.00M,//借方金额 
                                                    mc = (decimal)list.jiefan, //  mc = i == 1 ? Convert.ToDecimal(book.Credit) : 0.00M,//和上面一个有值它就为0.00M 贷方金额 
                                                    mc_f = 0.00M,//外币贷方金额  
                                                    md_f = 0.00M,//外币借方金额 
                                                    nfrat = 0,//汇率 
                                                    nc_s = 0,//数量贷方 
                                                    nd_s = 0,//数量借方 
                                                    csettle = null,// (from s in db.SettleStyle where s.cSSName.Equals("转账") select s).First().cSSCode,//结算方式编码 
                                                    cn_id = null,
                                                    dt_date = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd")),
                                                    cdept_id = user == null ? list.shouyibumen : user.cDept_num, //getDepatements(r.shouyibumen).cDepCode,
                                                    cperson_id = user == null ? null : user.cPsn_Num,
                                                    ccus_id = kehus == null ? null : kehus.cCusCode,
                                                    csup_id = gonyingshangs == null ? null : gonyingshangs.cVenCode,
                                                    citem_id = null,
                                                    citem_class = null,
                                                    cname = shifouShendan == false ? null : "-",
                                                    ccode_equal = model.content.SubjectCode,//科目编码 ，付款的用申请表里的付款科目来做查询(付款为你选择的科目编号)
                                                    iflagbank = null,
                                                    iflagPerson = null,
                                                    coutaccset = "046",//上海悦目046，广东悦肌048
                                                    ioutyear = (short)DateTime.Now.Year,//外部凭证会计年度 
                                                    coutsysname = book.UnitID == 0 ? "SC" : "AP",//外部凭证系统名称
                                                    coutsysver = null,
                                                    doutbilldate = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd")),//外部凭证制单日期
                                                    ioutperiod = Convert.ToByte(DateTime.Now.Month),//外部凭证会计期间 
                                                    coutsign = RecordTable.danjubianhao == null ? "出纳管理" : "RP",//外部凭证账套号 RP AP
                                                    coutno_id = RecordTable.danjubianhao == null ? "SC" + time : coutno_id,//外部凭证业务号 
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

                                                    ccodeexch_equal = model.content.SubjectCode,//对方科目编码 ，付款的用申请表里的付款科目来做查询(付款为你选择的科目编号) 
                                                    tvouchtime = DateTime.Now,//凭证保存时间 
                                                    iYPeriod = Convert.ToInt32(DateTime.Now.Year + "" + (DateTime.Now.Month >= 10 ? DateTime.Now.Month.ToString() : "0" + DateTime.Now.Month)),
                                                    RowGuid = Guid.NewGuid().ToString(),//包括年度的会计期间 //行标识.规律不知道
                                                    bFlagOut = false,//公司对帐是否导出过对帐单
                                                    bdelete = false,//是否核销 
                                                };
                                                db.GL_accvouch.Add(acc);
                                                db.SaveChanges();
                                                //冲账  

                                                if (liuliang.Equals("04"))
                                                    {
                                                        foreach (var g in guanlingYuzhi)
                                                        {
                                                            if (list.jiefan <= 0) { break; }
                                                            var g4 = g.record.Where(o => o.l4 > 0).ToList();
                                                            foreach (var s in g4)
                                                            {
                                                                var r = ent.RecordTable.Where(o => o.id == s.id).First();
                                                                if (r.l4 >= list.jiefan)
                                                                {
                                                                    contrast contrast = new contrast();
                                                                    contrast.yuzhiId = r.id;
                                                                    contrast.baoxiaoId = request.id;
                                                                    contrast.l4 = list.jiefan;
                                                                    ent.contrast.Add(contrast);
                                                                    r.l4 = r.l4 - list.jiefan;
                                                                    list.jiefan = 0;
                                                                    break;
                                                                }
                                                                else
                                                                {
                                                                    contrast contrast = new contrast();
                                                                    contrast.yuzhiId = r.id;
                                                                    contrast.baoxiaoId = request.id;
                                                                    contrast.l4 = r.l4;
                                                                    ent.contrast.Add(contrast);
                                                                    r.l4 = 0;
                                                                    list.jiefan = list.jiefan - r.l4;
                                                                }
                                                            }
                                                        }
                                                    }
                                                    if (liuliang.Equals("05"))
                                                    {
                                                        foreach (var g in guanlingYuzhi)
                                                        {
                                                            if (list.jiefan <= 0) { break; }
                                                            var g5 = g.record.Where(o => o.l5 > 0).ToList();
                                                            foreach (var s in g5)
                                                            {
                                                                var r = ent.RecordTable.Where(o => o.id == s.id).First();
                                                                if (r.l5 >= list.jiefan)
                                                                {

                                                                    contrast contrast = new contrast();
                                                                    contrast.yuzhiId = r.id;
                                                                    contrast.baoxiaoId = request.id;
                                                                    contrast.l5 = list.jiefan;
                                                                    ent.contrast.Add(contrast);
                                                                    r.l5 = r.l5 - list.jiefan;
                                                                    list.jiefan = 0;
                                                                    break;
                                                                }
                                                                else
                                                                {

                                                                    contrast contrast = new contrast();
                                                                    contrast.yuzhiId = r.id;
                                                                    contrast.baoxiaoId = request.id;
                                                                    contrast.l5 = r.l5;
                                                                    ent.SaveChanges();
                                                                    r.l5 = 0;

                                                                    list.jiefan = list.jiefan - r.l5;
                                                                }
                                                            }
                                                        }
                                                    }

                                                    if (liuliang.Equals("06"))
                                                    {
                                                        foreach (var g in guanlingYuzhi)
                                                        {
                                                            if (list.jiefan <= 0) { break; }
                                                            var g6 = g.record.Where(o => o.l6 > 0).ToList();
                                                            foreach (var s in g6)
                                                            {
                                                                var r = ent.RecordTable.Where(o => o.id == s.id).First();
                                                                if (r.l6 >= list.jiefan)
                                                                {
                                                                    contrast contrast = new contrast();
                                                                    contrast.yuzhiId = r.id;
                                                                    contrast.baoxiaoId = request.id;
                                                                    contrast.l6 = list.jiefan;
                                                                    ent.contrast.Add(contrast);
                                                                    r.l6 = r.l6 - list.jiefan;
                                                                    list.jiefan = 0;
                                                                    break;
                                                                }
                                                                else
                                                                {
                                                                    contrast contrast = new contrast();
                                                                    contrast.yuzhiId = r.id;
                                                                    contrast.baoxiaoId = request.id;
                                                                    contrast.l6 = r.l6;
                                                                    ent.contrast.Add(contrast);
                                                                    r.l6 = 0;
                                                                    list.jiefan = list.jiefan - r.l6;
                                                                }
                                                            }
                                                        }
                                                    }

                                                    if (liuliang.Equals("07"))
                                                    {
                                                        foreach (var g in guanlingYuzhi)
                                                        {
                                                            if (list.jiefan <= 0) { break; }
                                                            var g7 = g.record.Where(o => o.l7 > 0).ToList();
                                                            foreach (var s in g7)
                                                            {
                                                                var r = ent.RecordTable.Where(o => o.id == s.id).First();
                                                                if (r.l7 >= list.jiefan)
                                                                {
                                                                    contrast contrast = new contrast();
                                                                    contrast.yuzhiId = r.id;
                                                                    contrast.baoxiaoId = request.id;
                                                                    contrast.l7 = list.jiefan;
                                                                    ent.contrast.Add(contrast);
                                                                    r.l7 = r.l7 - list.jiefan;
                                                                    list.jiefan = 0;
                                                                    break;
                                                                }
                                                                else
                                                                {
                                                                    contrast contrast = new contrast();
                                                                    contrast.yuzhiId = r.id;
                                                                    contrast.baoxiaoId = request.id;
                                                                    contrast.l7 = r.l7;
                                                                    ent.contrast.Add(contrast);
                                                                    r.l7 = 0;

                                                                    list.jiefan = list.jiefan - r.l7;
                                                                }
                                                            }
                                                        }
                                                    }

                                                    if (liuliang.Equals("13"))
                                                    {
                                                        foreach (var g in guanlingYuzhi)
                                                        {
                                                            if (list.jiefan <= 0) { break; }
                                                            var g13 = g.record.Where(o => o.l13 > 0).ToList();
                                                            foreach (var s in g13)
                                                            {
                                                                var r = ent.RecordTable.Where(o => o.id == s.id).First();
                                                                if (r.l13 >= list.jiefan)
                                                                {
                                                                    contrast contrast = new contrast();
                                                                    contrast.yuzhiId = r.id;
                                                                    contrast.baoxiaoId = request.id;
                                                                    contrast.l13 = list.jiefan;
                                                                    ent.contrast.Add(contrast);
                                                                    r.l13 = r.l13 - list.jiefan;
                                                                    list.jiefan = 0;
                                                                    break;
                                                                }
                                                                else
                                                                {
                                                                    contrast contrast = new contrast();
                                                                    contrast.yuzhiId = r.id;
                                                                    contrast.baoxiaoId = request.id;
                                                                    contrast.l13 = r.l13;
                                                                    ent.contrast.Add(contrast);
                                                                    r.l13 = 0;

                                                                    list.jiefan = list.jiefan - r.l13;
                                                                }
                                                            }
                                                        }
                                                    }
                                                    foreach (var g in guanlingYuzhi)
                                                    {
                                                        if (list.jiefan <= 0) { break; }
                                                        var g13 = g.record
                                                             .Where(o => o.l13 > 0 || o.l7 > 0 || o.l6 > 0 || o.l5 > 0 || o.l4 > 0).ToList();
                                                        foreach (var s in g13)
                                                        {
                                                            var r = ent.RecordTable.Where(o => o.id == s.id).First();
                                                            if (r.l4 >= list.jiefan)
                                                            {
                                                                contrast contrast = new contrast();
                                                                contrast.yuzhiId = r.id;
                                                                contrast.baoxiaoId = request.id;
                                                                contrast.l4 = list.jiefan;
                                                                ent.contrast.Add(contrast);

                                                                r.l4 = r.l4 - list.jiefan;
                                                                list.jiefan = 0;
                                                                break;
                                                            }
                                                            else
                                                            {
                                                                contrast contrast = new contrast();
                                                                contrast.yuzhiId = r.id;
                                                                contrast.baoxiaoId = request.id;
                                                                contrast.l4 = r.l4;
                                                                ent.contrast.Add(contrast);
                                                                r.l4 = 0;
                                                                list.jiefan = list.jiefan - r.l4;
                                                            }

                                                            if (r.l5 >= list.jiefan)
                                                            {
                                                                contrast contrast = new contrast();
                                                                contrast.yuzhiId = r.id;
                                                                contrast.baoxiaoId = request.id;
                                                                contrast.l5 = list.jiefan;
                                                                ent.contrast.Add(contrast);
                                                                r.l5 = r.l5 - list.jiefan;
                                                                list.jiefan = 0;
                                                                break;
                                                            }
                                                            else
                                                            {
                                                                contrast contrast = new contrast();
                                                                contrast.yuzhiId = r.id;
                                                                contrast.baoxiaoId = request.id;
                                                                contrast.l5 = r.l5;
                                                                ent.contrast.Add(contrast);
                                                                r.l5 = 0;
                                                                list.jiefan = list.jiefan - r.l5;
                                                            }
                                                            if (r.l6 >= list.jiefan)
                                                            {
                                                                contrast contrast = new contrast();
                                                                contrast.yuzhiId = r.id;
                                                                contrast.baoxiaoId = request.id;
                                                                contrast.l6 = list.jiefan;
                                                                ent.contrast.Add(contrast);
                                                                r.l6 = r.l6 - list.jiefan;
                                                                list.jiefan = 0;
                                                                break;
                                                            }
                                                            else
                                                            {
                                                                contrast contrast = new contrast();
                                                                contrast.yuzhiId = r.id;
                                                                contrast.baoxiaoId = request.id;
                                                                contrast.l6 = r.l6;
                                                                ent.contrast.Add(contrast);
                                                                r.l6 = 0;
                                                                list.jiefan = list.jiefan - r.l6;
                                                            }
                                                            if (r.l7 >= list.jiefan)
                                                            {
                                                                contrast contrast = new contrast();
                                                                contrast.yuzhiId = r.id;
                                                                contrast.baoxiaoId = request.id;
                                                                contrast.l7 = list.jiefan;
                                                                ent.contrast.Add(contrast);
                                                                r.l7 = r.l7 - list.jiefan;
                                                                list.jiefan = 0;
                                                                break;
                                                            }
                                                            else
                                                            {
                                                                contrast contrast = new contrast();
                                                                contrast.yuzhiId = r.id;
                                                                contrast.baoxiaoId = request.id;
                                                                contrast.l7 = r.l7;
                                                                ent.contrast.Add(contrast);
                                                                r.l7 = 0;
                                                                list.jiefan = list.jiefan - r.l7;
                                                            }

                                                            if (r.l13 >= list.jiefan)
                                                            {
                                                                contrast contrast = new contrast();
                                                                contrast.yuzhiId = r.id;
                                                                contrast.baoxiaoId = request.id;
                                                                contrast.l13 = list.jiefan;
                                                                ent.contrast.Add(contrast);
                                                                r.l13 = r.l13 - list.jiefan;
                                                                list.jiefan = 0;
                                                                break;
                                                            }
                                                            else
                                                            {
                                                                contrast contrast = new contrast();
                                                                contrast.yuzhiId = r.id;
                                                                contrast.baoxiaoId = request.id;
                                                                contrast.l13 = r.l13;
                                                                ent.SaveChanges();
                                                                r.l13 = 0;
                                                                list.jiefan = list.jiefan - r.l13;
                                                            }
                                                        }
                                                    }
                                                }
                                            else
                                            {
                                                return new { errorMsg = "请填写所有摘要信息" };
                                            }
                                        }
                                    }
                                    #endregion
                                    #region 银行录入
                                    inid++;
                                    ccodeList = ccodeList.Substring(0, ccodeList.Length - 1);
                                   /* if (piaoju.Yinhan.jiefan == 0) {//银行录入为0，说明本能冲账完成就不再添加流量
                                        continue;
                                    }*/

                                    GL_accvouch accs = new GL_accvouch()
                                    {//付款方录入
                                        iperiod = Convert.ToByte(DateTime.Now.Month),
                                        csign = dsign.U8VouchSign,//凭证类别字
                                        isignseq = 1,//凭证类别排序号 
                                        ino_id = Convert.ToInt16(book.ID),//凭证编号 
                                        inid = Convert.ToInt16(inid),//在12循环行号 
                                        dbill_date = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd")),//制单日期
                                        idoc = shifouShendan == false ? (short)0 : (short)1,//附单据数 (不生单为0生单为1)
                                        cbill = userInfo.name,//制单人
                                        ccheck = null,
                                        cbook = null,
                                        ibook = 0,
                                        ccashier = shifouShendan == false ? book.Cashier : null,//出纳签字人(不生单的签字了，生单的没有)
                                        iflag = null,
                                        ctext1 = null,
                                        ctext2 = null,
                                        cdigest = book.Summary,//摘要 
                                        ccode = model.content.SubjectCode,//科目编码 ，付款的用申请表里的付款科目来做查询(付款为你选择的科目编号)
                                        cexch_name = null,
                                        nc_s = 0,//数量贷方 
                                        nd_s = 0,//数量借方 
                                        nfrat = 0,//汇率 
                                        mc_f = 0.00M,//外币贷方金额  
                                        md_f = 0.00M,//外币借方金额
                                        md = 0.00M, //借方金额 
                                        mc = Convert.ToDecimal(piaoju.Yinhan.jiefan), //Convert.ToDecimal(piaoju.yinhuan),//贷方金额 
                                        csettle = null,// (from s in db.SettleStyle where s.cSSName.Equals("转账") select s).First().cSSCode,//结算方式编码 
                                        cn_id = null,
                                        dt_date = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd")),
                                        cdept_id = user == null ? u8.getDepatements(model.faqibumen).cDepCode : user.cDept_num, //getDepatements(r.shouyibumen).cDepCode,
                                        cperson_id = user == null ? null : user.cPsn_Num,
                                        ccus_id = kehus == null ? null : kehus.cCusCode,
                                        csup_id = gonyingshangs == null ? null : gonyingshangs.cVenCode,
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
                                        ccodeexch_equal = model.content.SubjectCode,//对方科目编码 ，付款的用申请表里的付款科目来做查询(付款为你选择的科目编号)
                                                                                    // daudit_date = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd")),//凭证审核日期 
                                        tvouchtime = DateTime.Now,//凭证保存时间 
                                        iYPeriod = Convert.ToInt32(DateTime.Now.Year + "" + (DateTime.Now.Month >= 10 ? DateTime.Now.Month.ToString() : "0" + DateTime.Now.Month)),
                                        RowGuid = Guid.NewGuid().ToString(),//包括年度的会计期间 
                                        bFlagOut = false,//公司对帐是否导出过对帐单
                                        bdelete = false,//是否核销 
                                    };
                                    db.GL_accvouch.Add(accs);
                                    db.SaveChanges();
                                    #endregion
                                    #region 如果生单，则需要修改生单表数据
                                    if (RecordTable.danjubianhao != null)
                                    {//生单过
                                        var cCusVen = kehus == null ? "" : kehus.cCusCode;
                                        cCusVen = gonyingshangs == null ? "" : gonyingshangs.cVenCode;
                                        var settleStyle = (from s in db.SettleStyle where s.cSSName.Equals("转账") select s);
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
                                            cSSCode = settleStyle.First().cSSCode,
                                            cProcStyle = "49",
                                            cCancelNo = "AP49" + DateTime.Now.ToString("yyMM") + book.VoucherNum.ToString().PadLeft(8, '0'),
                                            bPrePay = true,
                                            iFlag = 6,
                                            cCoVouchType = "49",
                                            cCoVouchID = DateTime.Now.ToString("yyMM") + book.VoucherNum.ToString().PadLeft(8, '0'),
                                            cFlag = "AP",
                                            iClosesID = 0,
                                            iCoClosesID = 0,
                                            cGLSign = accs.csign,
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
                                            cSSCode = settleStyle.First().cSSCode,
                                            cProcStyle = "49",
                                            cCancelNo = "AP49" + DateTime.Now.ToString("yyMM") + book.VoucherNum.ToString().PadLeft(8, '0'),
                                            bPrePay = true,
                                            iFlag = 6,
                                            cCoVouchType = "49",
                                            cCoVouchID = DateTime.Now.ToString("yyMM") + book.VoucherNum.ToString().PadLeft(8, '0'),
                                            cFlag = "AP",
                                            iClosesID = 0,
                                            iCoClosesID = 0,
                                            cGLSign = accs.csign,
                                            iGLno_id = (short)book.CSNCashID,
                                            dPZDate = DateTime.Now,
                                            cOperator = book.Cashier,
                                            cCheckMan = book.Cashier,
                                        };
                                        db.Ap_Detail.Add(detail);
                                        db.Ap_Detail.Add(details);
                                        db.SaveChanges();
                                        //修改生单
                                        var col = (from c in db.Ap_CloseBills
                                                   join cp in db.CN_PayedRecord on c.iID equals cp.iMainID
                                                   where cp.iAcctBookID == book.ID
                                                   select c).First();
                                        col.cKm = cCusVen;
                                        db.SaveChanges();
                                    }
                                    #endregion
                                    //添加流量
                                    foreach (var liu in piaoju.liuliangList) {

                                        GL_CashTable cash = new GL_CashTable()
                                        {
                                            iPeriod = Convert.ToByte(DateTime.Now.Month),
                                            iSignSeq = 1,
                                            iNo_id = Convert.ToInt16(book.ID),
                                            inid = Convert.ToInt16(inid),
                                            cCashItem = liu.citemcode,
                                            md = 0.00M,//收入金额时候才用，现在只做支出
                                            mc = liu.jine,
                                            //  ccode = cashMc.Key,
                                            ccode = model.content.SubjectCode,
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
                                        if (liu.citemcode.Equals("04")) {
                                            request.l4 = liu.jine;
                                        }
                                        if (liu.citemcode.Equals("05"))
                                        {
                                            request.l5 = liu.jine;
                                        }
                                        if (liu.citemcode.Equals("06"))
                                        {
                                            request.l6 = liu.jine;
                                        }
                                        if (liu.citemcode.Equals("07"))
                                        {
                                            request.l7 = liu.jine;
                                        }
                                        if (liu.citemcode.Equals("13"))
                                        {
                                            request.l13 = liu.jine;
                                        }
                                        ent.SaveChanges();
                                    } 

                                    CN_VARelate v = new CN_VARelate()
                                    {
                                        AcctID = book.AcctID,
                                        VouchID = accs.i_id,
                                        IsPrint = 0
                                    };//凭证开票对应关系
                                    db.CN_VARelate.Add(v);
                                    db.SaveChanges();
                                    var CN_CashSignRelate = (from c in db.CN_CashSignRelate orderby c.ID descending select c).FirstOrDefault();
                                    string sql = string.Format(@"insert into CN_CashSignRelate(AcctBookID,JobID,VouchID,AccountID) values({0},{1},{2},{3})", book.ID, CN_CashSignRelate == null ? 1 : CN_CashSignRelate.ID + 1, accs.i_id, book.AcctID);
                                    int dt = SqlHelper.ExecuteNonQuery(config, sql);
                                    if (dt < 1)
                                    {//这张表未改变
                                        throw new Exception("CN_CashSignRelate未成功添加数据，终止操作");
                                    }
                                    book.VoucherStr = accs.csign + "  " + book.VoucherNum;
                                    book.IsRegGLVouch = 1;//制单成功
                                    book.VouchOutSignNum = accs.coutno_id;
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
                                    model.piaoju[i].pingzhenhao = book.VoucherStr;
                                }
                                trans.Commit();
                                tran.Commit();
                                
                                return new { model = model, sucess = "制单成功" };
                            }
                            catch (Exception ex)
                            {
                                tran.Rollback();
                                LogHelper.WriteLog(GetIP.getIP() + "------------------------" + ex.Message);
                                return new { errorMsg = "制单失败，系统故障" };
                            }
                        }
                    }
                }
            }
        }
        #endregion
    }
}
