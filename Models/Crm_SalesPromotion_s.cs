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
    
    public partial class Crm_SalesPromotion_s
    {
        public string OID { get; set; }
        public int AutoID { get; set; }
        public string cSaleProRecordID { get; set; }
        public string cSalesProActCode { get; set; }
        public string cRecommendProduct { get; set; }
        public string cProDescription { get; set; }
        public string cCusCode { get; set; }
        public string cRelatedProduct { get; set; }
        public Nullable<System.DateTime> dPurchaseDate { get; set; }
        public Nullable<double> iPurchaseAmount { get; set; }
        public Nullable<decimal> iPurchaseMoney { get; set; }
        public string cOperator { get; set; }
        public Nullable<System.DateTime> dOperateDate { get; set; }
        public byte[] ufts { get; set; }
    }
}
