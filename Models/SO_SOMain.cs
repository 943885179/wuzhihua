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
    
    public partial class SO_SOMain
    {
        public string cSTCode { get; set; }
        public System.DateTime dDate { get; set; }
        public string cSOCode { get; set; }
        public string cCusCode { get; set; }
        public string cDepCode { get; set; }
        public string cPersonCode { get; set; }
        public string cSCCode { get; set; }
        public string cCusOAddress { get; set; }
        public string cPayCode { get; set; }
        public string cexch_name { get; set; }
        public Nullable<double> iExchRate { get; set; }
        public Nullable<double> iTaxRate { get; set; }
        public Nullable<decimal> iMoney { get; set; }
        public string cMemo { get; set; }
        public Nullable<byte> iStatus { get; set; }
        public string cMaker { get; set; }
        public string cVerifier { get; set; }
        public string cCloser { get; set; }
        public Nullable<bool> bDisFlag { get; set; }
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
        public bool bReturnFlag { get; set; }
        public string cCusName { get; set; }
        public Nullable<bool> bOrder { get; set; }
        public int ID { get; set; }
        public int iVTid { get; set; }
        public byte[] ufts { get; set; }
        public string cChanger { get; set; }
        public string cBusType { get; set; }
        public string cCreChpName { get; set; }
        public string cDefine11 { get; set; }
        public string cDefine12 { get; set; }
        public string cDefine13 { get; set; }
        public string cDefine14 { get; set; }
        public Nullable<int> cDefine15 { get; set; }
        public Nullable<double> cDefine16 { get; set; }
        public string coppcode { get; set; }
        public string cLocker { get; set; }
        public Nullable<System.DateTime> dPreMoDateBT { get; set; }
        public Nullable<System.DateTime> dPreDateBT { get; set; }
        public string cgatheringplan { get; set; }
        public string caddcode { get; set; }
        public Nullable<int> iverifystate { get; set; }
        public Nullable<byte> ireturncount { get; set; }
        public Nullable<byte> iswfcontrolled { get; set; }
        public string icreditstate { get; set; }
        public string cmodifier { get; set; }
        public Nullable<System.DateTime> dmoddate { get; set; }
        public Nullable<System.DateTime> dverifydate { get; set; }
        public string ccusperson { get; set; }
        public Nullable<System.DateTime> dcreatesystime { get; set; }
        public Nullable<System.DateTime> dverifysystime { get; set; }
        public Nullable<System.DateTime> dmodifysystime { get; set; }
        public Nullable<int> iflowid { get; set; }
        public Nullable<bool> bcashsale { get; set; }
        public string cgathingcode { get; set; }
        public string cChangeVerifier { get; set; }
        public Nullable<System.DateTime> dChangeVerifyDate { get; set; }
        public Nullable<System.DateTime> dChangeVerifyTime { get; set; }
        public Nullable<System.Guid> outid { get; set; }
        public string ccuspersoncode { get; set; }
        public Nullable<System.DateTime> dclosedate { get; set; }
        public Nullable<System.DateTime> dclosesystime { get; set; }
        public Nullable<double> iPrintCount { get; set; }
        public Nullable<double> fbookratio { get; set; }
        public Nullable<bool> bmustbook { get; set; }
        public Nullable<decimal> fbooksum { get; set; }
        public Nullable<decimal> fbooknatsum { get; set; }
        public Nullable<decimal> fgbooksum { get; set; }
        public Nullable<decimal> fgbooknatsum { get; set; }
        public string csvouchtype { get; set; }
        public string cCrmPersonCode { get; set; }
        public string cCrmPersonName { get; set; }
        public string cMainPersonCode { get; set; }
        public string cSysBarCode { get; set; }
        public Nullable<int> ioppid { get; set; }
        public string optnty_name { get; set; }
        public string cCurrentAuditor { get; set; }
        public Nullable<short> contract_status { get; set; }
        public string csscode { get; set; }
        public string cinvoicecompany { get; set; }
        public string cAttachment { get; set; }
    
        public virtual Department Department { get; set; }
        public virtual foreigncurrency foreigncurrency { get; set; }
        public virtual PayCondition PayCondition { get; set; }
        public virtual Person Person { get; set; }
        public virtual SaleType SaleType { get; set; }
        public virtual ShippingChoice ShippingChoice { get; set; }
    }
}
