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
    
    public partial class periodical_cal_event
    {
        public long id { get; set; }
        public string subject { get; set; }
        public Nullable<System.DateTime> begin_date { get; set; }
        public Nullable<System.DateTime> end_date { get; set; }
        public int alarm_flag { get; set; }
        public Nullable<long> alarm_date { get; set; }
        public Nullable<int> work_type { get; set; }
        public Nullable<int> event_type { get; set; }
        public Nullable<int> signify_type { get; set; }
        public Nullable<int> priority_type { get; set; }
        public Nullable<int> share_type { get; set; }
        public string share_target { get; set; }
        public string tran_member_ids { get; set; }
        public Nullable<double> real_estimate_time { get; set; }
        public int states { get; set; }
        public Nullable<int> event_flag { get; set; }
        public double complete_rate { get; set; }
        public Nullable<long> create_user_id { get; set; }
        public Nullable<System.DateTime> create_date { get; set; }
        public Nullable<System.DateTime> update_date { get; set; }
        public Nullable<int> att_flag { get; set; }
        public string receive_member_id { get; set; }
        public string receive_member_name { get; set; }
        public Nullable<int> from_type { get; set; }
        public Nullable<long> from_id { get; set; }
        public Nullable<int> cal_event_type { get; set; }
        public long beforend_alarm_date { get; set; }
        public int periodical_style { get; set; }
    }
}
