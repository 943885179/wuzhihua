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
    
    public partial class PM_BudItemPeriod
    {
        public int I_id { get; set; }
        public string cItemCode { get; set; }
        public string cKeyCode1 { get; set; }
        public string cKeyCode2 { get; set; }
        public Nullable<System.DateTime> dDateBegin { get; set; }
        public Nullable<System.DateTime> dDateEnd { get; set; }
        public int iPercent { get; set; }
        public Nullable<System.DateTime> dDateBeginAct { get; set; }
    }
}
