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
    
    public partial class BW_AlgoPlan
    {
        public int PlanId { get; set; }
        public Nullable<int> AlgoId { get; set; }
        public Nullable<int> AlgoClassId { get; set; }
        public Nullable<int> PeriodTypeId { get; set; }
        public Nullable<int> Period { get; set; }
        public Nullable<int> ComputeById { get; set; }
        public Nullable<int> SaleA { get; set; }
        public Nullable<int> SaleB { get; set; }
        public Nullable<int> SaleC { get; set; }
        public Nullable<decimal> ServiceA { get; set; }
        public Nullable<decimal> ServiceB { get; set; }
        public Nullable<decimal> ServiceC { get; set; }
        public Nullable<decimal> Service { get; set; }
        public Nullable<bool> IsDefault { get; set; }
    }
}
