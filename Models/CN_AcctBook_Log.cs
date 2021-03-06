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
    
    public partial class CN_AcctBook_Log
    {
        public long HistoryId { get; set; }
        public int VariationAction { get; set; }
        public int VariationLogId { get; set; }
        public int bDeletedRst { get; set; }
        public System.DateTime dLogTime { get; set; }
        public string CashierID { get; set; }
        public int ID { get; set; }
        public Nullable<System.DateTime> AcctDate { get; set; }
        public string VoucherID { get; set; }
        public Nullable<int> Period { get; set; }
        public Nullable<decimal> Debit { get; set; }
        public Nullable<decimal> Credit { get; set; }
        public Nullable<decimal> FDebit { get; set; }
        public Nullable<decimal> FCredit { get; set; }
        public Nullable<double> ExchangeRate { get; set; }
        public string Summary { get; set; }
        public string SettleTypeCode { get; set; }
        public string SettleID { get; set; }
        public string DeptCode { get; set; }
        public string PersonCode { get; set; }
        public string ProjectClassCode { get; set; }
        public string ProjectCode { get; set; }
        public string UnitType { get; set; }
        public string UnitCode { get; set; }
        public string GLSubjectCode { get; set; }
        public Nullable<System.DateTime> InOutDate { get; set; }
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
        public string Cashier { get; set; }
        public string Auditor { get; set; }
        public string CustomCol1 { get; set; }
        public string CustomCol2 { get; set; }
        public string CustomCol3 { get; set; }
    }
}
