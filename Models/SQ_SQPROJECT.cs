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
    
    public partial class SQ_SQPROJECT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SQ_SQPROJECT()
        {
            this.SQ_SQRESULTMAIN = new HashSet<SQ_SQRESULTMAIN>();
        }
    
        public string CPROJECTCODE { get; set; }
        public string CPROJECTEXPLAIN { get; set; }
        public string CMATERIELGETCOST1 { get; set; }
        public string CMATERIELGETCOST2 { get; set; }
        public string CMATERIELGETCOST3 { get; set; }
        public string CMACHINEFEETOCOST { get; set; }
        public string CENTRUSTFEEMETHOD { get; set; }
        public string CLABORFEEMETHOD { get; set; }
        public string CMACHINEFEEMETHOD { get; set; }
        public string CASSISFEEMETHOD { get; set; }
        public Nullable<double> FTAXRATE { get; set; }
        public Nullable<double> FPROFITMARGIN { get; set; }
        public string CEXCH_NAME { get; set; }
        public string CFIXDEFINE1 { get; set; }
        public string CFIXDEFINE2 { get; set; }
        public string CFIXDEFINE3 { get; set; }
        public string CFIXDEFINE4 { get; set; }
        public string CFIXDEFINE5 { get; set; }
        public string CFIXDEFINE6 { get; set; }
        public string CALTERDEFINE1 { get; set; }
        public string CALTERDEFINE2 { get; set; }
        public string CALTERDEFINE3 { get; set; }
        public string CALTERDEFINE4 { get; set; }
        public string CALTERDEFINE5 { get; set; }
        public string CALTERDEFINE6 { get; set; }
        public byte[] UFTS { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SQ_SQRESULTMAIN> SQ_SQRESULTMAIN { get; set; }
    }
}
