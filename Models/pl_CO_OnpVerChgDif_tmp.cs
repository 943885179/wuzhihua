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
    
    public partial class pl_CO_OnpVerChgDif_tmp
    {
        public int BomID { get; set; }
        public string OldVersion { get; set; }
        public string NewVersion { get; set; }
        public int iVouchType { get; set; }
        public int iRealCoId { get; set; }
        public int LastID { get; set; }
        public Nullable<decimal> fQuanQ { get; set; }
        public Nullable<decimal> fQuanQ_mat { get; set; }
        public Nullable<decimal> fQuanQ_lbr { get; set; }
        public Nullable<decimal> fQuanQ_mau { get; set; }
        public Nullable<decimal> fInvStdCostChg { get; set; }
        public Nullable<decimal> fInvQuanDifChg { get; set; }
        public Nullable<decimal> fInvPriceDifChg { get; set; }
        public Nullable<decimal> fLaborStdCostChg { get; set; }
        public Nullable<decimal> fLaborQuanDifChg { get; set; }
        public Nullable<decimal> fLaborPriceDifChg { get; set; }
        public Nullable<decimal> fSemiLaborQuanDifChg { get; set; }
        public Nullable<decimal> fManuFixStdCostChg { get; set; }
        public Nullable<decimal> fManuFixQuanDifChg { get; set; }
        public Nullable<decimal> fManuFixPriceDifChg { get; set; }
        public Nullable<decimal> fSemiManuFixQuanDifChg { get; set; }
        public Nullable<decimal> fManuVarStdCostChg { get; set; }
        public Nullable<decimal> fManuVarQuanDifChg { get; set; }
        public Nullable<decimal> fManuVarPriceDifChg { get; set; }
        public Nullable<decimal> fSemiManuVarQuanDifChg { get; set; }
        public Nullable<decimal> fOmStdCostChg { get; set; }
        public Nullable<decimal> fOmQuanDifChg { get; set; }
        public Nullable<decimal> fSemiOmQuanDifChg { get; set; }
    }
}
