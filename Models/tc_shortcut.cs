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
    
    public partial class tc_shortcut
    {
        public string user_id { get; set; }
        public string sys_type { get; set; }
        public decimal menu_id { get; set; }
        public decimal type_id { get; set; }
        public string title { get; set; }
        public Nullable<decimal> disp_order { get; set; }
        public string url { get; set; }
        public string target { get; set; }
        public string img { get; set; }
        public Nullable<short> server_flag { get; set; }
        public byte[] crm_timestamp { get; set; }
    }
}
