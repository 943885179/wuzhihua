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
    
    public partial class bul_template
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public bul_template()
        {
            this.bul_type = new HashSet<bul_type>();
        }
    
        public long id { get; set; }
        public string template_name { get; set; }
        public bool usedFlag { get; set; }
        public string description { get; set; }
        public string template_format { get; set; }
        public string content { get; set; }
        public long create_user { get; set; }
        public System.DateTime create_date { get; set; }
        public Nullable<System.DateTime> update_date { get; set; }
        public Nullable<long> update_user { get; set; }
        public long accountId { get; set; }
        public string ext1 { get; set; }
        public string ext2 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bul_type> bul_type { get; set; }
    }
}
