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
    
    public partial class sfc_proutingdreshistory
    {
        public long HistoryId { get; set; }
        public Nullable<byte> VariationAction { get; set; }
        public Nullable<int> VariationLogId { get; set; }
        public Nullable<int> HistorySeq { get; set; }
        public Nullable<byte> HistoryMode { get; set; }
        public int PRoutingResId { get; set; }
        public int PRoutingDId { get; set; }
        public int ResSeq { get; set; }
        public Nullable<int> ResId { get; set; }
        public Nullable<byte> BaseType { get; set; }
        public Nullable<decimal> BaseQtyN { get; set; }
        public Nullable<decimal> BaseQtyD { get; set; }
        public Nullable<byte> PlanFlag { get; set; }
        public string ResActivity { get; set; }
        public Nullable<int> VTid { get; set; }
        public Nullable<decimal> ResQty { get; set; }
        public Nullable<decimal> EffRate { get; set; }
        public Nullable<byte> FeeType { get; set; }
    }
}
