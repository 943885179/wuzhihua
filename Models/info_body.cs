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
    
    public partial class info_body
    {
        public long id { get; set; }
        public string content_type { get; set; }
        public string content { get; set; }
        public Nullable<long> info_id { get; set; }
        public System.DateTime create_time { get; set; }
        public System.DateTime last_update { get; set; }
        public string content_name { get; set; }
        public Nullable<int> content_status { get; set; }
        public Nullable<byte> content_no { get; set; }
    
        public virtual info_summary info_summary { get; set; }
    }
}
