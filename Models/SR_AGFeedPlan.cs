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
    
    public partial class SR_AGFeedPlan
    {
        public string OID { get; set; }
        public int AutoID { get; set; }
        public Nullable<int> VT_ID { get; set; }
        public string cAgrCodeID { get; set; }
        public string cInvCode { get; set; }
        public string cFree1 { get; set; }
        public string cFree2 { get; set; }
        public string cFree3 { get; set; }
        public string cFree4 { get; set; }
        public string cFree5 { get; set; }
        public string cFree6 { get; set; }
        public string cFree7 { get; set; }
        public string cFree8 { get; set; }
        public string cFree9 { get; set; }
        public string cFree10 { get; set; }
        public Nullable<System.DateTime> dTime { get; set; }
        public string cExplain { get; set; }
        public string cPersonCode { get; set; }
        public string cDefine22 { get; set; }
        public string cDefine23 { get; set; }
        public string cDefine24 { get; set; }
        public string cDefine25 { get; set; }
        public Nullable<double> cDefine26 { get; set; }
        public Nullable<double> cDefine27 { get; set; }
        public string cDefine28 { get; set; }
        public string cDefine29 { get; set; }
        public string cDefine30 { get; set; }
        public string cDefine31 { get; set; }
        public string cDefine32 { get; set; }
        public string cDefine33 { get; set; }
        public Nullable<int> cDefine34 { get; set; }
        public Nullable<int> cDefine35 { get; set; }
        public Nullable<System.DateTime> cDefine36 { get; set; }
        public Nullable<System.DateTime> cDefine37 { get; set; }
        public string cCreator { get; set; }
        public Nullable<System.DateTime> dCreatedDate { get; set; }
        public string cModifier { get; set; }
        public Nullable<System.DateTime> dModifiedDate { get; set; }
        public byte[] ufts { get; set; }
    
        public virtual Person Person { get; set; }
    }
}
