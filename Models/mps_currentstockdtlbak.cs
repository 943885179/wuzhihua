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
    
    public partial class mps_currentstockdtlbak
    {
        public int PartId { get; set; }
        public string InvCode { get; set; }
        public Nullable<decimal> Onhand { get; set; }
        public Nullable<decimal> OutQty { get; set; }
        public Nullable<decimal> InQty { get; set; }
        public Nullable<decimal> TransOutQty { get; set; }
        public Nullable<decimal> TransInQty { get; set; }
        public Nullable<decimal> StopQty { get; set; }
        public byte SoType { get; set; }
        public Nullable<int> SoId { get; set; }
        public string SoDId { get; set; }
        public int ProjectId { get; set; }
        public Nullable<decimal> InspQty { get; set; }
        public Nullable<int> SoSeq { get; set; }
        public string SoCode { get; set; }
        public string DemandCode { get; set; }
        public Nullable<decimal> PendingInQty { get; set; }
        public Nullable<decimal> PendingOutQty { get; set; }
    }
}
