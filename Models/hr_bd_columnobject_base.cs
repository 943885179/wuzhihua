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
    
    public partial class hr_bd_columnobject_base
    {
        public System.Guid cKey { get; set; }
        public string cColID { get; set; }
        public string cColName { get; set; }
        public string cModelID { get; set; }
        public string cFuncID { get; set; }
        public Nullable<int> iViewStyle { get; set; }
        public string cUserID { get; set; }
        public Nullable<bool> bPreparation { get; set; }
        public string cFather { get; set; }
        public string LocaleID { get; set; }
        public byte[] hrts { get; set; }
    }
}
