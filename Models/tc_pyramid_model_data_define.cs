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
    
    public partial class tc_pyramid_model_data_define
    {
        public decimal data_define_id { get; set; }
        public decimal obj_type { get; set; }
        public string attr_name { get; set; }
        public Nullable<short> is_obj_attr { get; set; }
        public Nullable<short> is_rel_obj { get; set; }
        public Nullable<decimal> rel_obj_type { get; set; }
        public Nullable<short> opr_type { get; set; }
        public string opr_attr_name { get; set; }
        public string data_name { get; set; }
        public string calfunc { get; set; }
        public string fldname { get; set; }
        public Nullable<short> server_flag { get; set; }
        public byte[] crm_timestamp { get; set; }
    }
}
