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
    
    public partial class rel_receipt_privilege
    {
        public decimal p_id { get; set; }
        public decimal receipt_id { get; set; }
        public short privilege_type { get; set; }
        public decimal privilege_id { get; set; }
        public short is_self { get; set; }
        public short server_flag { get; set; }
        public byte[] crm_timestamp { get; set; }
    }
}
