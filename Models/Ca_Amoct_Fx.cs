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
    
    public partial class Ca_Amoct_Fx
    {
        public int iPeriod { get; set; }
        public Nullable<int> id { get; set; }
        public int cPPid { get; set; }
        public string cBatch { get; set; }
        public int cAmotype { get; set; }
        public string cAmoID { get; set; }
        public int ifxDid { get; set; }
        public Nullable<decimal> iQua { get; set; }
        public Nullable<decimal> iTotalAmo { get; set; }
        public Nullable<decimal> iOnpTotalAmo { get; set; }
        public Nullable<double> iFinPdtUnitAmo { get; set; }
        public Nullable<decimal> OnpRation { get; set; }
        public Nullable<decimal> iFinQua { get; set; }
        public Nullable<decimal> lastperiodQua { get; set; }
        public Nullable<decimal> lastperiodAmo { get; set; }
        public Nullable<decimal> iOnpLineAmo { get; set; }
        public bool bQc { get; set; }
        public decimal iPrivateAmo { get; set; }
        public decimal iComAmo { get; set; }
        public decimal iAdjAmo { get; set; }
    }
}
