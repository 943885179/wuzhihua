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
    
    public partial class Ven_Inv_Price_RuleItem
    {
        public long ID { get; set; }
        public int itemId { get; set; }
        public double iLowerLimit { get; set; }
        public Nullable<double> iUpperLimit { get; set; }
        public double iUnitPrice { get; set; }
        public double iTaxRate { get; set; }
        public double iTaxUnitPrice { get; set; }
    
        public virtual Ven_Inv_Price_Rule Ven_Inv_Price_Rule { get; set; }
    }
}
