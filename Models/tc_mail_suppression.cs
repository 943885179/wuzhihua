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
    
    public partial class tc_mail_suppression
    {
        public decimal suppression_id { get; set; }
        public Nullable<short> suppression_status { get; set; }
        public string tags { get; set; }
        public string suppression_name { get; set; }
        public string suppression_content { get; set; }
        public string suppression_note { get; set; }
        public Nullable<short> is_deleted { get; set; }
        public string deleted_user_id { get; set; }
        public Nullable<System.DateTime> deleted_time { get; set; }
        public Nullable<decimal> deleted_id { get; set; }
        public string create_user_id { get; set; }
        public Nullable<System.DateTime> create_time { get; set; }
        public string modify_user_id { get; set; }
        public Nullable<System.DateTime> modify_time { get; set; }
        public Nullable<short> server_flag { get; set; }
        public byte[] crm_timestamp { get; set; }
    }
}
