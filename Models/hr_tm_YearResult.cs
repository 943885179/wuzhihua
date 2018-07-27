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
    
    public partial class hr_tm_YearResult
    {
        public int iRecordId { get; set; }
        public string cYear { get; set; }
        public string rPeriodType { get; set; }
        public string iPeriod { get; set; }
        public Nullable<int> dPeriodFirstMonth { get; set; }
        public Nullable<int> dPeriodLastMonth { get; set; }
        public string cPsn_Num { get; set; }
        public string vDepCode { get; set; }
        public string vDepCode_num { get; set; }
        public Nullable<decimal> nWorkHours { get; set; }
        public Nullable<decimal> nRealHours { get; set; }
        public Nullable<decimal> nAbsentHour { get; set; }
        public Nullable<int> iAbsentTimes { get; set; }
        public Nullable<decimal> nEAbsentMinute { get; set; }
        public Nullable<int> iEAbsentTimes { get; set; }
        public Nullable<decimal> nLAbsentMinute { get; set; }
        public Nullable<int> iLAbsentTimes { get; set; }
        public string vRemark { get; set; }
        public Nullable<bool> bLastFlag { get; set; }
        public string vStatus1 { get; set; }
        public Nullable<decimal> nStatus2 { get; set; }
        public System.Guid pk_hr_tm_YearResult { get; set; }
        public string cpsn_name { get; set; }
        public Nullable<bool> bCheck { get; set; }
        public Nullable<decimal> nStandardManHour { get; set; }
        public Nullable<decimal> nStandardDays { get; set; }
        public Nullable<decimal> nWorkDays { get; set; }
        public Nullable<decimal> nRealDays { get; set; }
        public Nullable<int> iLateOverTimes { get; set; }
        public Nullable<int> iLeaveOverTimes { get; set; }
        public Nullable<int> iAbsentOverTimes { get; set; }
        public Nullable<int> iLateOverTime { get; set; }
        public Nullable<int> iLeaveOverTime { get; set; }
        public Nullable<decimal> nAbsentOverTime { get; set; }
        public Nullable<decimal> nSalaryRestHours { get; set; }
        public Nullable<decimal> nSalaryRestDays { get; set; }
        public Nullable<decimal> nNoSalaryRestHours { get; set; }
        public Nullable<decimal> nNoSalaryRestDays { get; set; }
        public Nullable<decimal> nCompTimeOffHours { get; set; }
        public Nullable<decimal> nPreTotalCompLeaveHours { get; set; }
        public Nullable<decimal> nCurDeductCompLeaveHours { get; set; }
        public Nullable<decimal> nCurTotalCompLeaveHours { get; set; }
        public Nullable<decimal> nCurBalanceCompLeaveHours { get; set; }
        public Nullable<decimal> nLackWorkHours { get; set; }
        public Nullable<decimal> nPreTotalLackWorkHours { get; set; }
        public Nullable<decimal> nCurDeductLackWorkHours { get; set; }
        public Nullable<decimal> nCurTotalLackWorkHours { get; set; }
        public Nullable<decimal> nCurBalanceLackWorkHours { get; set; }
        public Nullable<decimal> nBalancedVac { get; set; }
        public Nullable<decimal> nLocalErrandHours { get; set; }
        public Nullable<decimal> nRemoteErradHours { get; set; }
        public Nullable<decimal> nLocalErrandDays { get; set; }
        public Nullable<decimal> nRemoteErrandDays { get; set; }
        public Nullable<decimal> nPrivateLeaveHours { get; set; }
        public Nullable<decimal> nSickLeaveHours { get; set; }
        public Nullable<decimal> nVacHours { get; set; }
        public Nullable<decimal> nMateHours { get; set; }
        public Nullable<decimal> nWedHours { get; set; }
        public Nullable<decimal> nHuntHours { get; set; }
        public Nullable<decimal> nLoseHours { get; set; }
        public Nullable<decimal> nComSickHours { get; set; }
        public Nullable<decimal> nLactationHours { get; set; }
        public Nullable<decimal> nComHours { get; set; }
        public Nullable<decimal> nTendHours { get; set; }
        public Nullable<decimal> nVacDays { get; set; }
        public Nullable<decimal> nPrivateLeaveDays { get; set; }
        public Nullable<decimal> nSickLeaveDays { get; set; }
        public Nullable<decimal> nMateDays { get; set; }
        public Nullable<decimal> nWedDays { get; set; }
        public Nullable<decimal> nHuntDays { get; set; }
        public Nullable<decimal> nLoseDays { get; set; }
        public Nullable<decimal> nComSickDays { get; set; }
        public Nullable<decimal> nLactationDays { get; set; }
        public Nullable<decimal> nComDays { get; set; }
        public Nullable<decimal> nTendDays { get; set; }
        public Nullable<decimal> nWorkOverHours { get; set; }
        public Nullable<decimal> nRestOverHours { get; set; }
        public Nullable<decimal> nHolidayOverHours { get; set; }
        public Nullable<decimal> nPreWorkOverSumTime { get; set; }
        public Nullable<decimal> nPreRestOverSumTime { get; set; }
        public Nullable<decimal> nPreHolidayOverSumTime { get; set; }
        public Nullable<decimal> nWorkOverDedTime { get; set; }
        public Nullable<decimal> nRestOverDedTime { get; set; }
        public Nullable<decimal> nHolidayOverDedTime { get; set; }
        public Nullable<decimal> nWorkOverSumTime { get; set; }
        public Nullable<decimal> nRestOverSumTime { get; set; }
        public Nullable<decimal> nHolidayOverSumTime { get; set; }
        public Nullable<decimal> nWorkOverBalTime { get; set; }
        public Nullable<decimal> nRestOverBalTime { get; set; }
        public Nullable<decimal> nHolidayOverBalTime { get; set; }
        public string dPeriodStart { get; set; }
        public string dPeriodEnd { get; set; }
        public string rManHourSystem { get; set; }
        public Nullable<int> iSignCardTimes { get; set; }
        public Nullable<int> iLackCardTimes { get; set; }
        public Nullable<int> iSignCardTimesForOver { get; set; }
        public Nullable<int> iLackCardTimesForOver { get; set; }
        public Nullable<decimal> nCompLeaveDays { get; set; }
        public Nullable<decimal> nLackWorkDays { get; set; }
        public string JobNumber { get; set; }
        public Nullable<int> iLateOverTime_Voucher { get; set; }
        public Nullable<int> iLateOverTimes_Voucher { get; set; }
        public Nullable<int> iLeaveOverTime_Voucher { get; set; }
        public Nullable<int> iLeaveOverTimes_Voucher { get; set; }
        public Nullable<decimal> nAbsentOverTime_Voucher { get; set; }
        public Nullable<int> iAbsentOverTimes_Voucher { get; set; }
        public Nullable<int> iSignCardTimesForOver_Voucher { get; set; }
        public Nullable<int> iLackCardTimesForOver_Voucher { get; set; }
        public Nullable<int> iMidShiftTimes { get; set; }
        public Nullable<int> iNightShiftTimes { get; set; }
        public Nullable<int> iDayShiftTimes { get; set; }
        public string rPersonType { get; set; }
        public string rEmployState { get; set; }
        public Nullable<decimal> nWorkOverHoursCanceled { get; set; }
        public Nullable<decimal> nRestOverHoursCanceled { get; set; }
        public Nullable<decimal> nHolidayOverHoursCanceled { get; set; }
    }
}
