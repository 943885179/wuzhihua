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
    
    public partial class hr_tm_DutyPeriod
    {
        public System.Guid uRecordId { get; set; }
        public string cDutyCode { get; set; }
        public Nullable<int> iOrder { get; set; }
        public string dDutyTime { get; set; }
        public Nullable<int> bOverDate { get; set; }
        public string dOffTime { get; set; }
        public Nullable<int> bOverDate2 { get; set; }
        public string dBeginTime { get; set; }
        public string dEndTime { get; set; }
        public Nullable<decimal> nMaxDelay { get; set; }
        public Nullable<decimal> nMaxLeave { get; set; }
        public Nullable<decimal> nAbsent0 { get; set; }
        public Nullable<decimal> nAbsent1 { get; set; }
        public Nullable<decimal> nAbsent2 { get; set; }
        public Nullable<decimal> nAbsent3 { get; set; }
        public Nullable<decimal> nRestTime { get; set; }
        public Nullable<bool> bSignStart { get; set; }
        public Nullable<bool> bSignOff { get; set; }
        public Nullable<int> iReduseRest { get; set; }
        public Nullable<bool> bOverTimePeriod { get; set; }
        public Nullable<bool> bOverTimeForEarlySign { get; set; }
        public Nullable<bool> bOverTimeForLateSign { get; set; }
        public Nullable<bool> bBadResultForOverPeriod { get; set; }
    }
}
