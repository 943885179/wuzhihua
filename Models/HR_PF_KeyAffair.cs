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
    
    public partial class HR_PF_KeyAffair
    {
        public string cKeyAffairCode { get; set; }
        public short sCheckMainbody { get; set; }
        public string cDepCode { get; set; }
        public string cPsn_Num { get; set; }
        public short sAffairType { get; set; }
        public string cAffairContent { get; set; }
        public byte[] iAffairAnnex { get; set; }
        public string cMakeFormPerson { get; set; }
        public System.DateTime dMakeFormDate { get; set; }
        public string cCheckPerson { get; set; }
        public Nullable<System.DateTime> dCheckDate { get; set; }
        public string cCheckIdea { get; set; }
        public string cRemark { get; set; }
        public byte[] tStamp { get; set; }
        public string cDefine1 { get; set; }
        public string cDefine2 { get; set; }
        public string cDefine3 { get; set; }
        public bool bControl { get; set; }
        public string cVoucherType { get; set; }
        public string cVoucherCode { get; set; }
        public string cStatus { get; set; }
        public short sVoucherState { get; set; }
        public Nullable<System.DateTime> dAffairDate { get; set; }
        public string cPlanCode { get; set; }
        public string cSubmitPerson { get; set; }
        public Nullable<System.DateTime> dSubmitTime { get; set; }
        public decimal fAffairValue { get; set; }
    
        public virtual Department Department { get; set; }
        public virtual hr_hi_person hr_hi_person { get; set; }
        public virtual HR_PF_Plan HR_PF_Plan { get; set; }
    }
}
