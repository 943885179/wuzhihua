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
    
    public partial class hy_scrapreport
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public hy_scrapreport()
        {
            this.hy_scrapreports = new HashSet<hy_scrapreports>();
        }
    
        public int id { get; set; }
        public string ccode { get; set; }
        public System.DateTime ddate { get; set; }
        public string cbustype { get; set; }
        public string cvencode { get; set; }
        public string cdepcode { get; set; }
        public string cpersoncode { get; set; }
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
        public int ivtid { get; set; }
        public byte[] ufts { get; set; }
        public string cmaker { get; set; }
        public string cmemo { get; set; }
        public string cVerifier { get; set; }
        public Nullable<System.DateTime> dnMaketime { get; set; }
        public Nullable<System.DateTime> dnModifytime { get; set; }
        public Nullable<System.DateTime> dnVerifytime { get; set; }
        public Nullable<System.DateTime> dVerifydate { get; set; }
        public Nullable<System.DateTime> dModifydate { get; set; }
        public string cModifier { get; set; }
        public Nullable<int> iverifystateex { get; set; }
        public Nullable<int> ireturncount { get; set; }
        public Nullable<bool> IsWfControlled { get; set; }
        public Nullable<int> iPrintCount { get; set; }
        public string cCleanVer { get; set; }
        public string cSysBarCode { get; set; }
        public string cCurrentAuditor { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hy_scrapreports> hy_scrapreports { get; set; }
    }
}
