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
    
    public partial class pl_CO_InvStdPrice
    {
        public int autoid { get; set; }
        public string cInvCode { get; set; }
        public string CoVersion { get; set; }
        public Nullable<int> BomID { get; set; }
        public decimal fInvStdCost { get; set; }
        public decimal fLaborStdCost { get; set; }
        public decimal fManuCost { get; set; }
        public decimal fManuFixCost { get; set; }
        public decimal fManuVarCost { get; set; }
        public Nullable<decimal> fOmCost { get; set; }
        public decimal fManuFixCostB { get; set; }
        public decimal fLaborStdCostB { get; set; }
        public decimal fManuVarCostB { get; set; }
        public Nullable<decimal> fOmCostB { get; set; }
        public decimal fManuCostB { get; set; }
        public int iPartId { get; set; }
        public Nullable<int> iAddPeriod { get; set; }
        public Nullable<decimal> fInvRCost { get; set; }
    }
}
