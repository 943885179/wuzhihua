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
    
    public partial class tc_audit_stage_define
    {
        public decimal stage_id { get; set; }
        public decimal af_id { get; set; }
        public string stage_name { get; set; }
        public Nullable<short> audit_type { get; set; }
        public Nullable<short> stop_flag { get; set; }
        public Nullable<short> disp_order { get; set; }
        public string note { get; set; }
        public Nullable<short> server_flag { get; set; }
        public byte[] crm_timestamp { get; set; }
        public Nullable<int> pass_action { get; set; }
        public Nullable<int> reject_action { get; set; }
    }
}
