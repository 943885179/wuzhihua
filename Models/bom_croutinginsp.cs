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
    
    public partial class bom_croutinginsp
    {
        public int CustRoutingInspId { get; set; }
        public Nullable<int> QtMethod { get; set; }
        public Nullable<short> DtMethod { get; set; }
        public Nullable<decimal> DtRate { get; set; }
        public Nullable<decimal> DtNum { get; set; }
        public Nullable<short> DtStyle { get; set; }
        public Nullable<int> QcProjectId { get; set; }
        public string AqlVal { get; set; }
        public Nullable<int> VTid { get; set; }
        public byte[] Ufts { get; set; }
        public Nullable<int> CustRoutingId { get; set; }
        public byte[] DtUnit { get; set; }
        public Nullable<short> QtLevel { get; set; }
        public string CruleCode { get; set; }
        public Nullable<byte> ItestRule { get; set; }
        public Nullable<byte> OpTransType { get; set; }
    }
}
