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
    
    public partial class BG_Genre
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BG_Genre()
        {
            this.BG_Form = new HashSet<BG_Form>();
        }
    
        public string cGenreCode { get; set; }
        public string cGenreName { get; set; }
        public bool bEnd { get; set; }
        public short iSource { get; set; }
        public byte[] tStamp { get; set; }
        public int iMakeYear { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BG_Form> BG_Form { get; set; }
    }
}
