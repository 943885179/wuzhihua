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
    
    public partial class bul_read
    {
        public long id { get; set; }
        public long bulletin_id { get; set; }
        public long manager_id { get; set; }
        public bool read_flag { get; set; }
        public Nullable<System.DateTime> read_date { get; set; }
        public string feedback { get; set; }
        public long accountId { get; set; }
        public string ext1 { get; set; }
        public string ext2 { get; set; }
    
        public virtual bul_data bul_data { get; set; }
    }
}
