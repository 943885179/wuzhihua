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
    
    public partial class rb_Roles
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public rb_Roles()
        {
            this.rb_Users = new HashSet<rb_Users>();
        }
    
        public int RoleID { get; set; }
        public int PortalID { get; set; }
        public string RoleName { get; set; }
        public Nullable<byte> Permission { get; set; }
    
        public virtual rb_Portals rb_Portals { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rb_Users> rb_Users { get; set; }
    }
}
