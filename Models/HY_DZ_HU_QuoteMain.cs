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
    
    public partial class HY_DZ_HU_QuoteMain
    {
        public long ID { get; set; }
        public string cCode { get; set; }
        public string PlanID { get; set; }
        public string cHandler { get; set; }
        public string cexch_code { get; set; }
        public Nullable<decimal> nflat { get; set; }
        public Nullable<decimal> iTaxRate { get; set; }
        public string cmaker { get; set; }
        public string cVerifier { get; set; }
        public Nullable<System.DateTime> MakeDate { get; set; }
        public Nullable<System.DateTime> VerifyDate { get; set; }
        public System.DateTime dDate { get; set; }
        public int btaxcost { get; set; }
        public string iSupplyType { get; set; }
        public string cMemo { get; set; }
        public byte cState { get; set; }
        public byte cFlag { get; set; }
        public byte[] ufts { get; set; }
        public short iswfcontrolled { get; set; }
        public short ireturncount { get; set; }
        public short iverifystate { get; set; }
        public Nullable<System.DateTime> cHandleDate { get; set; }
        public short iverifystateex { get; set; }
        public string Transfer { get; set; }
        public string cverfier { get; set; }
        public string PUType { get; set; }
        public string cPTCode { get; set; }
        public string cdefine1 { get; set; }
        public string cdefine2 { get; set; }
        public string cdefine3 { get; set; }
        public Nullable<System.DateTime> cdefine4 { get; set; }
        public Nullable<int> cdefine5 { get; set; }
        public Nullable<System.DateTime> cdefine6 { get; set; }
        public Nullable<double> cdefine7 { get; set; }
        public string cdefine8 { get; set; }
        public string cdefine9 { get; set; }
        public string cdefine10 { get; set; }
        public string cdefine11 { get; set; }
        public string cdefine12 { get; set; }
        public string cdefine13 { get; set; }
        public string cdefine14 { get; set; }
        public Nullable<int> cdefine15 { get; set; }
        public Nullable<double> cdefine16 { get; set; }
        public Nullable<int> ivtid { get; set; }
        public Nullable<double> iPrintCount { get; set; }
        public string csysbarcode { get; set; }
        public string cCurrentAuditor { get; set; }
    }
}
