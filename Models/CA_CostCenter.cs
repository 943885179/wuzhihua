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
    
    public partial class CA_CostCenter
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CA_CostCenter()
        {
            this.CA_CostCenterMap = new HashSet<CA_CostCenterMap>();
        }
    
        public string cCode { get; set; }
        public string cName { get; set; }
        public string cDescription { get; set; }
        public string cProperty { get; set; }
        public Nullable<bool> bDept { get; set; }
        public int iPubExFZJL { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CA_CostCenterMap> CA_CostCenterMap { get; set; }
    }
}
