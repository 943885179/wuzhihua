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
    
    public partial class news_type_managers
    {
        public long id { get; set; }
        public long type_id { get; set; }
        public long manager_id { get; set; }
        public Nullable<int> order_num { get; set; }
        public string ext1 { get; set; }
        public string ext2 { get; set; }
    
        public virtual news_type news_type { get; set; }
    }
}
