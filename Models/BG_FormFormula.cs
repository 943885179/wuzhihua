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
    
    public partial class BG_FormFormula
    {
        public string UID { get; set; }
        public string cFormCode { get; set; }
        public int iType { get; set; }
        public string cErrInfo { get; set; }
        public string cFormula { get; set; }
        public byte[] tStamp { get; set; }
        public Nullable<int> iYear { get; set; }
        public int iMakeYear { get; set; }
    
        public virtual BG_Form BG_Form { get; set; }
    }
}
