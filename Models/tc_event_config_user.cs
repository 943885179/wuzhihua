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
    
    public partial class tc_event_config_user
    {
        public decimal event_d_id { get; set; }
        public decimal event_id { get; set; }
        public short to_type { get; set; }
        public string role_id { get; set; }
        public string obj_role_id { get; set; }
        public string user_id { get; set; }
        public short to_parent { get; set; }
        public short to_sms { get; set; }
        public short to_email { get; set; }
        public short to_desktop { get; set; }
        public short to_utu { get; set; }
        public string mobile { get; set; }
        public string email { get; set; }
        public Nullable<short> server_flag { get; set; }
        public byte[] crm_timestamp { get; set; }
    }
}
