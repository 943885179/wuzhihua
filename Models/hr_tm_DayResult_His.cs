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
    
    public partial class hr_tm_DayResult_His
    {
        public Nullable<int> iRecordId { get; set; }
        public string cPsn_Num { get; set; }
        public string cDepCode { get; set; }
        public string dDutyDate { get; set; }
        public string cDutyCode { get; set; }
        public Nullable<decimal> nWorkHours { get; set; }
        public Nullable<decimal> nWorkHours1 { get; set; }
        public Nullable<decimal> nAbsentHour { get; set; }
        public Nullable<int> iAbsentTimes { get; set; }
        public Nullable<decimal> nEAbsentMinute { get; set; }
        public Nullable<int> iEAbsentTimes { get; set; }
        public Nullable<decimal> nLAbsentMinute { get; set; }
        public Nullable<int> iLAbsentTimes { get; set; }
        public Nullable<int> iNoCheckTimes { get; set; }
        public Nullable<int> iOneCheckTimes { get; set; }
        public Nullable<bool> bManual { get; set; }
        public string dOldDutyDate { get; set; }
        public string cOldBcCode { get; set; }
        public string vChangeResonse { get; set; }
        public Nullable<bool> bLastFlag { get; set; }
        public string vStatus1 { get; set; }
        public Nullable<decimal> nStatus2 { get; set; }
        public string vMemo { get; set; }
        public System.Guid pk_hr_tm_DayResult_His { get; set; }
        public string cpsn_name { get; set; }
    }
}
