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
    
    public partial class UA_CapitalProperty
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UA_CapitalProperty()
        {
            this.UA_CapitalBudgetPlan = new HashSet<UA_CapitalBudgetPlan>();
            this.UA_DebitItem = new HashSet<UA_DebitItem>();
            this.UA_SubVoucher = new HashSet<UA_SubVoucher>();
        }
    
        public string strCapitalPropertyID { get; set; }
        public string strCapitalPropertyName { get; set; }
        public string strCPParentID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UA_CapitalBudgetPlan> UA_CapitalBudgetPlan { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UA_DebitItem> UA_DebitItem { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UA_SubVoucher> UA_SubVoucher { get; set; }
    }
}
