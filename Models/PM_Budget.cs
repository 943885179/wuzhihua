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
    
    public partial class PM_Budget
    {
        public int I_id { get; set; }
        public int iVerId { get; set; }
        public string cItemCode { get; set; }
        public string cKeyCode1 { get; set; }
        public string cKeyCode2 { get; set; }
        public string cElementCode { get; set; }
        public Nullable<double> iNumber { get; set; }
        public Nullable<decimal> iUPrice { get; set; }
        public decimal iBudget { get; set; }
        public Nullable<decimal> iMoneySum { get; set; }
        public Nullable<decimal> iMoneyCtl { get; set; }
        public Nullable<double> iNumberAdd { get; set; }
        public Nullable<decimal> iBudgetAdd { get; set; }
        public string cRemark { get; set; }
    }
}
