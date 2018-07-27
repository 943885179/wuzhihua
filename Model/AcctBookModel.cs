using System;

namespace model
{
    public class AcctBookModel
    {
        public int ID { get; set; }
        public int AcctID { get; set; }
        public int? AcctType { get; set; }
        public DateTime? AcctDate { get; set; }
        public string VoucherStr { get; set; }
        public int? VoucherNum { get; set; }
        public int? Period { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public decimal? FDebit { get; set; }
        public decimal? FCredit { get; set; }
        public float? ExchangeRate { get; set; }
        public string Summary { get; set; }
        public int SettleTypeID { get; set; }
        public int SettleID { get; set; }
        public int DeptID { get; set; }
        public int PersonID { get; set; }
        public int ProjectID { get; set; }
        public int UnitID { get; set; }
        public string UnitType { get; set; }
        public string SourceType { get; set; }
        public string Cashier { get; set; }
        public string IsAudited { get; set; }
        public string Auditor { get; set; }
        public int IsDelete { get; set; }
        public int IsRegGLVouch { get; set; }
        public int RectifyID { get; set; }
        public string RectifyType { get; set; }
        public string CACheckFlag { get; set; }
        public string CBCheckFlag { get; set; }
        public string CustomCol1 { get; set; }
        public string CustomCol2 { get; set; }
        public string CustomCol3 { get; set; }
        public string CashNum { get; set; }
        public string CashStr { get; set; }
        public int ProjectClass { get; set; }
        public string CorrVouchID { get; set; }
        public string GLSubjectCode { get; set; }
        public string CustomerID { get; set; }
        public string VendorID { get; set; }
        public string InOutDate { get; set; }
        public string CashInk { get; set; }
        public string cDefine1 { get; set; }
        public string cDefine2 { get; set; }
        public string cDefine3 { get; set; }
        public string cDefine4 { get; set; }
        public string cDefine5 { get; set; }
        public string cDefine6 { get; set; }
        public string cDefine7 { get; set; }
        public string cDefine8 { get; set; }
        public string cDefine9 { get; set; }
        public string cDefine10 { get; set; }
        public string cDefine11 { get; set; }
        public string cDefine12 { get; set; }
        public string cDefine13 { get; set; }
        public string cDefine14 { get; set; }
        public string cDefine15 { get; set; }
        public string cDefine16 { get; set; }
        public string VouchOutSignNum { get; set; }
        public string RateCalType { get; set; }
        public string CSNCashSign { get; set; }
        public string CSNCashID { get; set; }
        public string CBCheckDate { get; set; }
        public string ID_Old { get; set; }
        public int lYear { get; set; }
        public string iBankrecpid { get; set; }
        public string CBCheckSerialNum { get; set; }
        public int lParentID { get; set; }

    }
}
