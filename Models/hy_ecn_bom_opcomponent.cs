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
    
    public partial class hy_ecn_bom_opcomponent
    {
        public long ID { get; set; }
        public long OpComponentId { get; set; }
        public long BomId { get; set; }
        public long SortSeq { get; set; }
        public string OpSeq { get; set; }
        public long ComponentId { get; set; }
        public Nullable<System.DateTime> EffBegDate { get; set; }
        public Nullable<System.DateTime> EffEndDate { get; set; }
        public Nullable<byte> FVFlag { get; set; }
        public Nullable<decimal> BaseQtyN { get; set; }
        public Nullable<decimal> BaseQtyD { get; set; }
        public Nullable<decimal> CompScrap { get; set; }
        public Nullable<bool> ByproductFlag { get; set; }
        public Nullable<long> OptionsId { get; set; }
        public string AuxUnitCode { get; set; }
        public Nullable<decimal> ChangeRate { get; set; }
        public Nullable<decimal> AuxBaseQtyN { get; set; }
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
        public Nullable<long> Define34 { get; set; }
        public Nullable<long> Define35 { get; set; }
        public Nullable<System.DateTime> Define36 { get; set; }
        public Nullable<System.DateTime> Define37 { get; set; }
        public string cCode { get; set; }
        public System.DateTime cDate { get; set; }
    }
}
