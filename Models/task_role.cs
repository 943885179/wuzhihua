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
    
    public partial class task_role
    {
        public long id { get; set; }
        public long role_id { get; set; }
        public byte role_type { get; set; }
        public long task_id { get; set; }
    
        public virtual task_info task_info { get; set; }
    }
}
