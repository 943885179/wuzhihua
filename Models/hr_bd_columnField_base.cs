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
    
    public partial class hr_bd_columnField_base
    {
        public System.Guid cColKey { get; set; }
        public System.Guid cFieldID { get; set; }
        public string cFieldName { get; set; }
        public string cGroupName { get; set; }
        public Nullable<int> iWidth { get; set; }
        public Nullable<bool> bFixed { get; set; }
        public Nullable<int> iAlignment { get; set; }
        public Nullable<int> iOrderType { get; set; }
        public Nullable<bool> bSum { get; set; }
        public Nullable<int> iRecord { get; set; }
        public Nullable<int> bdisplay { get; set; }
        public string cSourceTable { get; set; }
        public string cSourceField { get; set; }
        public Nullable<bool> bAssociate { get; set; }
        public string cBaseObject { get; set; }
        public string cbasetable { get; set; }
        public string cbasefield { get; set; }
        public string cPath { get; set; }
        public string cAstSql { get; set; }
        public Nullable<int> iLoadMode { get; set; }
        public string LocaleID { get; set; }
    }
}
