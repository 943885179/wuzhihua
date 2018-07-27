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
    
    public partial class SR_ServiceBill
    {
        public string OID { get; set; }
        public int ID { get; set; }
        public Nullable<int> VT_ID { get; set; }
        public string cSerBillCode { get; set; }
        public string SerTypeID { get; set; }
        public string SerRequestID { get; set; }
        public string cCusCode { get; set; }
        public string cItemCode { get; set; }
        public string cItemName { get; set; }
        public string cItem_class { get; set; }
        public string cItem_CName { get; set; }
        public string cReqPersonCode { get; set; }
        public string cReqDepCode { get; set; }
        public string ContactID { get; set; }
        public string SerStateID { get; set; }
        public string cInvCode { get; set; }
        public string SerialNoID { get; set; }
        public Nullable<double> fQuantity { get; set; }
        public string SerModeID { get; set; }
        public Nullable<System.DateTime> dReqDate { get; set; }
        public Nullable<System.DateTime> dReqTime { get; set; }
        public string cReqContent { get; set; }
        public string cSerPrincipalCode { get; set; }
        public string cSerDepCode { get; set; }
        public Nullable<System.DateTime> dIntendDate { get; set; }
        public Nullable<System.DateTime> dIntendTime { get; set; }
        public Nullable<System.DateTime> dArriveDate { get; set; }
        public Nullable<System.DateTime> dArriveTime { get; set; }
        public Nullable<System.DateTime> dCompletedDate { get; set; }
        public Nullable<System.DateTime> dCompletedTime { get; set; }
        public string cExplain { get; set; }
        public string cCusAdvice { get; set; }
        public string cExchName { get; set; }
        public Nullable<double> fExchRate { get; set; }
        public Nullable<decimal> mChargeSum { get; set; }
        public Nullable<decimal> mNatChargeSum { get; set; }
        public Nullable<double> fDiscount { get; set; }
        public Nullable<decimal> mDiscountSum { get; set; }
        public Nullable<decimal> mNatDiscountSum { get; set; }
        public Nullable<decimal> mGatheringSum { get; set; }
        public Nullable<decimal> mNatGatheringSum { get; set; }
        public string PreClosedStateID { get; set; }
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
        public string cCreator { get; set; }
        public Nullable<System.DateTime> dCreatedDate { get; set; }
        public string cModifier { get; set; }
        public Nullable<System.DateTime> dModifiedDate { get; set; }
        public byte[] ufts { get; set; }
        public Nullable<bool> bFeedback { get; set; }
        public string cAgrCode { get; set; }
        public string Distor { get; set; }
        public Nullable<System.DateTime> DistDate { get; set; }
        public Nullable<decimal> mFreeSum { get; set; }
        public Nullable<decimal> mNatFreeSum { get; set; }
        public Nullable<decimal> mCompensateSum { get; set; }
        public Nullable<decimal> mNatCompensateSum { get; set; }
        public Nullable<System.DateTime> dnVerifytime { get; set; }
        public Nullable<System.DateTime> dVerifydate { get; set; }
        public string cVerifier { get; set; }
        public string cInitOID { get; set; }
        public Nullable<int> iverifystateex { get; set; }
        public Nullable<int> ireturncount { get; set; }
        public Nullable<bool> IsWfControlled { get; set; }
        public string cVT_TmpSets { get; set; }
        public string iVTSet_ID { get; set; }
        public string cModType { get; set; }
        public Nullable<int> iPrintCount { get; set; }
        public string cCleanVer { get; set; }
        public string cSysBarCode { get; set; }
    
        public virtual Department Department { get; set; }
        public virtual Department Department1 { get; set; }
        public virtual foreigncurrency foreigncurrency { get; set; }
        public virtual Person Person { get; set; }
        public virtual Person Person1 { get; set; }
    }
}
