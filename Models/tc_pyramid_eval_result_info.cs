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
    
    public partial class tc_pyramid_eval_result_info
    {
        public decimal result_id { get; set; }
        public decimal model_id { get; set; }
        public decimal pyramid_obj_type { get; set; }
        public string result_name { get; set; }
        public string result_description { get; set; }
        public Nullable<System.DateTime> start_date { get; set; }
        public Nullable<System.DateTime> end_date { get; set; }
        public Nullable<short> is_bg_exec { get; set; }
        public string create_user_id { get; set; }
        public Nullable<System.DateTime> create_time { get; set; }
        public Nullable<short> server_flag { get; set; }
        public byte[] crm_timestamp { get; set; }
    }
}
