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
    
    public partial class Ap48_CloseBillHistory
    {
        public string cVouchType { get; set; }
        public string cVouchID { get; set; }
        public System.DateTime dVouchDate { get; set; }
        public byte iPeriod { get; set; }
        public string cDwCode { get; set; }
        public string cDeptCode { get; set; }
        public string cPerson { get; set; }
        public string cItem_Class { get; set; }
        public string cItemCode { get; set; }
        public string cSSCode { get; set; }
        public string cNoteNo { get; set; }
        public string cCoVouchType { get; set; }
        public string cCoVouchID { get; set; }
        public string cDigest { get; set; }
        public string cBankAccount { get; set; }
        public string cexch_name { get; set; }
        public Nullable<double> iExchRate { get; set; }
        public Nullable<decimal> iAmount { get; set; }
        public Nullable<decimal> iAmount_f { get; set; }
        public Nullable<decimal> iRAmount { get; set; }
        public Nullable<decimal> iRAmount_f { get; set; }
        public string cOperator { get; set; }
        public string cCancelMan { get; set; }
        public string cRPMan { get; set; }
        public Nullable<bool> bPrePay { get; set; }
        public Nullable<bool> bStartFlag { get; set; }
        public string cOrderNo { get; set; }
        public string cCode { get; set; }
        public string cPreCode { get; set; }
        public Nullable<bool> iPayForOther { get; set; }
        public string cSrcFlag { get; set; }
        public string cPzID { get; set; }
        public string cFlag { get; set; }
        public Nullable<bool> bSend { get; set; }
        public Nullable<bool> bReceived { get; set; }
        public string csItemCode { get; set; }
        public int iID { get; set; }
        public string cCancelNo { get; set; }
        public string cBank { get; set; }
        public string cNatBank { get; set; }
        public string cNatBankAccount { get; set; }
        public bool bFromBank { get; set; }
        public bool bToBank { get; set; }
        public bool bSure { get; set; }
        public int VT_ID { get; set; }
        public string cCheckMan { get; set; }
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
        public byte[] Ufts { get; set; }
        public string cItemName { get; set; }
        public string cContractType { get; set; }
        public string cContractID { get; set; }
        public Nullable<double> iAmount_s { get; set; }
        public Nullable<bool> IsWfControlled { get; set; }
        public Nullable<byte> iSource { get; set; }
        public string sDLCode { get; set; }
        public Nullable<int> RegisterFlag { get; set; }
        public Nullable<int> iverifystate { get; set; }
        public Nullable<int> ireturncount { get; set; }
        public Nullable<System.DateTime> dcreatesystime { get; set; }
        public Nullable<System.DateTime> dverifysystime { get; set; }
        public Nullable<System.DateTime> dmodifysystime { get; set; }
        public string cmodifier { get; set; }
        public Nullable<System.DateTime> dmoddate { get; set; }
        public Nullable<System.DateTime> dverifydate { get; set; }
        public Nullable<short> ibg_overflag { get; set; }
        public string cbg_auditor { get; set; }
        public string cbg_audittime { get; set; }
        public Nullable<short> controlresult { get; set; }
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
        public Nullable<bool> ibg_ctrl { get; set; }
        public string cbg_auditopinion { get; set; }
        public long HistoryId { get; set; }
        public Nullable<byte> VariationAction { get; set; }
        public int VariationLogId { get; set; }
        public Nullable<byte> SubVariationAction { get; set; }
    }
}
