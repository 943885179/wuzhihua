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
    
    public partial class pl_CO_MOOpCosts
    {
        public int AutoId { get; set; }
        public Nullable<int> ID { get; set; }
        public Nullable<int> iperiod { get; set; }
        public Nullable<int> Modid { get; set; }
        public string OpSeq { get; set; }
        public Nullable<int> OperationId { get; set; }
        public Nullable<int> Wcid { get; set; }
        public Nullable<int> MoRoutingDId { get; set; }
        public Nullable<int> cAmoId { get; set; }
        public Nullable<double> fStWr { get; set; }
        public Nullable<double> fRlWr { get; set; }
        public Nullable<decimal> fManuFixStCost { get; set; }
        public Nullable<decimal> fManuFixRlCost { get; set; }
        public Nullable<decimal> fManuVarStCost { get; set; }
        public Nullable<decimal> fManuVarRlCost { get; set; }
        public Nullable<decimal> fLaborStCost { get; set; }
        public Nullable<decimal> fLaborRlCost { get; set; }
    }
}
