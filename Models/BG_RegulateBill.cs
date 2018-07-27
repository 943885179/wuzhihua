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
    
    public partial class BG_RegulateBill
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BG_RegulateBill()
        {
            this.BG_RegulateBills = new HashSet<BG_RegulateBills>();
            this.BG_RegulateEffect = new HashSet<BG_RegulateEffect>();
        }
    
        public string cBillCode { get; set; }
        public System.DateTime dRegulateDate { get; set; }
        public string cFormCode { get; set; }
        public string cOrganCode { get; set; }
        public string cVersionCode { get; set; }
        public string cOrganizer { get; set; }
        public string cSubmit { get; set; }
        public string cAuditor { get; set; }
        public string cAuditOpinion { get; set; }
        public Nullable<short> iType { get; set; }
        public Nullable<short> iState { get; set; }
        public string cGroupBillCode { get; set; }
        public string cUpOrganCode { get; set; }
        public byte[] tStamp { get; set; }
        public Nullable<decimal> fMaxDiff { get; set; }
        public Nullable<decimal> fMaxScale { get; set; }
        public int iMakeYear { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BG_RegulateBills> BG_RegulateBills { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BG_RegulateEffect> BG_RegulateEffect { get; set; }
        public virtual BG_Version BG_Version { get; set; }
    }
}
