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
    
    public partial class rss_category
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public rss_category()
        {
            this.rss_category_channel = new HashSet<rss_category_channel>();
        }
    
        public long id { get; set; }
        public string name { get; set; }
        public Nullable<int> order_num { get; set; }
        public Nullable<long> create_user_id { get; set; }
        public System.DateTime create_date { get; set; }
        public Nullable<long> last_user_id { get; set; }
        public System.DateTime last_update { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rss_category_channel> rss_category_channel { get; set; }
    }
}
