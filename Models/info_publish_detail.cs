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
    
    public partial class info_publish_detail
    {
        public long id { get; set; }
        public Nullable<long> info_id { get; set; }
        public string publish_range { get; set; }
        public Nullable<int> total_count { get; set; }
        public Nullable<decimal> total_score { get; set; }
        public Nullable<long> last_publish_user_id { get; set; }
        public Nullable<System.DateTime> last_publish_time { get; set; }
        public Nullable<byte> last_publish_type { get; set; }
        public Nullable<byte> is_check { get; set; }
        public Nullable<long> last_check_user_id { get; set; }
        public Nullable<System.DateTime> last_check_time { get; set; }
        public Nullable<decimal> last_score { get; set; }
        public Nullable<long> domain_id { get; set; }
    }
}
