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
    
    public partial class tc_resource_condtion
    {
        public decimal cond_id { get; set; }
        public decimal obj_type { get; set; }
        public string cond_name { get; set; }
        public string cond_field { get; set; }
        public string cond_oper { get; set; }
        public Nullable<decimal> cond_val { get; set; }
        public string cond_sql { get; set; }
        public string cond_val_attr { get; set; }
        public Nullable<short> server_flag { get; set; }
        public byte[] crm_timestamp { get; set; }
    }
}
