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
    
    public partial class hr_bd_Voucher
    {
        public System.Guid pk_hr_bd_Voucher { get; set; }
        public string cCode { get; set; }
        public string cVoucherId { get; set; }
        public string cVoucherCode { get; set; }
        public string cVoucherType { get; set; }
        public string cStatus { get; set; }
        public string cCreateBy { get; set; }
        public string dCreateOn { get; set; }
        public string cSubmitBy { get; set; }
        public string dSubmitOn { get; set; }
        public string cAuditBy { get; set; }
        public string dAuditOn { get; set; }
        public string cDepCode { get; set; }
        public Nullable<int> iYear { get; set; }
        public Nullable<int> iMonth { get; set; }
        public string cDemo { get; set; }
        public string rPersonType { get; set; }
        public string cStatus1 { get; set; }
        public string cStatus2 { get; set; }
        public Nullable<int> iStatus3 { get; set; }
        public Nullable<int> iStatus4 { get; set; }
        public Nullable<decimal> nStatus5 { get; set; }
        public Nullable<decimal> nStatus6 { get; set; }
        public Nullable<bool> bInFlow { get; set; }
        public string rEmployState { get; set; }
    }
}
