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
    
    public partial class HB_FirmSort_TreeVersions
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HB_FirmSort_TreeVersions()
        {
            this.HB_FirmSort_Entity = new HashSet<HB_FirmSort_Entity>();
        }
    
        public int VersionID { get; set; }
        public int SortId { get; set; }
        public byte[] TimeStamp { get; set; }
        public string DateUsedFrom { get; set; }
        public string DateUsedTo { get; set; }
    
        public virtual HB_FirmSort HB_FirmSort { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HB_FirmSort_Entity> HB_FirmSort_Entity { get; set; }
    }
}
