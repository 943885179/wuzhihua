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
    
    public partial class HR_CT050
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HR_CT050()
        {
            this.HR_PF_JobRelation = new HashSet<HR_PF_JobRelation>();
            this.HR_PF_PlanWorkFlow = new HashSet<HR_PF_PlanWorkFlow>();
            this.HR_PF_TableTarget = new HashSet<HR_PF_TableTarget>();
        }
    
        public string ccodeID { get; set; }
        public string vdescription { get; set; }
        public string vsimpleName { get; set; }
        public string vsimpleSpell { get; set; }
        public Nullable<int> ilevels { get; set; }
        public string cpCodeID { get; set; }
        public Nullable<bool> bsysFlag { get; set; }
        public Nullable<bool> bChildFlag { get; set; }
        public Nullable<bool> bhideFlag { get; set; }
        public string vMemo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HR_PF_JobRelation> HR_PF_JobRelation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HR_PF_PlanWorkFlow> HR_PF_PlanWorkFlow { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HR_PF_TableTarget> HR_PF_TableTarget { get; set; }
    }
}
