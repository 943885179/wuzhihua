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
    
    public partial class pl_co_LBrManaDif_bakAdjust
    {
        public long ID { get; set; }
        public Nullable<int> iPeriod { get; set; }
        public string cInvCode { get; set; }
        public Nullable<int> cAmoID { get; set; }
        public Nullable<int> iAttribute { get; set; }
        public Nullable<decimal> QuanDif { get; set; }
        public Nullable<decimal> PrcDif { get; set; }
        public Nullable<decimal> prcAdjustRate { get; set; }
        public Nullable<decimal> QuanAdjustRate { get; set; }
        public Nullable<bool> bPurchase { get; set; }
        public Nullable<bool> bSelf { get; set; }
        public Nullable<bool> bProxyForeign { get; set; }
        public Nullable<decimal> AdjQuanDif { get; set; }
        public Nullable<decimal> AdjPrcDif { get; set; }
    }
}
