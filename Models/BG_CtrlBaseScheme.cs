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
    
    public partial class BG_CtrlBaseScheme
    {
        public int iID { get; set; }
        public string cSchemeCode { get; set; }
        public string cSchemeName { get; set; }
        public string cSourceBill { get; set; }
        public bool bIncludeTax { get; set; }
        public bool bIncludeNoCheck { get; set; }
        public int iOffSet { get; set; }
        public bool bCaliber1All { get; set; }
        public bool bCaliber2All { get; set; }
        public bool bCaliber3All { get; set; }
        public bool bCaliber4All { get; set; }
        public bool bCaliber5All { get; set; }
        public bool bCaliber6All { get; set; }
        public Nullable<decimal> dPercent { get; set; }
        public byte[] tStamp { get; set; }
    
        public virtual BG_CtrlBaseBillInfo BG_CtrlBaseBillInfo { get; set; }
    }
}
