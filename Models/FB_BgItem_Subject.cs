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
    
    public partial class FB_BgItem_Subject
    {
        public int DID { get; set; }
        public int iYear { get; set; }
        public string cCalcOperator { get; set; }
        public string cBgItemCode { get; set; }
        public string cSubjectCode { get; set; }
        public string cDirection { get; set; }
    
        public virtual FB_BgItem FB_BgItem { get; set; }
    }
}
