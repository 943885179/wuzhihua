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
    
    public partial class mps_atpdetail
    {
        public string guid { get; set; }
        public byte DemType { get; set; }
        public Nullable<bool> ExternalFlag { get; set; }
        public byte SoType { get; set; }
        public string SoCode { get; set; }
        public string SoDId { get; set; }
        public Nullable<int> SoSeq { get; set; }
        public string DocCode { get; set; }
        public Nullable<int> DocSeq { get; set; }
        public Nullable<int> DocDId { get; set; }
        public Nullable<int> PartId { get; set; }
        public string InvCode { get; set; }
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
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public Nullable<decimal> BalQty { get; set; }
        public Nullable<bool> AtpYn { get; set; }
        public Nullable<decimal> ReserveQty { get; set; }
    }
}
