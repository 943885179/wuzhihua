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
    
    public partial class tc_calc_function
    {
        public string func_name { get; set; }
        public Nullable<short> func_type { get; set; }
        public string func_prototype { get; set; }
        public Nullable<short> func_return_type { get; set; }
        public string func_param_types { get; set; }
        public Nullable<short> must_param_num { get; set; }
        public string server_func_lib { get; set; }
        public string server_func_name { get; set; }
        public string client_func_js { get; set; }
        public string client_func_name { get; set; }
        public Nullable<short> server_flag { get; set; }
        public byte[] crm_timestamp { get; set; }
    }
}
