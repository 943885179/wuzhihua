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
    
    public partial class HR_TM_PsnDutyChange
    {
        public string cVoucherCode { get; set; }
        public string vRemark { get; set; }
        public string cCreater { get; set; }
        public Nullable<System.DateTime> dCreatTime { get; set; }
        public Nullable<System.DateTime> dOperatTime { get; set; }
        public string cAuditor { get; set; }
        public Nullable<System.DateTime> dAuditTime { get; set; }
        public System.Guid PK_HR_TM_PsnDutyChange { get; set; }
        public Nullable<int> iswfcontrolled { get; set; }
        public Nullable<int> iverifystate { get; set; }
        public Nullable<int> ireturncount { get; set; }
        public Nullable<int> UAPRuntime_RowNO { get; set; }
        public string UAP_VoucherTransform_Rowkey { get; set; }
        public string cDept_Num { get; set; }
    }
}
