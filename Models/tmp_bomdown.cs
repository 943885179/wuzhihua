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
    
    public partial class tmp_bomdown
    {
        public int Spid { get; set; }
        public string OpSeq { get; set; }
        public Nullable<int> PartId { get; set; }
        public Nullable<System.DateTime> EffBegDate { get; set; }
        public Nullable<decimal> ParentScrap { get; set; }
        public Nullable<decimal> CompScrap { get; set; }
        public Nullable<decimal> BaseQtyN { get; set; }
        public Nullable<decimal> BaseQtyD { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public Nullable<bool> ByproductFlag { get; set; }
        public Nullable<byte> WIPType { get; set; }
        public string WhCode { get; set; }
        public Nullable<System.DateTime> StartDemDate { get; set; }
        public Nullable<System.DateTime> EndDemDate { get; set; }
        public Nullable<short> Level { get; set; }
        public Nullable<byte> FVFlag { get; set; }
        public Nullable<int> OpComponentId { get; set; }
        public Nullable<short> OffSet { get; set; }
        public string AuxUnitCode { get; set; }
        public Nullable<decimal> ChangeRate { get; set; }
        public Nullable<decimal> AuxBaseQtyN { get; set; }
        public Nullable<decimal> AuxQty { get; set; }
    }
}
