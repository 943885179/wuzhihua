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
    
    public partial class Ar_VouchsHistory
    {
        public int Auto_ID { get; set; }
        public string cLink { get; set; }
        public string cDwCode { get; set; }
        public string cDeptCode { get; set; }
        public string cPerson { get; set; }
        public string cItem_Class { get; set; }
        public string cItemCode { get; set; }
        public string cDigest { get; set; }
        public string cCode { get; set; }
        public string cexch_name { get; set; }
        public Nullable<double> iExchRate { get; set; }
        public Nullable<bool> bd_c { get; set; }
        public Nullable<decimal> iAmount { get; set; }
        public Nullable<decimal> iAmount_f { get; set; }
        public string cItemName { get; set; }
        public Nullable<double> iAmt_s { get; set; }
        public string cExpCode { get; set; }
        public Nullable<double> iTaxRate { get; set; }
        public Nullable<decimal> iTax { get; set; }
        public Nullable<decimal> iNatTax { get; set; }
        public string cDefine22 { get; set; }
        public string cDefine23 { get; set; }
        public string cDefine24 { get; set; }
        public string cDefine25 { get; set; }
        public Nullable<double> cDefine26 { get; set; }
        public Nullable<double> cDefine27 { get; set; }
        public string cDefine28 { get; set; }
        public string cDefine29 { get; set; }
        public string cDefine30 { get; set; }
        public string cDefine31 { get; set; }
        public string cDefine32 { get; set; }
        public string cDefine33 { get; set; }
        public Nullable<int> cDefine34 { get; set; }
        public Nullable<int> cDefine35 { get; set; }
        public Nullable<System.DateTime> cDefine36 { get; set; }
        public Nullable<System.DateTime> cDefine37 { get; set; }
        public long HistoryId { get; set; }
        public Nullable<byte> VariationAction { get; set; }
        public int VariationLogId { get; set; }
        public Nullable<byte> SubVariationAction { get; set; }
    }
}
