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
    
    public partial class PM_PeriodCalc
    {
        public int I_id { get; set; }
        public Nullable<int> iPeriod { get; set; }
        public System.DateTime dBegin { get; set; }
        public System.DateTime dEnd { get; set; }
        public string iPType { get; set; }
        public Nullable<bool> bCalc { get; set; }
        public Nullable<bool> bRecord { get; set; }
    }
}
