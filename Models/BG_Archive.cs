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
    
    public partial class BG_Archive
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BG_Archive()
        {
            this.BG_ArchiveData = new HashSet<BG_ArchiveData>();
            this.BG_ArchiveColumn = new HashSet<BG_ArchiveColumn>();
            this.BG_ArchiveColumnData = new HashSet<BG_ArchiveColumnData>();
        }
    
        public string cKey { get; set; }
        public string cName { get; set; }
        public string cSortKey { get; set; }
        public short iSource { get; set; }
        public byte[] cTimeStamp { get; set; }
        public int iMakeYear { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BG_ArchiveData> BG_ArchiveData { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BG_ArchiveColumn> BG_ArchiveColumn { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BG_ArchiveColumnData> BG_ArchiveColumnData { get; set; }
    }
}
