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
    
    public partial class edoc_mark
    {
        public long id { get; set; }
        public Nullable<long> mark_definition_id { get; set; }
        public Nullable<long> edoc_id { get; set; }
        public string doc_mark { get; set; }
        public Nullable<int> doc_mark_no { get; set; }
        public Nullable<long> category_id { get; set; }
        public long create_user_id { get; set; }
        public System.DateTime create_time { get; set; }
        public byte status { get; set; }
        public long domain_id { get; set; }
        public Nullable<int> mark_num { get; set; }
    
        public virtual edoc_mark_definition edoc_mark_definition { get; set; }
    }
}
