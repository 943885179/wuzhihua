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
    
    public partial class info_format
    {
        public long id { get; set; }
        public string name { get; set; }
        public Nullable<int> format_type { get; set; }
        public Nullable<byte> format_state { get; set; }
        public Nullable<long> create_user_id { get; set; }
        public System.DateTime create_time { get; set; }
        public Nullable<long> last_user_id { get; set; }
        public System.DateTime last_update { get; set; }
        public Nullable<byte> detail_type { get; set; }
        public Nullable<byte> is_system { get; set; }
        public long domain_id { get; set; }
    }
}
