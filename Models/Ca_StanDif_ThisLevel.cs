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
    
    public partial class Ca_StanDif_ThisLevel
    {
        public string cVerID { get; set; }
        public int iPeriod { get; set; }
        public string cDeptID { get; set; }
        public int cPPID { get; set; }
        public string cBatch { get; set; }
        public int cAmoType { get; set; }
        public string cAmoID { get; set; }
        public string cAmoName { get; set; }
        public Nullable<decimal> RealFinCount { get; set; }
        public Nullable<decimal> RealUnitPrice { get; set; }
        public Nullable<decimal> RealQua { get; set; }
        public Nullable<decimal> RealAmo { get; set; }
        public Nullable<decimal> StanFinCount { get; set; }
        public Nullable<decimal> StanUnitPrice { get; set; }
        public Nullable<decimal> StanQua { get; set; }
        public Nullable<decimal> StanAmo { get; set; }
        public Nullable<decimal> QuaDif { get; set; }
        public Nullable<decimal> PrcDif { get; set; }
        public Nullable<decimal> CostDif { get; set; }
    }
}
