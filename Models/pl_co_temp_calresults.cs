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
    
    public partial class pl_co_temp_calresults
    {
        public int ID { get; set; }
        public int iMatId { get; set; }
        public bool ByProductFlag { get; set; }
        public Nullable<short> iQuanDifType { get; set; }
        public Nullable<decimal> quanDifQ { get; set; }
        public Nullable<decimal> quanDifLaborQ { get; set; }
        public Nullable<decimal> quanDifOmQ { get; set; }
        public Nullable<decimal> quanDifLQ { get; set; }
        public Nullable<decimal> fSemiLaborQuanDifLQ { get; set; }
        public Nullable<decimal> fSemiOmQuanDifLQ { get; set; }
        public Nullable<decimal> prcDifQ { get; set; }
        public Nullable<decimal> fLaborQuanDifLQ { get; set; }
        public Nullable<decimal> fLaborPriceDifLQ { get; set; }
        public Nullable<decimal> fOmCostDifLQ { get; set; }
        public Nullable<decimal> stdCostQ { get; set; }
        public Nullable<decimal> stdCostLaborQ { get; set; }
        public Nullable<decimal> stdCostOmQ { get; set; }
        public Nullable<decimal> stdQuanQS { get; set; }
        public Nullable<decimal> stdQuanQD { get; set; }
        public Nullable<decimal> stdCostO { get; set; }
        public Nullable<decimal> stdQuanOS { get; set; }
        public Nullable<decimal> fSetNumQ { get; set; }
        public Nullable<decimal> iRealUseQuan { get; set; }
        public Nullable<decimal> fRealUseStdCost { get; set; }
        public Nullable<decimal> fRealUseLbrStdCost { get; set; }
        public Nullable<decimal> fRealUseOmStdCost { get; set; }
    }
}
