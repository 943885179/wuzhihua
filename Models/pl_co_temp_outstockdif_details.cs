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
    
    public partial class pl_co_temp_outstockdif_details
    {
        public int Ia_AutoId { get; set; }
        public Nullable<int> ID { get; set; }
        public int iMatId { get; set; }
        public string cRdCode { get; set; }
        public string cWhCode { get; set; }
        public string cBusDepCode { get; set; }
        public decimal iNum { get; set; }
        public Nullable<decimal> fInvStdCost { get; set; }
        public Nullable<decimal> fLbrStdCost { get; set; }
        public Nullable<decimal> fOmStdCost { get; set; }
        public Nullable<decimal> quanDifLI { get; set; }
        public Nullable<decimal> prcDifI { get; set; }
        public Nullable<decimal> fLaborQuanDifLI { get; set; }
        public Nullable<decimal> fLaborPriceDifLI { get; set; }
        public Nullable<decimal> fOmCostDifLI { get; set; }
        public Nullable<decimal> fSemiLaborQuanDifLI { get; set; }
        public Nullable<decimal> fSemiOmQuanDifLI { get; set; }
    }
}
