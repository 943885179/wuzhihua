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
    
    public partial class hr_dm_DormAssign
    {
        public System.Guid pk_hr_dm_DormAssign { get; set; }
        public string dormcode { get; set; }
        public string cPsn_num { get; set; }
        public string cPsn_num2 { get; set; }
        public string BeginDate { get; set; }
        public string EndDate { get; set; }
        public Nullable<decimal> Begindeposit { get; set; }
        public Nullable<decimal> EndDeposit { get; set; }
        public string memo { get; set; }
        public byte[] hrts { get; set; }
        public Nullable<bool> bLastFlag { get; set; }
        public Nullable<int> iRecordID { get; set; }
        public string vstatus1 { get; set; }
        public Nullable<decimal> nstatus2 { get; set; }
    }
}
