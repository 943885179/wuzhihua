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
    
    public partial class GrpArchContrapose
    {
        public int ArchID { get; set; }
        public string cChildCode { get; set; }
        public string cParentCode { get; set; }
        public System.DateTime dCreDate { get; set; }
        public string cInfo { get; set; }
        public string cItem_Class { get; set; }
        public string cItemCCode { get; set; }
        public int iyear { get; set; }
    
        public virtual GrpArchCode GrpArchCode { get; set; }
    }
}
