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
    
    public partial class eb_accountstatement
    {
        public long oid { get; set; }
        public Nullable<long> cshopid { get; set; }
        public string calipayno { get; set; }
        public string ctrastypename { get; set; }
        public string cbussinesstypename { get; set; }
        public string cbussinessno { get; set; }
        public string ctradingfloorname { get; set; }
        public string ctransactionchannel { get; set; }
        public string tid { get; set; }
        public Nullable<System.DateTime> dendtime { get; set; }
        public string cbuyeralipayno { get; set; }
        public string citemname { get; set; }
        public string cfeeitem { get; set; }
        public Nullable<decimal> decreceivedpayment { get; set; }
        public Nullable<decimal> decexpendpayment { get; set; }
        public Nullable<decimal> decbalance { get; set; }
        public string cblender { get; set; }
        public Nullable<System.DateTime> dblendtime { get; set; }
        public string memo { get; set; }
        public string capbillcode { get; set; }
        public byte[] ufts { get; set; }
        public Nullable<bool> bhandadd { get; set; }
        public string cFinancialNo { get; set; }
        public string cBlendGUID { get; set; }
        public Nullable<System.DateTime> createtime { get; set; }
        public Nullable<bool> bsingleblend { get; set; }
    }
}
