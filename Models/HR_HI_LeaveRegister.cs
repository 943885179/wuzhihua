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
    
    public partial class HR_HI_LeaveRegister
    {
        public System.Guid PK_HR_HI_LeaveRegister { get; set; }
        public string cVoucherId { get; set; }
        public string cPsn_Num { get; set; }
        public string cDepCode { get; set; }
        public string cDepName { get; set; }
        public string cJobcode { get; set; }
        public string cJobName { get; set; }
        public string cDutycode { get; set; }
        public string dEnterDate { get; set; }
        public string dLeaveDate { get; set; }
        public string vLeaveClass { get; set; }
        public string vLeaveReason { get; set; }
        public string rEducation { get; set; }
        public string cContact { get; set; }
        public string cInterviewPerson1 { get; set; }
        public string cInterviewDept1 { get; set; }
        public string dInterviewDate1 { get; set; }
        public string cInterviewNote1 { get; set; }
        public string cInterviewPerson2 { get; set; }
        public string cInterviewDept2 { get; set; }
        public Nullable<System.DateTime> dInterviewDate2 { get; set; }
        public string cInterviewNote2 { get; set; }
        public string cInterviewPerson3 { get; set; }
        public string cInterviewDept3 { get; set; }
        public string dInterviewDate3 { get; set; }
        public string cInterviewNote3 { get; set; }
        public string cLeaveApplyForm { get; set; }
        public string cLeaveApplyRowNum { get; set; }
        public string cCreateBy { get; set; }
        public System.DateTime dCreateOn { get; set; }
        public string cAuditBy { get; set; }
        public Nullable<System.DateTime> dAuditOn { get; set; }
        public Nullable<bool> bAuditFlag { get; set; }
        public string cVoucherCode { get; set; }
        public bool bInFlow { get; set; }
        public byte[] tStamp { get; set; }
        public string csysbarcode { get; set; }
        public int iAuditTimes { get; set; }
        public string rPersonType { get; set; }
        public string rChgPersonType { get; set; }
    }
}
