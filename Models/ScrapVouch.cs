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
    
    public partial class ScrapVouch
    {
        public int Id { get; set; }
        public int VT_ID { get; set; }
        public string cSpCode { get; set; }
        public string cVouchType { get; set; }
        public Nullable<System.DateTime> dDate { get; set; }
        public string cInWhcode { get; set; }
        public string cOutWhcode { get; set; }
        public string cDepCode { get; set; }
        public string cCusCode { get; set; }
        public string cVenCode { get; set; }
        public string cPersonCode { get; set; }
        public string cIRdCode { get; set; }
        public string cORdCode { get; set; }
        public string cMemo { get; set; }
        public string cMaker { get; set; }
        public string cVerifyPerson { get; set; }
        public Nullable<System.DateTime> dVerifyDate { get; set; }
        public string cChkCode { get; set; }
        public Nullable<System.DateTime> dChkDate { get; set; }
        public string cChkPerson { get; set; }
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
        public string cSource { get; set; }
        public string cdinid { get; set; }
        public Nullable<double> cDefine16 { get; set; }
        public byte[] ufts { get; set; }
        public Nullable<System.DateTime> dArrivalDate { get; set; }
        public string cArrivalCode { get; set; }
        public string cProductCode { get; set; }
        public string cProBatch { get; set; }
        public Nullable<int> iproorderid { get; set; }
        public string cOutVouchCode { get; set; }
        public string cDispatchCode { get; set; }
        public string cModifyPerson { get; set; }
        public Nullable<System.DateTime> dModifyDate { get; set; }
        public Nullable<System.DateTime> dnmaketime { get; set; }
        public Nullable<System.DateTime> dnmodifytime { get; set; }
        public Nullable<System.DateTime> dnverifytime { get; set; }
        public Nullable<int> ireturncount { get; set; }
        public Nullable<int> iverifystate { get; set; }
        public Nullable<int> iswfcontrolled { get; set; }
        public Nullable<int> iPrintCount { get; set; }
        public string csysbarcode { get; set; }
        public string cCurrentAuditor { get; set; }
    }
}
