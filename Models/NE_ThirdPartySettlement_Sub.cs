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
    
    public partial class NE_ThirdPartySettlement_Sub
    {
        public System.Guid ID { get; set; }
        public System.Guid SettlementID { get; set; }
        public string OrderID { get; set; }
        public string AccountID { get; set; }
        public string OrderType { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<System.DateTime> Time { get; set; }
        public string PaymentType { get; set; }
        public string Description { get; set; }
        public byte[] ts { get; set; }
    }
}
