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
    
    public partial class Ap_VouchHistory
    {
        public string cLink { get; set; }
        public string cVouchType { get; set; }
        public string cVouchID { get; set; }
        public string cVouchID1 { get; set; }
        public System.DateTime dVouchDate { get; set; }
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
        public decimal iRAmount { get; set; }
        public Nullable<decimal> iRAmount_f { get; set; }
        public string cPayCode { get; set; }
        public string cOperator { get; set; }
        public string cCheckMan { get; set; }
        public string cCoVouchType { get; set; }
        public string cDestNo { get; set; }
        public string cSrcNo { get; set; }
        public Nullable<bool> bStartFlag { get; set; }
        public string cPZid { get; set; }
        public string cFlag { get; set; }
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
        public Nullable<double> iAmount_s { get; set; }
        public Nullable<double> iRAmount_s { get; set; }
        public int VT_ID { get; set; }
        public byte[] Ufts { get; set; }
        public int iClosesID { get; set; }
        public int iCoClosesID { get; set; }
        public string cDefine11 { get; set; }
        public string cDefine12 { get; set; }
        public string cDefine13 { get; set; }
        public string cDefine14 { get; set; }
        public Nullable<int> cDefine15 { get; set; }
        public Nullable<double> cDefine16 { get; set; }
        public string cItemName { get; set; }
        public string cGatheringPlan { get; set; }
        public Nullable<System.DateTime> dCreditStart { get; set; }
        public Nullable<int> iCreditPeriod { get; set; }
        public Nullable<System.DateTime> dGatheringDate { get; set; }
        public Nullable<System.DateTime> dcreatesystime { get; set; }
        public Nullable<System.DateTime> dverifysystime { get; set; }
        public Nullable<System.DateTime> dmodifysystime { get; set; }
        public string cmodifier { get; set; }
        public Nullable<System.DateTime> dmoddate { get; set; }
        public Nullable<System.DateTime> dverifydate { get; set; }
        public int Auto_ID { get; set; }
        public long HistoryId { get; set; }
        public Nullable<byte> VariationAction { get; set; }
        public int VariationLogId { get; set; }
        public Nullable<byte> SubVariationAction { get; set; }
    }
}
