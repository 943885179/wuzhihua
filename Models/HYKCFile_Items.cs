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
    
    public partial class HYKCFile_Items
    {
        public string FileNumber { get; set; }
        public string ItemName { get; set; }
        public string DisName { get; set; }
        public bool canModify { get; set; }
        public short referType { get; set; }
        public Nullable<short> numPoint { get; set; }
        public Nullable<int> maxLength { get; set; }
        public Nullable<bool> allowBadstring { get; set; }
        public bool bMust { get; set; }
        public string sMetaXml { get; set; }
        public string sXml { get; set; }
        public string referId { get; set; }
        public int TabIndex { get; set; }
        public Nullable<int> Width { get; set; }
        public string alignment { get; set; }
    
        public virtual HYKCFile_Config HYKCFile_Config { get; set; }
    }
}
