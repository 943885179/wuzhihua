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
    
    public partial class PP_PPCQuota
    {
        public int ID { get; set; }
        public int PPCIds { get; set; }
        public Nullable<decimal> fQuota { get; set; }
        public string cInvCode { get; set; }
        public Nullable<decimal> fQuantity { get; set; }
        public Nullable<decimal> fPoQuantity { get; set; }
        public string cPurchaser { get; set; }
        public string cVenCode { get; set; }
        public Nullable<decimal> iPrice { get; set; }
        public Nullable<decimal> iCost { get; set; }
        public string cExch_Name { get; set; }
        public Nullable<int> iInvAdvance { get; set; }
        public Nullable<System.DateTime> dPlanOrderDate { get; set; }
        public Nullable<bool> bDelayed { get; set; }
    }
}
