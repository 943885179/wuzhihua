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
    
    public partial class tc_background_task
    {
        public decimal bg_task_id { get; set; }
        public Nullable<short> priority { get; set; }
        public string bg_server_ip { get; set; }
        public string bg_task_subject { get; set; }
        public Nullable<decimal> bg_interval { get; set; }
        public Nullable<System.DateTime> plan_start_time { get; set; }
        public Nullable<System.DateTime> occur_start_time { get; set; }
        public Nullable<System.DateTime> occur_end_time { get; set; }
        public string bg_url { get; set; }
        public Nullable<short> is_external_link { get; set; }
        public string external_url { get; set; }
        public decimal bg_param_id { get; set; }
        public string bg_param_str { get; set; }
        public string bg_param_text { get; set; }
        public short bg_with_text { get; set; }
        public string bg_check_token { get; set; }
        public short bg_task_status { get; set; }
        public string bg_result_desc { get; set; }
        public Nullable<short> is_system { get; set; }
        public Nullable<decimal> event_id { get; set; }
        public Nullable<short> obj_type { get; set; }
        public string obj_id { get; set; }
        public System.DateTime create_time { get; set; }
        public string create_user_id { get; set; }
        public Nullable<System.DateTime> modify_time { get; set; }
        public string modify_user_id { get; set; }
        public Nullable<short> server_flag { get; set; }
        public byte[] crm_timestamp { get; set; }
    }
}
