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
    
    public partial class HR_TM_PersonDutyChange
    {
        public string VoucherID { get; set; }
        public string cDeptCode { get; set; }
        public string vRemark { get; set; }
        public bool bAuditFlag { get; set; }
        public string cAuditor { get; set; }
        public string cAuditorNum { get; set; }
        public Nullable<System.DateTime> dAuditTime { get; set; }
        public string cCreator { get; set; }
        public string cCreatorNum { get; set; }
        public System.DateTime dCreatTime { get; set; }
        public string cOperator { get; set; }
        public string cOperatorNum { get; set; }
        public Nullable<System.DateTime> dOperatTime { get; set; }
        public int iRecordId { get; set; }
    }
}
