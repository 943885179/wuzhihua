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
    
    public partial class AA_ArchiveTable
    {
        public string ID { get; set; }
        public string TableName { get; set; }
        public string ExportWhereStr { get; set; }
        public string DeleteWhereStr { get; set; }
        public Nullable<bool> bClearFirst { get; set; }
        public Nullable<int> iExportOrder { get; set; }
        public Nullable<int> iDeleteOrder { get; set; }
    }
}
