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
    
    public partial class hr_rt_planchan
    {
        public System.Guid pk_hr_rt_planchan { get; set; }
        public string cBillNo { get; set; }
        public string cBusinessId { get; set; }
        public string vJobChan { get; set; }
        public string rAdMode { get; set; }
        public string dStartDate { get; set; }
        public string dEndDate { get; set; }
        public Nullable<int> iRecordID { get; set; }
        public string bLastFlag { get; set; }
        public string vStatus1 { get; set; }
        public Nullable<decimal> nStatus2 { get; set; }
    }
}
