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
    
    public partial class mom_remorder
    {
        public int MoDId { get; set; }
        public Nullable<int> PartProLineId { get; set; }
        public Nullable<int> PartProLineDId { get; set; }
        public Nullable<decimal> DailyQty { get; set; }
        public Nullable<decimal> AuxDailyQty { get; set; }
        public Nullable<int> Days { get; set; }
        public Nullable<System.DateTime> FUSD { get; set; }
        public Nullable<System.DateTime> FUCD { get; set; }
        public Nullable<System.DateTime> LUSD { get; set; }
        public Nullable<System.DateTime> LUCD { get; set; }
        public Nullable<decimal> OrgDays { get; set; }
        public byte[] Ufts { get; set; }
        public Nullable<int> WcId { get; set; }
        public Nullable<int> MoId { get; set; }
    
        public virtual mom_orderdetail mom_orderdetail { get; set; }
    }
}
