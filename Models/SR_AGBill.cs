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
    
    public partial class SR_AGBill
    {
        public string OID { get; set; }
        public int ID { get; set; }
        public Nullable<int> VT_ID { get; set; }
        public string cAgrCode { get; set; }
        public string cAgrName { get; set; }
        public string cCusCode { get; set; }
        public string ContactID { get; set; }
        public Nullable<System.DateTime> dAgrDate { get; set; }
        public Nullable<System.DateTime> dEnabledDate { get; set; }
        public Nullable<System.DateTime> dDisabledDate { get; set; }
        public string cPersonCode { get; set; }
        public string cDepCode { get; set; }
        public string cExchName { get; set; }
        public string fExchRate { get; set; }
        public Nullable<float> mChargeSum { get; set; }
        public string cFitBit { get; set; }
        public string cItemBit { get; set; }
        public string cPayModel { get; set; }
        public Nullable<decimal> mNatChargeSum { get; set; }
        public string cState { get; set; }
        public string SerTypeID { get; set; }
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
        public string cAuditer { get; set; }
        public Nullable<System.DateTime> dAuditDate { get; set; }
        public Nullable<int> iverifystateex { get; set; }
        public Nullable<int> ireturncount { get; set; }
        public Nullable<bool> IsWfControlled { get; set; }
        public string cModType { get; set; }
        public Nullable<int> iPrintCount { get; set; }
        public string cCleanVer { get; set; }
        public string cSysBarCode { get; set; }
    
        public virtual Department Department { get; set; }
        public virtual foreigncurrency foreigncurrency { get; set; }
        public virtual Person Person { get; set; }
    }
}
