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
    
    public partial class mt_reply
    {
        public long id { get; set; }
        public Nullable<long> meeting_id { get; set; }
        public long user_id { get; set; }
        public int feedback_flag { get; set; }
        public string feedback { get; set; }
        public Nullable<System.DateTime> read_date { get; set; }
        public string ext1 { get; set; }
        public string ext2 { get; set; }
        public Nullable<int> look_state { get; set; }
        public Nullable<System.DateTime> look_time { get; set; }
    
        public virtual mt_meeting mt_meeting { get; set; }
    }
}
