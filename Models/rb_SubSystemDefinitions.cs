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
    
    public partial class rb_SubSystemDefinitions
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public rb_SubSystemDefinitions()
        {
            this.rb_SubSystemSettings = new HashSet<rb_SubSystemSettings>();
        }
    
        public string cSystemID { get; set; }
        public string cSystemName { get; set; }
        public string cSystemVersion { get; set; }
        public string cAppServerName { get; set; }
        public string cAppServerPort { get; set; }
        public string cAppServerURL { get; set; }
        public string cLoginURL { get; set; }
        public bool bIsAvailable { get; set; }
        public string cDescription { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rb_SubSystemSettings> rb_SubSystemSettings { get; set; }
    }
}
