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
    
    public partial class pl_CO_bom_opcomponentopt
    {
        public int OptionsId { get; set; }
        public string COVersion { get; set; }
        public string COVersionDesc { get; set; }
        public Nullable<short> Offset { get; set; }
        public Nullable<byte> WIPType { get; set; }
        public Nullable<bool> AccuCostFlag { get; set; }
        public string DrawDeptCode { get; set; }
        public string Whcode { get; set; }
        public Nullable<bool> OptionalFlag { get; set; }
        public Nullable<byte> MutexRule { get; set; }
        public Nullable<decimal> PlanFactor { get; set; }
        public byte[] Ufts { get; set; }
    }
}
