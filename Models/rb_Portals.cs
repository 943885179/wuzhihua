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
    
    public partial class rb_Portals
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public rb_Portals()
        {
            this.rb_PortalSettings = new HashSet<rb_PortalSettings>();
            this.rb_Roles = new HashSet<rb_Roles>();
            this.rb_Tabs = new HashSet<rb_Tabs>();
            this.rb_Users = new HashSet<rb_Users>();
        }
    
        public int PortalID { get; set; }
        public string PortalAlias { get; set; }
        public string PortalName { get; set; }
        public string PortalPath { get; set; }
        public bool AlwaysShowEditButton { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rb_PortalSettings> rb_PortalSettings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rb_Roles> rb_Roles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rb_Tabs> rb_Tabs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rb_Users> rb_Users { get; set; }
    }
}
