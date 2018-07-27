//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CN_AcctBook
    {
        public int ID { get; set; }
        public int AcctID { get; set; }
        public Nullable<int> AcctType { get; set; }
        public Nullable<System.DateTime> AcctDate { get; set; }
        public string VoucherStr { get; set; }
        public Nullable<int> VoucherNum { get; set; }
        public Nullable<int> Period { get; set; }
        public Nullable<decimal> Debit { get; set; }
        public Nullable<decimal> Credit { get; set; }
        public Nullable<decimal> FDebit { get; set; }
        public Nullable<decimal> FCredit { get; set; }
        public Nullable<double> ExchangeRate { get; set; }
        public string Summary { get; set; }
        public Nullable<int> SettleTypeID { get; set; }
        public string SettleID { get; set; }
        public Nullable<int> DeptID { get; set; }
        public Nullable<int> PersonID { get; set; }
        public Nullable<int> ProjectID { get; set; }
        public Nullable<int> UnitID { get; set; }
        public Nullable<int> UnitType { get; set; }
        public Nullable<int> SourceType { get; set; }
        public string Cashier { get; set; }
        public Nullable<int> IsAudited { get; set; }
        public string Auditor { get; set; }
        public Nullable<int> IsDelete { get; set; }
        public Nullable<int> IsRegGLVouch { get; set; }
        public Nullable<int> RectifyID { get; set; }
        public string RectifyType { get; set; }
        public Nullable<int> CACheckFlag { get; set; }
        public Nullable<int> CBCheckFlag { get; set; }
        public Nullable<int> CustomCol1 { get; set; }
        public Nullable<int> CustomCol2 { get; set; }
        public Nullable<int> CustomCol3 { get; set; }
        public Nullable<int> CashNum { get; set; }
        public string CashStr { get; set; }
        public Nullable<int> ProjectClass { get; set; }
        public string CorrVouchID { get; set; }
        public string GLSubjectCode { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public Nullable<int> VendorID { get; set; }
        public Nullable<System.DateTime> InOutDate { get; set; }
        public Nullable<int> CashInk { get; set; }
        public string cDefine1 { get; set; }
        public string cDefine2 { get; set; }
        public string cDefine3 { get; set; }
        public Nullable<System.DateTime> cDefine4 { get; set; }
        public Nullable<int> cDefine5 { get; set; }
        public Nullable<System.DateTime> cDefine6 { get; set; }
        public Nullable<double> cDefine7 { get; set; }
        public string cDefine8 { get; set; }
        public string cDefine9 { get; set; }
        public string cDefine10 { get; set; }
        public string cDefine11 { get; set; }
        public string cDefine12 { get; set; }
        public string cDefine13 { get; set; }
        public string cDefine14 { get; set; }
        public Nullable<int> cDefine15 { get; set; }
        public Nullable<double> cDefine16 { get; set; }
        public string VouchOutSignNum { get; set; }
        public Nullable<int> RateCalType { get; set; }
        public string CSNCashSign { get; set; }
        public Nullable<int> CSNCashID { get; set; }
        public Nullable<System.DateTime> CBCheckDate { get; set; }
        public int ID_Old { get; set; }
        public int lYear { get; set; }
        public int iBankrecpid { get; set; }
        public string CBCheckSerialNum { get; set; }
        public int lParentID { get; set; }
    }
}
