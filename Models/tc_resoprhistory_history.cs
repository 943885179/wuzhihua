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
    
    public partial class tc_resoprhistory_history
    {
        public decimal org_id { get; set; }
        public decimal his_id { get; set; }
        public Nullable<decimal> log_id { get; set; }
        public string attr_name { get; set; }
        public string old_value { get; set; }
        public string new_value { get; set; }
        public Nullable<decimal> create_user_id { get; set; }
        public Nullable<System.DateTime> create_time { get; set; }
        public Nullable<short> server_flag { get; set; }
        public byte[] crm_timestamp { get; set; }
    }
}
