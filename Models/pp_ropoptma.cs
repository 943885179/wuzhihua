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
    
    public partial class pp_ropoptma
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public pp_ropoptma()
        {
            this.pp_ropoptde = new HashSet<pp_ropoptde>();
        }
    
        public int ropoptid { get; set; }
        public string optcode { get; set; }
        public string optname { get; set; }
        public int bdefault { get; set; }
        public int ihisdays { get; set; }
        public int brfreez { get; set; }
        public int bruncha { get; set; }
        public int brunchp { get; set; }
        public int brdelay { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<pp_ropoptde> pp_ropoptde { get; set; }
    }
}
