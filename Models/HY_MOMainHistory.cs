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
    
    public partial class HY_MOMainHistory
    {
        public int ID { get; set; }
        public string cCode { get; set; }
        public System.DateTime dDate { get; set; }
        public string cVenCode { get; set; }
        public string cDepCode { get; set; }
        public string cPersonCode { get; set; }
        public string cArrivalPlace { get; set; }
        public string cSCCode { get; set; }
        public string cexch_name { get; set; }
        public Nullable<decimal> nflat { get; set; }
        public Nullable<double> iTaxRate { get; set; }
        public string cPayCode { get; set; }
        public Nullable<decimal> iCost { get; set; }
        public Nullable<decimal> iBargain { get; set; }
        public string cMemo { get; set; }
        public string cMaker { get; set; }
        public string cVerifier { get; set; }
        public string cCloser { get; set; }
        public string cDefine1 { get; set; }
        public string cDefine2 { get; set; }
        public string cDefine3 { get; set; }
        public Nullable<System.DateTime> cDefine4 { get; set; }
        public Nullable<int> cDefine5 { get; set; }
        public Nullable<System.DateTime> cDefine6 { get; set; }
        public Nullable<double> cDefine7 { get; set; }
        public string cDefine8 { get; set; }
        public string cDefine9 { get; set; }
        public string cDefine10 { get; set; }
        public int iVTid { get; set; }
        public byte[] ufts { get; set; }
        public string cBusType { get; set; }
        public string cDefine11 { get; set; }
        public string cDefine12 { get; set; }
        public string cDefine13 { get; set; }
        public string cDefine14 { get; set; }
        public Nullable<int> cDefine15 { get; set; }
        public Nullable<double> cDefine16 { get; set; }
        public byte cState { get; set; }
        public Nullable<byte> VoucherType { get; set; }
        public string cChanger { get; set; }
        public Nullable<System.DateTime> dnMaketime { get; set; }
        public Nullable<System.DateTime> dnModifytime { get; set; }
        public Nullable<System.DateTime> dnVerifytime { get; set; }
        public Nullable<System.DateTime> dVerifydate { get; set; }
        public Nullable<System.DateTime> dModifydate { get; set; }
        public string cModifier { get; set; }
        public Nullable<int> iverifystateex { get; set; }
        public Nullable<int> ireturncount { get; set; }
        public Nullable<bool> IsWfControlled { get; set; }
        public long HistoryId { get; set; }
        public Nullable<byte> VariationAction { get; set; }
        public int VariationLogId { get; set; }
        public Nullable<byte> SubVariationAction { get; set; }
    }
}
