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
    
    public partial class info_publish_record
    {
        public long id { get; set; }
        public Nullable<long> info_id { get; set; }
        public Nullable<long> publish_id { get; set; }
        public long publish_user_id { get; set; }
        public System.DateTime publish_time { get; set; }
        public Nullable<byte> publish_type { get; set; }
        public string publish_range { get; set; }
        public Nullable<long> is_check { get; set; }
        public Nullable<long> check_user_id { get; set; }
        public Nullable<System.DateTime> check_time { get; set; }
        public Nullable<decimal> check_score { get; set; }
        public Nullable<long> domain_id { get; set; }
    }
}
