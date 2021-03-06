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
    
    public partial class PP_ROPDetails
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PP_ROPDetails()
        {
            this.PP_ROPQuota = new HashSet<PP_ROPQuota>();
        }
    
        public int DUID { get; set; }
        public Nullable<int> MUID { get; set; }
        public string cInvCode { get; set; }
        public Nullable<double> fAvaQuantity { get; set; }
        public Nullable<double> fROPQuantity { get; set; }
        public Nullable<double> fPlanQuantity { get; set; }
        public Nullable<double> fCheckQuantity { get; set; }
        public Nullable<int> iBatchRules { get; set; }
        public Nullable<double> fInvBatch { get; set; }
        public Nullable<double> fHInv { get; set; }
        public Nullable<double> fSafeInv { get; set; }
        public Nullable<double> fHisInv { get; set; }
        public Nullable<int> iHisDays { get; set; }
        public Nullable<int> iAssureDays { get; set; }
        public Nullable<bool> bQuota { get; set; }
        public Nullable<int> iDataFrom { get; set; }
        public Nullable<int> irowno { get; set; }
        public string cbsysbarcode { get; set; }
    
        public virtual PP_ROPMain PP_ROPMain { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PP_ROPQuota> PP_ROPQuota { get; set; }
    }
}
