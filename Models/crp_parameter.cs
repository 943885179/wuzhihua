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
    
    public partial class crp_parameter
    {
        public byte PType { get; set; }
        public Nullable<decimal> OverLoadPer { get; set; }
        public Nullable<decimal> LowLoadPer { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<int> ForecastVsId { get; set; }
        public Nullable<int> TbId { get; set; }
        public Nullable<int> PastDueDays { get; set; }
        public Nullable<byte> ResType { get; set; }
        public byte[] Ufts { get; set; }
        public Nullable<int> PlanCodeId { get; set; }
        public Nullable<int> DemandSource { get; set; }
        public Nullable<int> ResourceVsId { get; set; }
    }
}
