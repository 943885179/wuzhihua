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
    
    public partial class hr_pages
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public hr_pages()
        {
            this.hr_pages_labels = new HashSet<hr_pages_labels>();
            this.hr_pages_properties = new HashSet<hr_pages_properties>();
            this.hr_properties_repositories = new HashSet<hr_properties_repositories>();
        }
    
        public long id { get; set; }
        public string page_name { get; set; }
        public byte page_no { get; set; }
        public byte page_display { get; set; }
        public string model_name { get; set; }
        public string memo { get; set; }
        public byte remove { get; set; }
        public Nullable<long> accountId { get; set; }
        public Nullable<byte> repair { get; set; }
        public byte sys_flag { get; set; }
        public int sort { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hr_pages_labels> hr_pages_labels { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hr_pages_properties> hr_pages_properties { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hr_properties_repositories> hr_properties_repositories { get; set; }
    }
}
