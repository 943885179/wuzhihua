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
    
    public partial class hr_tm_PreDayResult
    {
        public int iRecordId { get; set; }
        public string cPsn_Num { get; set; }
        public string dDutyDate { get; set; }
        public string cDutyCode { get; set; }
        public Nullable<decimal> nWorkHours { get; set; }
        public Nullable<decimal> nWorkHours1 { get; set; }
        public Nullable<decimal> nAbsentHour { get; set; }
        public Nullable<int> iAbsentTimes { get; set; }
        public Nullable<int> nEAbsentMinute { get; set; }
        public Nullable<int> iEAbsentTimes { get; set; }
        public Nullable<int> nLAbsentMinute { get; set; }
        public Nullable<int> iLAbsentTimes { get; set; }
        public string vRemark { get; set; }
        public Nullable<bool> bLastFlag { get; set; }
        public string vStatus1 { get; set; }
        public Nullable<decimal> nStatus2 { get; set; }
        public string cDepCode { get; set; }
        public System.Guid pk_hr_tm_DayResult { get; set; }
        public string cpsn_name { get; set; }
        public string p1Start { get; set; }
        public string p1StartCard { get; set; }
        public string p2Start { get; set; }
        public string p2StartCard { get; set; }
        public string p3Start { get; set; }
        public string p3StartCard { get; set; }
        public string p1End { get; set; }
        public string p1EndCard { get; set; }
        public string p2End { get; set; }
        public string p2EndCard { get; set; }
        public string p3End { get; set; }
        public string p3EndCard { get; set; }
        public string rDutyType { get; set; }
        public string rDateProperty { get; set; }
        public Nullable<int> iWorkMinute { get; set; }
        public Nullable<decimal> nWorkDays { get; set; }
        public Nullable<int> iActualWorkMinute { get; set; }
        public Nullable<decimal> nActualWorkDays { get; set; }
        public Nullable<int> iAbsentMinute { get; set; }
        public Nullable<int> iLateOverTimes { get; set; }
        public Nullable<int> iLeaveOverTimes { get; set; }
        public Nullable<int> iAbsentOverTimes { get; set; }
        public Nullable<int> iLateOverTime { get; set; }
        public Nullable<int> iLeaveOverTime { get; set; }
        public Nullable<int> iAbsentOverMinute { get; set; }
        public Nullable<decimal> nAbsentOverHours { get; set; }
        public Nullable<int> iSignCardTimes { get; set; }
        public Nullable<int> iLackCardTimes { get; set; }
        public Nullable<int> iSignCardTimesForOver { get; set; }
        public Nullable<int> iLackCardTimesForOver { get; set; }
        public string rLeaveType1 { get; set; }
        public Nullable<int> iLeaveMinute1 { get; set; }
        public Nullable<decimal> nLeaveHours1 { get; set; }
        public Nullable<decimal> nLeaveDays1 { get; set; }
        public string rLeaveType2 { get; set; }
        public Nullable<int> iLeaveMinute2 { get; set; }
        public Nullable<decimal> nLeaveHours2 { get; set; }
        public Nullable<decimal> nLeaveDays2 { get; set; }
        public Nullable<int> iErrandMinute { get; set; }
        public Nullable<decimal> nErrandHours { get; set; }
        public string rErrandType1 { get; set; }
        public Nullable<decimal> nErrandHours1 { get; set; }
        public Nullable<decimal> nErrandDays1 { get; set; }
        public string rErrandType2 { get; set; }
        public Nullable<decimal> nErrandHours2 { get; set; }
        public Nullable<decimal> nErrandDays2 { get; set; }
        public string rOverTimeType1 { get; set; }
        public Nullable<int> iOverTimeMinute1 { get; set; }
        public Nullable<decimal> nOverTimeHours1 { get; set; }
        public string rOverTimeType2 { get; set; }
        public Nullable<int> iOverTimeMinute2 { get; set; }
        public Nullable<decimal> nOverTimeHours2 { get; set; }
        public string rOverTimeType3 { get; set; }
        public Nullable<int> iOverTimeMinute3 { get; set; }
        public Nullable<decimal> nOverTimeHours3 { get; set; }
        public string rOverTimeType4 { get; set; }
        public Nullable<int> iOverTimeMinute4 { get; set; }
        public Nullable<decimal> nOverTimeHours4 { get; set; }
        public string p4Start { get; set; }
        public string p4End { get; set; }
        public string p4StartCard { get; set; }
        public string p4EndCard { get; set; }
        public string p5Start { get; set; }
        public string p5End { get; set; }
        public string p5StartCard { get; set; }
        public string p5EndCard { get; set; }
        public string dDutyCardStart { get; set; }
        public string dDutyCardEnd { get; set; }
        public string dDutyStart { get; set; }
        public string dDutyOff { get; set; }
        public string vVacPeriod { get; set; }
        public string bNormal { get; set; }
        public string cAuditorNum { get; set; }
        public string cAuditor { get; set; }
        public string dAuditTime { get; set; }
        public Nullable<bool> bAuditFlag { get; set; }
        public string cCreatorNum { get; set; }
        public string cCreator { get; set; }
        public string dCreatTime { get; set; }
        public string cOperatorNum { get; set; }
        public string cOperator { get; set; }
        public string dOperatTime { get; set; }
        public string vSaveDutyBasic { get; set; }
        public Nullable<bool> bDutyBasic { get; set; }
        public Nullable<int> DB_iWorkMinute { get; set; }
        public Nullable<decimal> DB_ManHours { get; set; }
        public string DB_dDutyStart { get; set; }
        public string DB_dDutyOff { get; set; }
        public Nullable<int> DB_bStartOver { get; set; }
        public Nullable<int> DB_bEndOver { get; set; }
        public Nullable<int> DB_iDutyOver { get; set; }
        public Nullable<int> DB_iOffOver { get; set; }
        public string DB_dStartCTime { get; set; }
        public string DB_dEndCTime { get; set; }
        public string cDepCode_Num { get; set; }
        public string JobNumber { get; set; }
        public Nullable<int> iAbsentOverMinute_Voucher { get; set; }
        public Nullable<int> iAbsentOverTimes_Voucher { get; set; }
        public Nullable<int> iLackCardTimesForOver_Voucher { get; set; }
        public Nullable<int> iLateOverTime_Voucher { get; set; }
        public Nullable<int> iLateOverTimes_Voucher { get; set; }
        public Nullable<int> iLeaveOverTime_Voucher { get; set; }
        public Nullable<int> iLeaveOverTimes_Voucher { get; set; }
        public Nullable<int> iSignCardTimesForOver_Voucher { get; set; }
        public Nullable<decimal> nAbsentOverHours_Voucher { get; set; }
        public Nullable<int> bJoinDuty { get; set; }
        public Nullable<int> nDedOverTimeMinute { get; set; }
        public Nullable<int> nDedLateAndEarlyMinute { get; set; }
        public Nullable<int> nDedAbsentMinute { get; set; }
        public Nullable<int> nDedLeaveMinute { get; set; }
        public Nullable<int> iMidShiftTimes { get; set; }
        public Nullable<int> iNightShiftTimes { get; set; }
        public string cShiftSource { get; set; }
        public string cDutyClass { get; set; }
        public string cAbnormalReason { get; set; }
        public Nullable<bool> bHaveUnAuditedVoucher { get; set; }
        public Nullable<bool> bHaveUnwantedCard { get; set; }
        public Nullable<int> iDayShiftTimes { get; set; }
        public string dTodayCards1 { get; set; }
        public string dTodayCards2 { get; set; }
        public string dTodayCards3 { get; set; }
        public string dTodayCards4 { get; set; }
        public string dTodayCards5 { get; set; }
        public string dTodayCards6 { get; set; }
        public string dTodayCards7 { get; set; }
        public string dTodayCards8 { get; set; }
        public string dTodayCards9 { get; set; }
        public string dTodayCards10 { get; set; }
        public Nullable<bool> dTodayCards1AuditFlag { get; set; }
        public Nullable<bool> dTodayCards2AuditFlag { get; set; }
        public Nullable<bool> dTodayCards3AuditFlag { get; set; }
        public Nullable<bool> dTodayCards4AuditFlag { get; set; }
        public Nullable<bool> dTodayCards5AuditFlag { get; set; }
        public Nullable<bool> dTodayCards6AuditFlag { get; set; }
        public Nullable<bool> dTodayCards7AuditFlag { get; set; }
        public Nullable<bool> dTodayCards8AuditFlag { get; set; }
        public Nullable<bool> dTodayCards9AuditFlag { get; set; }
        public Nullable<bool> dTodayCards10AuditFlag { get; set; }
        public string nArrangingPlan { get; set; }
        public string vVacPeriod1 { get; set; }
        public string vVacPeriod2 { get; set; }
        public string vVacPeriod3 { get; set; }
        public string vVacPeriod4 { get; set; }
        public string rLeaveType3 { get; set; }
        public Nullable<int> iLeaveMinute3 { get; set; }
        public Nullable<decimal> nLeaveHours3 { get; set; }
        public Nullable<decimal> nLeaveDays3 { get; set; }
        public string rLeaveType4 { get; set; }
        public Nullable<int> iLeaveMinute4 { get; set; }
        public Nullable<decimal> nLeaveHours4 { get; set; }
        public Nullable<decimal> nLeaveDays4 { get; set; }
        public string rDealType1 { get; set; }
        public string rDealType2 { get; set; }
        public string rDealType3 { get; set; }
        public string rDealType4 { get; set; }
        public Nullable<System.DateTime> dCalDate { get; set; }
        public byte[] ufts { get; set; }
        public Nullable<System.Guid> ID_hr_tm_leave1 { get; set; }
        public Nullable<System.Guid> ID_hr_tm_leave2 { get; set; }
        public Nullable<System.Guid> ID_hr_tm_leave3 { get; set; }
        public Nullable<System.Guid> ID_hr_tm_leave4 { get; set; }
        public Nullable<int> dTodayCards1bEffect { get; set; }
        public Nullable<int> dTodayCards2bEffect { get; set; }
        public Nullable<int> dTodayCards3bEffect { get; set; }
        public Nullable<int> dTodayCards4bEffect { get; set; }
        public Nullable<int> dTodayCards5bEffect { get; set; }
        public Nullable<int> dTodayCards6bEffect { get; set; }
        public Nullable<int> dTodayCards7bEffect { get; set; }
        public Nullable<int> dTodayCards8bEffect { get; set; }
        public Nullable<int> dTodayCards9bEffect { get; set; }
        public Nullable<int> dTodayCards10bEffect { get; set; }
    }
}
