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
    
    public partial class tc_mng_dept
    {
        public string mng_dept_id { get; set; }
        public string mng_parent_id { get; set; }
        public string mng_dept_name { get; set; }
        public string mng_dept_code { get; set; }
        public string mng_dept_intro { get; set; }
        public string tree_path { get; set; }
        public short tree_level { get; set; }
        public short stop_flag { get; set; }
        public short server_flag { get; set; }
        public byte[] crm_timestamp { get; set; }
    }
}
