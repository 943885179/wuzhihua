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
    
    public partial class tc_recurrence
    {
        public decimal recur_id { get; set; }
        public System.DateTime recur_start_date { get; set; }
        public System.DateTime recur_end_date { get; set; }
        public short recur_type { get; set; }
        public Nullable<short> month_of_year { get; set; }
        public Nullable<short> day_of_month { get; set; }
        public Nullable<short> day_of_weekmask { get; set; }
        public Nullable<short> instance { get; set; }
        public Nullable<short> intervals { get; set; }
        public Nullable<short> occurrences { get; set; }
        public Nullable<short> server_flag { get; set; }
        public byte[] crm_timestamp { get; set; }
    }
}
