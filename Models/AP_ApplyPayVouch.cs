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
    
    public partial class AP_ApplyPayVouch
    {
        public int PID { get; set; }
        public string cVouchType { get; set; }
        public string cVouchID { get; set; }
        public System.DateTime dVouchDate { get; set; }
        public string cSource { get; set; }
        public string cFlag { get; set; }
        public string cDwCode { get; set; }
        public string cDepCode { get; set; }
        public string cPerson { get; set; }
        public string cSSCode { get; set; }
        public string cCode { get; set; }
        public string cItemCode { get; set; }
        public string cItemName { get; set; }
        public string cItem_Class { get; set; }
        public string cexch_name { get; set; }
        public Nullable<double> iExchRate { get; set; }
        public Nullable<int> bStartFlag { get; set; }
        public string cBank { get; set; }
        public string cBankAccount { get; set; }
        public string cNatBank { get; set; }
        public string cNatBankAccount { get; set; }
        public string cDigest { get; set; }
        public int VT_ID { get; set; }
        public byte[] Ufts { get; set; }
        public Nullable<int> iState { get; set; }
        public Nullable<bool> IsWfControlled { get; set; }
        public Nullable<int> iverifystate { get; set; }
        public Nullable<int> ireturncount { get; set; }
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
        public string cDefine11 { get; set; }
        public string cDefine12 { get; set; }
        public string cDefine13 { get; set; }
        public string cDefine14 { get; set; }
        public Nullable<int> cDefine15 { get; set; }
        public Nullable<double> cDefine16 { get; set; }
        public string cOperator { get; set; }
        public string cCheckMan { get; set; }
        public Nullable<System.DateTime> dcreatesystime { get; set; }
        public Nullable<System.DateTime> dverifydate { get; set; }
        public Nullable<System.DateTime> dverifysystime { get; set; }
        public string cmodifier { get; set; }
        public Nullable<System.DateTime> dmoddate { get; set; }
        public Nullable<System.DateTime> dmodifysystime { get; set; }
        public string cCloser { get; set; }
        public Nullable<System.DateTime> dCloseDate { get; set; }
        public string cbg_itemcode { get; set; }
        public string cbg_itemname { get; set; }
        public string cbg_caliberkey1 { get; set; }
        public string cbg_caliberkeyname1 { get; set; }
        public string cbg_caliberkey2 { get; set; }
        public string cbg_caliberkeyname2 { get; set; }
        public string cbg_caliberkey3 { get; set; }
        public string cbg_caliberkeyname3 { get; set; }
        public string cbg_calibercode1 { get; set; }
        public string cbg_calibername1 { get; set; }
        public string cbg_calibercode2 { get; set; }
        public string cbg_calibername2 { get; set; }
        public string cbg_calibercode3 { get; set; }
        public string cbg_calibername3 { get; set; }
        public Nullable<short> ibg_overflag { get; set; }
        public string cbg_auditor { get; set; }
        public string cbg_audittime { get; set; }
        public Nullable<short> controlresult { get; set; }
        public string cGatheringPlan { get; set; }
        public Nullable<System.DateTime> dCreditStart { get; set; }
        public Nullable<int> iCreditPeriod { get; set; }
        public Nullable<System.DateTime> dGatheringDate { get; set; }
        public string cbg_caliberkey4 { get; set; }
        public string cbg_caliberkeyname4 { get; set; }
        public string cbg_caliberkey5 { get; set; }
        public string cbg_caliberkeyname5 { get; set; }
        public string cbg_caliberkey6 { get; set; }
        public string cbg_caliberkeyname6 { get; set; }
        public string cbg_calibercode4 { get; set; }
        public string cbg_calibername4 { get; set; }
        public string cbg_calibercode5 { get; set; }
        public string cbg_calibername5 { get; set; }
        public string cbg_calibercode6 { get; set; }
        public string cbg_calibername6 { get; set; }
        public int iPrintCount { get; set; }
        public Nullable<int> iBusType { get; set; }
        public int iPayType { get; set; }
        public string cagentcuscode { get; set; }
        public string csysbarcode { get; set; }
        public string cCurrentAuditor { get; set; }
        public string cSubId { get; set; }
    }
}
