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
    
    public partial class hr_om_job
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public hr_om_job()
        {
            this.HR_PF_JobRelation = new HashSet<HR_PF_JobRelation>();
        }
    
        public string cJobcode { get; set; }
        public string vjobname { get; set; }
        public string cDepCode { get; set; }
        public string cDutycode { get; set; }
        public Nullable<bool> bdeptrespon { get; set; }
        public string vsuporior { get; set; }
        public string dbuilddate { get; set; }
        public Nullable<bool> bisAbort { get; set; }
        public string dabortdate { get; set; }
        public string rjobseries { get; set; }
        public string rjobrank { get; set; }
        public string vworksumm { get; set; }
        public byte[] hrts { get; set; }
        public System.Guid pk_hr_om_job { get; set; }
        public bool bKeyJob { get; set; }
        public string vJobAim { get; set; }
        public string vJobRequire { get; set; }
        public string vJobPlace { get; set; }
        public string vJobCondition { get; set; }
        public Nullable<bool> bControlTerm { get; set; }
        public Nullable<int> iMaxTerm { get; set; }
        public string vJobNameEn { get; set; }
        public string cJobRankClassCode { get; set; }
        public string cJobRankBegin { get; set; }
        public string cJobRankEnd { get; set; }
        public string cJobGradeBegin { get; set; }
        public string cJobGradeEnd { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HR_PF_JobRelation> HR_PF_JobRelation { get; set; }
    }
}
