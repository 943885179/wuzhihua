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
    
    public partial class ShippingChoice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ShippingChoice()
        {
            this.EnDispatch = new HashSet<EnDispatch>();
            this.PO_Pomain = new HashSet<PO_Pomain>();
            this.PU_ArrivalVouch = new HashSet<PU_ArrivalVouch>();
            this.SA_QuoMain = new HashSet<SA_QuoMain>();
            this.DispatchList = new HashSet<DispatchList>();
            this.SO_SOMain = new HashSet<SO_SOMain>();
        }
    
        public string cSCCode { get; set; }
        public string cSCName { get; set; }
        public byte[] pubufts { get; set; }
        public string cSCEnName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EnDispatch> EnDispatch { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PO_Pomain> PO_Pomain { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PU_ArrivalVouch> PU_ArrivalVouch { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SA_QuoMain> SA_QuoMain { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DispatchList> DispatchList { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SO_SOMain> SO_SOMain { get; set; }
    }
}
