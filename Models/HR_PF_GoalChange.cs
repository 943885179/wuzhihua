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
    
    public partial class HR_PF_GoalChange
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HR_PF_GoalChange()
        {
            this.HR_PF_GoalChangeChild = new HashSet<HR_PF_GoalChangeChild>();
        }
    
        public string cGoalChangeCode { get; set; }
        public string cSummary { get; set; }
        public string cMakeFormPerson { get; set; }
        public System.DateTime dMakeFormDate { get; set; }
        public string cCheckPerson { get; set; }
        public string cCheckIdea { get; set; }
        public Nullable<System.DateTime> dCheckDate { get; set; }
        public byte[] tStamp { get; set; }
        public string cDefine1 { get; set; }
        public string cDefine2 { get; set; }
        public string cDefine3 { get; set; }
        public string cPlanCode { get; set; }
        public bool bControl { get; set; }
        public string cVoucherType { get; set; }
        public string cVoucherCode { get; set; }
        public string cStatus { get; set; }
        public short sVoucherState { get; set; }
        public short sCheckMainbody { get; set; }
        public string cSubmitPerson { get; set; }
        public Nullable<System.DateTime> dSubmitTime { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HR_PF_GoalChangeChild> HR_PF_GoalChangeChild { get; set; }
        public virtual HR_PF_Plan HR_PF_Plan { get; set; }
    }
}
