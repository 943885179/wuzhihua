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
    
    public partial class rss_item_status
    {
        public long id { get; set; }
        public int status { get; set; }
        public Nullable<long> uesr_id { get; set; }
        public long rss_item_id { get; set; }
        public long rss_subscribe_id { get; set; }
    
        public virtual rss_channel_items rss_channel_items { get; set; }
        public virtual rss_subscribe rss_subscribe { get; set; }
    }
}
