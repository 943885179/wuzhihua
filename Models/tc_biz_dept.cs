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
    
    public partial class tc_biz_dept
    {
        public string biz_dept_id { get; set; }
        public string biz_parent_id { get; set; }
        public string biz_dept_name { get; set; }
        public string biz_dept_code { get; set; }
        public string biz_dept_intro { get; set; }
        public string tree_path { get; set; }
        public short tree_level { get; set; }
        public short stop_flag { get; set; }
        public short server_flag { get; set; }
        public byte[] crm_timestamp { get; set; }
    }
}
