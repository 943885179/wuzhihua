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
    
    public partial class HR_TM_PsnDutyChangeSub
    {
        public Nullable<System.DateTime> dDate1 { get; set; }
        public Nullable<System.DateTime> dDate2 { get; set; }
        public System.Guid PK_HR_TM_PsnDutyChangeSub { get; set; }
        public Nullable<System.Guid> PK_HR_TM_PsnDutyChange { get; set; }
        public Nullable<int> UAPRuntime_RowNO { get; set; }
        public string UAP_VoucherTransform_Rowkey { get; set; }
        public string RefMainID { get; set; }
        public string RefRowID { get; set; }
        public string cpsn1_num { get; set; }
        public string cpsn2_Num { get; set; }
        public string cpsn_jobnumber1 { get; set; }
        public string cpsn_jobnumber2 { get; set; }
    }
}
