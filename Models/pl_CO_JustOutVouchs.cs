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
    
    public partial class pl_CO_JustOutVouchs
    {
        public int AutoID { get; set; }
        public Nullable<int> Ia_AutoId { get; set; }
        public string cJVCode { get; set; }
        public int iPartId { get; set; }
        public string cWhCode { get; set; }
        public string cRdCode { get; set; }
        public Nullable<decimal> fInvQuanDif { get; set; }
        public Nullable<decimal> fInvPriceDif { get; set; }
        public Nullable<decimal> fLaborQuanDif { get; set; }
        public Nullable<decimal> fLaborPriceDif { get; set; }
        public Nullable<decimal> fSemiLaborQuanDif { get; set; }
        public Nullable<decimal> fOmCostDif { get; set; }
        public Nullable<decimal> fSemiOmQuanDif { get; set; }
        public Nullable<decimal> fManuFixQuanDif { get; set; }
        public Nullable<decimal> fManuFixPriceDif { get; set; }
        public Nullable<decimal> fSemiManuFixQuanDif { get; set; }
        public Nullable<decimal> fManuVarQuanDif { get; set; }
        public Nullable<decimal> fManuVarPriceDif { get; set; }
        public Nullable<decimal> fSemiManuVarQuanDif { get; set; }
    }
}
