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
    
    public partial class FD_Option
    {
        public bool Alarm { get; set; }
        public short Aldays { get; set; }
        public Nullable<short> DzdRows { get; set; }
        public Nullable<System.DateTime> Option1 { get; set; }
        public Nullable<bool> Option2 { get; set; }
        public string Option3 { get; set; }
        public Nullable<bool> schedule_flag { get; set; }
        public Nullable<byte> dzdorder_flag { get; set; }
        public Nullable<bool> lxdzero_flag { get; set; }
        public Nullable<bool> lxdnegative_flag { get; set; }
        public Nullable<short> lxddelay_num { get; set; }
        public Nullable<bool> autoreturn_flag { get; set; }
        public string returnorder_lev { get; set; }
        public Nullable<bool> limitloan_flag { get; set; }
        public Nullable<short> reply_num { get; set; }
        public Nullable<bool> jz_flag { get; set; }
        public Nullable<int> loan_limit_num { get; set; }
        public Nullable<bool> b_compute_balance { get; set; }
        public Nullable<bool> b_control_cheque { get; set; }
        public int iYear { get; set; }
    }
}
