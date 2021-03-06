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
    
    public partial class HR_PF_ResultChangeChild
    {
        public System.Guid uResultChangeChildPK { get; set; }
        public string cResultChangeCode { get; set; }
        public int iSerialNumber { get; set; }
        public short sCheckMainbody { get; set; }
        public string cDepCode { get; set; }
        public string cPsn_Num { get; set; }
        public string cColumnCode { get; set; }
        public string cPeriodValue { get; set; }
        public string cFormerValueText { get; set; }
        public Nullable<decimal> fFormerValueNumber { get; set; }
        public byte[] iFormerValueAnnex { get; set; }
        public string cNewValueText { get; set; }
        public Nullable<decimal> fNewValueNumber { get; set; }
        public byte[] iNewValueAnnex { get; set; }
        public byte[] tStamp { get; set; }
        public string cDefine1 { get; set; }
        public string cDefine2 { get; set; }
        public string cDefine3 { get; set; }
        public string cStatus { get; set; }
        public string cChangeReason { get; set; }
        public string cChangeGist { get; set; }
        public string cSummary { get; set; }
    
        public virtual Department Department { get; set; }
        public virtual hr_hi_person hr_hi_person { get; set; }
        public virtual HR_PF_Column HR_PF_Column { get; set; }
        public virtual HR_PF_Period HR_PF_Period { get; set; }
        public virtual HR_PF_ResultChange HR_PF_ResultChange { get; set; }
    }
}
