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
    
    public partial class tc_attach
    {
        public decimal attach_id { get; set; }
        public short parent_obj_type { get; set; }
        public string parent_obj_id { get; set; }
        public decimal fr_id { get; set; }
        public string attach_name { get; set; }
        public string attach_subject { get; set; }
        public string attach_note { get; set; }
        public string key_words { get; set; }
        public Nullable<short> is_locked { get; set; }
        public string locked_user_id { get; set; }
        public Nullable<System.DateTime> locked_time { get; set; }
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
        public string file_type { get; set; }
        public string file_pos { get; set; }
    }
}
