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
    
    public partial class pl_CO_OmCost
    {
        public int autoid { get; set; }
        public int iperiod { get; set; }
        public string cDeptID { get; set; }
        public int iRealCoId { get; set; }
        public Nullable<decimal> fStdCost { get; set; }
        public Nullable<decimal> fRelCost { get; set; }
        public Nullable<decimal> fOmCostDif { get; set; }
        public Nullable<byte> bOmClosed { get; set; }
        public Nullable<decimal> fExPense { get; set; }
        public Nullable<decimal> fExPenseFTJC { get; set; }
        public Nullable<decimal> fExPenseFTJCNoInv { get; set; }
        public Nullable<double> iQuantity { get; set; }
        public Nullable<double> fOmCostDif_Est { get; set; }
        public Nullable<double> fOmCostDif_Js { get; set; }
    }
}
