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
    
    public partial class bom_cbomcomp
    {
        public int CbomCompId { get; set; }
        public int CbomParentId { get; set; }
        public int ComponentId { get; set; }
        public int SortSeq { get; set; }
        public string OpSeq { get; set; }
        public Nullable<System.DateTime> EffBegDate { get; set; }
        public Nullable<System.DateTime> EffEndDate { get; set; }
        public Nullable<byte> FVFlag { get; set; }
        public Nullable<decimal> BaseQtyN { get; set; }
        public Nullable<decimal> BaseQtyD { get; set; }
        public Nullable<decimal> CompScrap { get; set; }
        public Nullable<bool> ByproductFlag { get; set; }
        public Nullable<int> OptionsId { get; set; }
        public string SeleFlag { get; set; }
        public Nullable<int> OpComponentId { get; set; }
        public Nullable<decimal> TotQty { get; set; }
        public Nullable<decimal> TotAuxQty { get; set; }
        public Nullable<decimal> AuxBaseQtyN { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public Nullable<decimal> AuxQty { get; set; }
        public string AuxUnitCode { get; set; }
        public Nullable<decimal> ChangeRate { get; set; }
        public Nullable<decimal> AuxBaseQtyN1 { get; set; }
        public Nullable<decimal> BaseQtyN1 { get; set; }
        public Nullable<decimal> BaseQtyD1 { get; set; }
        public Nullable<decimal> CompScrap1 { get; set; }
        public Nullable<int> Sequence { get; set; }
        public Nullable<byte> ProductType { get; set; }
        public string Define22 { get; set; }
        public string Define23 { get; set; }
        public string Define24 { get; set; }
        public string Define25 { get; set; }
        public Nullable<double> Define26 { get; set; }
        public Nullable<double> Define27 { get; set; }
        public string Define28 { get; set; }
        public string Define29 { get; set; }
        public string Define30 { get; set; }
        public string Define31 { get; set; }
        public string Define32 { get; set; }
        public string Define33 { get; set; }
        public Nullable<int> Define34 { get; set; }
        public Nullable<int> Define35 { get; set; }
        public Nullable<System.DateTime> Define36 { get; set; }
        public Nullable<System.DateTime> Define37 { get; set; }
        public string Remark { get; set; }
        public byte[] Ufts { get; set; }
        public Nullable<int> ancpart { get; set; }
        public Nullable<int> toppart { get; set; }
        public Nullable<int> ParentId { get; set; }
        public Nullable<bool> WIPTypeYn { get; set; }
        public Nullable<int> PSequence { get; set; }
        public string Free1 { get; set; }
        public string Free2 { get; set; }
        public string Free3 { get; set; }
        public string Free4 { get; set; }
        public string Free5 { get; set; }
        public string Free6 { get; set; }
        public string Free7 { get; set; }
        public string Free8 { get; set; }
        public string Free9 { get; set; }
        public string Free10 { get; set; }
    }
}
