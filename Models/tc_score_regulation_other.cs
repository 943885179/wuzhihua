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
    
    public partial class tc_score_regulation_other
    {
        public decimal regulation_id { get; set; }
        public string regulation_name { get; set; }
        public Nullable<short> operation_type { get; set; }
        public string disp_name_func { get; set; }
        public string param_setting_func { get; set; }
        public string score_cal_func { get; set; }
        public Nullable<decimal> obj_type { get; set; }
        public Nullable<decimal> obj_sub_type { get; set; }
        public Nullable<decimal> opr_type { get; set; }
        public string param1 { get; set; }
        public string param2 { get; set; }
        public Nullable<short> is_stop { get; set; }
        public string create_user_id { get; set; }
        public Nullable<System.DateTime> create_time { get; set; }
        public Nullable<short> server_flag { get; set; }
        public byte[] crm_timestamp { get; set; }
    }
}
