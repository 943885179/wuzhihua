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
    
    public partial class plan_user_scope
    {
        public long id { get; set; }
        public Nullable<long> ref_user_id { get; set; }
        public Nullable<long> ref_account_id { get; set; }
        public string ref_user_name { get; set; }
        public string scope_user_ids { get; set; }
        public string scope_user_names { get; set; }
        public Nullable<int> is_see_detail { get; set; }
    }
}
