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
    
    public partial class QMCHECKTEMPLET
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QMCHECKTEMPLET()
        {
            this.QMCHECKPROJECTS = new HashSet<QMCHECKPROJECTS>();
            this.QMCHECKVOUCHERS = new HashSet<QMCHECKVOUCHERS>();
        }
    
        public System.Guid CHKTEMPGUID { get; set; }
        public string CCHKTEMPCODE { get; set; }
        public string CCHKTEMPNAME { get; set; }
        public string CCHKTEMPADDCODE { get; set; }
        public string CCHKTEMPVERSION { get; set; }
        public string CCHKTEMPSOURCE { get; set; }
        public string CMEMO { get; set; }
        public byte[] UFTS { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QMCHECKPROJECTS> QMCHECKPROJECTS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QMCHECKVOUCHERS> QMCHECKVOUCHERS { get; set; }
    }
}
