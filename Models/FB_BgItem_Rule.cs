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
    
    public partial class FB_BgItem_Rule
    {
        public int DID { get; set; }
        public int iYear { get; set; }
        public string cBgItemCode { get; set; }
        public int iOrder { get; set; }
        public string cArchGroupCode { get; set; }
        public short iPeriodType { get; set; }
        public string cTargetCode { get; set; }
        public Nullable<double> fRate { get; set; }
        public short iCtrlMode { get; set; }
        public string cOverMessage { get; set; }
        public byte[] tStamp { get; set; }
    
        public virtual FB_BgItem FB_BgItem { get; set; }
    }
}
