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
    
    public partial class hr_ss_change
    {
        public System.Guid PK_hr_ss_change { get; set; }
        public string Hr_ss_changCode { get; set; }
        public string nTableName { get; set; }
        public string cPsn_Num { get; set; }
        public string cDept_num { get; set; }
        public string changType { get; set; }
        public Nullable<System.DateTime> changDate { get; set; }
        public string VoucherId { get; set; }
        public string VoucherCode { get; set; }
        public string VoucherType { get; set; }
        public string PsnCode { get; set; }
        public string DptCode { get; set; }
        public Nullable<System.DateTime> CreateOn { get; set; }
        public string Creater { get; set; }
        public Nullable<System.DateTime> SubmitOn { get; set; }
        public Nullable<System.DateTime> AuditOn { get; set; }
        public string Auditor { get; set; }
        public string Status { get; set; }
        public string Role { get; set; }
        public string vRestPeriod { get; set; }
    }
}
