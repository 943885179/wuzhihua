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
    
    public partial class tc_receipt_history
    {
        public decimal his_id { get; set; }
        public Nullable<decimal> receipt_id { get; set; }
        public string attr_name { get; set; }
        public string old_value { get; set; }
        public string new_value { get; set; }
        public string create_user_id { get; set; }
        public Nullable<System.DateTime> create_time { get; set; }
        public Nullable<short> server_flag { get; set; }
        public Nullable<System.DateTime> crm_timestamp { get; set; }
    }
}
