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
    
    public partial class CN_NoteManageAcct_Log
    {
        public long HistoryId { get; set; }
        public int VariationAction { get; set; }
        public int VariationLogId { get; set; }
        public int bDeletedRst { get; set; }
        public System.DateTime dLogTime { get; set; }
        public string ID { get; set; }
        public string ManageAcctName { get; set; }
        public string NoteTypeID { get; set; }
        public string AcctID { get; set; }
    }
}
