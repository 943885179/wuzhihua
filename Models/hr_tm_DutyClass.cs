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
    
    public partial class hr_tm_DutyClass
    {
        public string cCode { get; set; }
        public string vName { get; set; }
        public string vDefaultBc { get; set; }
        public Nullable<int> iShiftCycle { get; set; }
        public string cRestType { get; set; }
        public string vTimeUseless { get; set; }
        public string cDepCode { get; set; }
        public string rRulesForShift { get; set; }
        public Nullable<bool> bHoliday { get; set; }
        public string dBase { get; set; }
        public string dLastStart { get; set; }
        public string dLastEnd { get; set; }
        public string rBaseCode { get; set; }
        public string rLastStartCode { get; set; }
        public string rLastEndCode { get; set; }
        public string rGroup { get; set; }
        public string dEstablisheDate { get; set; }
        public string dWithdrawalDate { get; set; }
        public Nullable<int> OrderInGroup { get; set; }
        public Nullable<bool> bdutylock { get; set; }
        public Nullable<int> bFrom { get; set; }
    }
}
