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
    
    public partial class hr_staff_transfer
    {
        public long id { get; set; }
        public Nullable<int> type { get; set; }
        public Nullable<System.DateTime> refer_time { get; set; }
        public Nullable<System.DateTime> deal_time { get; set; }
        public Nullable<System.DateTime> transfer_time { get; set; }
        public Nullable<long> fromDepartment { get; set; }
        public Nullable<long> toDepartment { get; set; }
        public Nullable<long> fromLevel { get; set; }
        public Nullable<long> toLevel { get; set; }
        public Nullable<long> fromPost { get; set; }
        public Nullable<long> toPost { get; set; }
        public Nullable<int> fromMember_type { get; set; }
        public Nullable<int> toMember_type { get; set; }
        public Nullable<int> fromMember_state { get; set; }
        public Nullable<int> toMember_state { get; set; }
        public Nullable<int> state { get; set; }
        public string reason { get; set; }
        public Nullable<long> member_id { get; set; }
    
        public virtual hr_staff_transfer_type hr_staff_transfer_type { get; set; }
    }
}
