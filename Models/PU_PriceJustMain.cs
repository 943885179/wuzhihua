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
    
    public partial class PU_PriceJustMain
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PU_PriceJustMain()
        {
            this.PU_PriceJustDetail = new HashSet<PU_PriceJustDetail>();
        }
    
        public long id { get; set; }
        public Nullable<System.DateTime> ddate { get; set; }
        public string ccode { get; set; }
        public string cmaker { get; set; }
        public string cpersoncode { get; set; }
        public string cmainmemo { get; set; }
        public string cverifier { get; set; }
        public Nullable<System.DateTime> dverifydate { get; set; }
        public string cdepcode { get; set; }
        public Nullable<long> ivtid { get; set; }
        public string cdefine1 { get; set; }
        public string cdefine2 { get; set; }
        public string cdefine3 { get; set; }
        public Nullable<System.DateTime> cdefine4 { get; set; }
        public Nullable<int> cdefine5 { get; set; }
        public Nullable<System.DateTime> cdefine6 { get; set; }
        public Nullable<double> cdefine7 { get; set; }
        public string cdefine8 { get; set; }
        public string cdefine9 { get; set; }
        public string cdefine10 { get; set; }
        public string cdefine11 { get; set; }
        public string cdefine12 { get; set; }
        public string cdefine13 { get; set; }
        public string cdefine14 { get; set; }
        public Nullable<int> cdefine15 { get; set; }
        public Nullable<double> cdefine16 { get; set; }
        public byte[] ufts { get; set; }
        public Nullable<int> iverifystate { get; set; }
        public Nullable<byte> ireturncount { get; set; }
        public Nullable<bool> iswfcontrolled { get; set; }
        public Nullable<int> bTaxCost { get; set; }
        public Nullable<int> iSupplyType { get; set; }
        public Nullable<System.DateTime> cMakeTime { get; set; }
        public Nullable<System.DateTime> cModifyTime { get; set; }
        public Nullable<System.DateTime> cAuditTime { get; set; }
        public Nullable<System.DateTime> cModifyDate { get; set; }
        public string cReviser { get; set; }
        public Nullable<int> iPrintCount { get; set; }
        public string ccleanver { get; set; }
        public string csysbarcode { get; set; }
        public string cCurrentAuditor { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PU_PriceJustDetail> PU_PriceJustDetail { get; set; }
    }
}
