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
    
    public partial class v3x_bbs_article_issue_area
    {
        public long id { get; set; }
        public long v3x_bbs_article_id { get; set; }
        public Nullable<long> module_id { get; set; }
        public string module_type { get; set; }
        public Nullable<System.DateTime> issue_time { get; set; }
    
        public virtual v3x_bbs_article v3x_bbs_article { get; set; }
    }
}
