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
    
    public partial class exch
    {
        public int i_id { get; set; }
        public string cexch_name { get; set; }
        public byte iperiod { get; set; }
        public byte itype { get; set; }
        public string cdate { get; set; }
        public double nflat { get; set; }
        public byte[] pubufts { get; set; }
        public Nullable<int> iYear { get; set; }
    }
}
