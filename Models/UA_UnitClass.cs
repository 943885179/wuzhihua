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
    
    public partial class UA_UnitClass
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UA_UnitClass()
        {
            this.UA_DebitItem = new HashSet<UA_DebitItem>();
            this.UA_IncExpItem = new HashSet<UA_IncExpItem>();
            this.UA_UnitDef = new HashSet<UA_UnitDef>();
        }
    
        public string strUnitClassID { get; set; }
        public string strUnitClassName { get; set; }
        public string strParentKey { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UA_DebitItem> UA_DebitItem { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UA_IncExpItem> UA_IncExpItem { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UA_UnitDef> UA_UnitDef { get; set; }
    }
}
