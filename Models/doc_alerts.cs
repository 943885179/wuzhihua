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
    
    public partial class doc_alerts
    {
        public long id { get; set; }
        public long doc_resource_id { get; set; }
        public byte change_type { get; set; }
        public Nullable<byte> alert_type { get; set; }
        public long alert_user_id { get; set; }
        public System.DateTime create_time { get; set; }
        public System.DateTime last_update { get; set; }
        public Nullable<byte> status { get; set; }
        public byte is_folder { get; set; }
        public long create_user_id { get; set; }
        public long last_user_id { get; set; }
        public string alert_user_type { get; set; }
        public byte send_message { get; set; }
        public byte is_from_acl { get; set; }
        public byte set_subfolder { get; set; }
    
        public virtual doc_resources doc_resources { get; set; }
    }
}
