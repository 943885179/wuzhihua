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
    
    public partial class EB_Switch_Trade
    {
        public long iAutoID { get; set; }
        public long iShopID { get; set; }
        public string cTradeID { get; set; }
        public System.DateTime dCreated { get; set; }
        public System.DateTime dModified { get; set; }
        public string cBuyerNick { get; set; }
        public string cStatus { get; set; }
        public string cType { get; set; }
        public string cCodStatus { get; set; }
        public string tXmlTrade { get; set; }
        public string cHandler { get; set; }
    }
}
