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
    
    public partial class HB_FirmSort_Entity
    {
        public int NodeID { get; set; }
        public int SortID { get; set; }
        public int VersionID { get; set; }
        public string NodeCode { get; set; }
        public string NodeName { get; set; }
        public int RootID { get; set; }
        public Nullable<int> FatherID { get; set; }
        public string NodeProperty { get; set; }
        public byte[] Stamp { get; set; }
    
        public virtual HB_FirmSort HB_FirmSort { get; set; }
        public virtual HB_FirmSort_TreeVersions HB_FirmSort_TreeVersions { get; set; }
    }
}
