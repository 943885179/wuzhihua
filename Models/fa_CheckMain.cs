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
    
    public partial class fa_CheckMain
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public fa_CheckMain()
        {
            this.fa_CheckData = new HashSet<fa_CheckData>();
            this.fa_CheckSetup = new HashSet<fa_CheckSetup>();
        }
    
        public string sNum { get; set; }
        public System.DateTime dCheckDate { get; set; }
        public byte iCheckMode { get; set; }
        public string sCheckRange { get; set; }
        public string sOperator { get; set; }
        public Nullable<bool> bStart { get; set; }
        public Nullable<bool> bClose { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<fa_CheckData> fa_CheckData { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<fa_CheckSetup> fa_CheckSetup { get; set; }
    }
}
