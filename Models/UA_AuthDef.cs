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
    
    public partial class UA_AuthDef
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UA_AuthDef()
        {
            this.UA_AuthDefUnit = new HashSet<UA_AuthDefUnit>();
        }
    
        public string strPersonID { get; set; }
        public string strPersonName { get; set; }
        public string strDuty { get; set; }
        public string strPassword { get; set; }
        public double dblValue { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UA_AuthDefUnit> UA_AuthDefUnit { get; set; }
    }
}
