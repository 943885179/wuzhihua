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
    
    public partial class pl_CO_bom_parent
    {
        public int AutoId { get; set; }
        public int BomId { get; set; }
        public int ParentId { get; set; }
        public Nullable<decimal> ParentScrap { get; set; }
        public Nullable<int> SharingPartId { get; set; }
        public byte[] Ufts { get; set; }
        public string COVersion { get; set; }
        public string COVersionDesc { get; set; }
        public bool bAddFlag { get; set; }
        public decimal fInvStdCost { get; set; }
        public decimal fLaborStdCost { get; set; }
        public decimal fManuCost { get; set; }
        public decimal fManuFixCost { get; set; }
        public decimal fManuVarCost { get; set; }
        public double fStLaborWh { get; set; }
        public double fStManuWh { get; set; }
        public double fStWhB { get; set; }
        public decimal fLaborStdCostB { get; set; }
        public decimal fManuFixCostB { get; set; }
        public decimal fManuVarCostB { get; set; }
        public decimal fOmCostB { get; set; }
        public decimal fOmCost { get; set; }
        public Nullable<System.DateTime> dAddDate { get; set; }
    }
}
