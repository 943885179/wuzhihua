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
    
    public partial class mps_planorderdemand
    {
        public System.Guid PlanorderDId { get; set; }
        public int DemandId { get; set; }
        public Nullable<int> OpComponentId { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public Nullable<decimal> SubQty { get; set; }
        public Nullable<decimal> AllocateQty { get; set; }
        public Nullable<int> ProjectId { get; set; }
    }
}
