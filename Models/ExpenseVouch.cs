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
    
    public partial class ExpenseVouch
    {
        public string cEVCode { get; set; }
        public System.DateTime dDate { get; set; }
        public Nullable<int> SBVID { get; set; }
        public string cSBVCode { get; set; }
        public string cCusCode { get; set; }
        public string cDepCode { get; set; }
        public string cPersonCode { get; set; }
        public string cMemo { get; set; }
        public string cMaker { get; set; }
        public string cVerifier { get; set; }
        public string cVouchType { get; set; }
        public string cVouchID { get; set; }
        public Nullable<bool> bOriginal { get; set; }
        public string cDefine1 { get; set; }
        public string cDefine2 { get; set; }
        public string cDefine3 { get; set; }
        public Nullable<float> iNetLock { get; set; }
        public byte[] ufts { get; set; }
        public int iVTid { get; set; }
        public int ID { get; set; }
        public string Cexch_Name { get; set; }
        public double iexchrate { get; set; }
        public string cCreChpName { get; set; }
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
        public string cgatheringplan { get; set; }
        public Nullable<System.DateTime> dCreditStart { get; set; }
        public Nullable<System.DateTime> dGatheringDate { get; set; }
        public Nullable<int> icreditdays { get; set; }
        public string cpaycode { get; set; }
        public Nullable<int> iverifystate { get; set; }
        public Nullable<byte> ireturncount { get; set; }
        public Nullable<byte> iswfcontrolled { get; set; }
        public string icreditstate { get; set; }
        public string cmodifier { get; set; }
        public Nullable<System.DateTime> dmoddate { get; set; }
        public Nullable<System.DateTime> dverifydate { get; set; }
        public Nullable<System.DateTime> dcreatesystime { get; set; }
        public Nullable<System.DateTime> dverifysystime { get; set; }
        public Nullable<System.DateTime> dmodifysystime { get; set; }
        public Nullable<int> iPrintCount { get; set; }
        public string cSysBarCode { get; set; }
        public string cCurrentAuditor { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Department Department { get; set; }
        public virtual Person Person { get; set; }
    }
}
