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
    
    public partial class v3x_ca_account
    {
        public long id { get; set; }
        public string key_num { get; set; }
        public long member_id { get; set; }
        public string which_module { get; set; }
        public byte ca_state { get; set; }
        public byte ca_enable { get; set; }
        public byte mobile_enable { get; set; }
        public byte check_enable { get; set; }
    }
}
