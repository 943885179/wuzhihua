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
    
    public partial class tc_survey_tmpl_qst_m
    {
        public decimal question_id { get; set; }
        public Nullable<decimal> survey_id { get; set; }
        public Nullable<short> question_sn { get; set; }
        public Nullable<short> is_must { get; set; }
        public Nullable<short> question_type { get; set; }
        public string question_subject { get; set; }
        public string question_location { get; set; }
        public Nullable<decimal> question_mark { get; set; }
        public string create_user_id { get; set; }
        public Nullable<System.DateTime> create_time { get; set; }
        public string modify_user_id { get; set; }
        public Nullable<System.DateTime> modify_time { get; set; }
        public Nullable<short> server_flag { get; set; }
        public byte[] crm_timestamp { get; set; }
    }
}
