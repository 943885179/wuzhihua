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
    
    public partial class BG_CtrlAccount
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BG_CtrlAccount()
        {
            this.BG_CtrlAccount_Detail = new HashSet<BG_CtrlAccount_Detail>();
            this.BG_CtrlContradistinguish_Master = new HashSet<BG_CtrlContradistinguish_Master>();
            this.BG_CtrlRuleObjectsDetail = new HashSet<BG_CtrlRuleObjectsDetail>();
            this.BG_SubjectContradistinguish_Master = new HashSet<BG_SubjectContradistinguish_Master>();
        }
    
        public System.Guid cAccountID { get; set; }
        public string cServerCode { get; set; }
        public string cDataSource { get; set; }
        public string cUserName { get; set; }
        public string cUserPassword { get; set; }
        public byte[] tStamp { get; set; }
        public string cConnString { get; set; }
        public bool IsGroupVer { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BG_CtrlAccount_Detail> BG_CtrlAccount_Detail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BG_CtrlContradistinguish_Master> BG_CtrlContradistinguish_Master { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BG_CtrlRuleObjectsDetail> BG_CtrlRuleObjectsDetail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BG_SubjectContradistinguish_Master> BG_SubjectContradistinguish_Master { get; set; }
    }
}
