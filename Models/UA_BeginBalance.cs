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
    
    public partial class UA_BeginBalance
    {
        public string strUnitID { get; set; }
        public string strUnitName { get; set; }
        public string strAccBankID { get; set; }
        public string strAccBankName { get; set; }
        public string strAccBankAccount { get; set; }
        public string strBill { get; set; }
        public Nullable<double> dblExchange { get; set; }
        public Nullable<decimal> dblBeginBalance { get; set; }
        public string strControlType { get; set; }
        public Nullable<decimal> dblOldValue { get; set; }
        public int intNoID { get; set; }
        public string cYear { get; set; }
        public Nullable<bool> isAutoCarryOver { get; set; }
    
        public virtual UA_UnitDef UA_UnitDef { get; set; }
    }
}
