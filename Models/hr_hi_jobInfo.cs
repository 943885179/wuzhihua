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
    
    public partial class hr_hi_jobInfo
    {
        public System.Guid PK_hr_hi_jobInfo { get; set; }
        public string cPsn_Num { get; set; }
        public Nullable<int> iRecordID { get; set; }
        public Nullable<bool> blastflag { get; set; }
        public string vstatus1 { get; set; }
        public Nullable<decimal> nstatus2 { get; set; }
        public string rDChgType { get; set; }
        public string cDepCode { get; set; }
        public string cjobcode { get; set; }
        public string cDutycode { get; set; }
        public string rDutyLev { get; set; }
        public string rholdpostWay { get; set; }
        public string rhpreason { get; set; }
        public string vhpAuthUnit { get; set; }
        public string vAuthorizeDoc { get; set; }
        public string dbegindate { get; set; }
        public string denddate { get; set; }
        public string dremovDate { get; set; }
        public string rremovMode { get; set; }
        public string rremovReason { get; set; }
        public string vrmAuthUnit { get; set; }
        public string vrmAuthDoc { get; set; }
        public string cSupPerson { get; set; }
        public bool bPartJob { get; set; }
        public byte[] hrts { get; set; }
        public string JobNumber { get; set; }
        public string cDeptName { get; set; }
        public string cJobName { get; set; }
        public string cDutyName { get; set; }
        public string cJobRankCode { get; set; }
        public string cJobGradeCode { get; set; }
        public Nullable<bool> bMaxJobRankCode { get; set; }
        public string cVoucherId { get; set; }
    }
}
