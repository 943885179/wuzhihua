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
    
    public partial class hr_wm_precisionandlimit
    {
        public System.Guid cKey { get; set; }
        public string cprjcode { get; set; }
        public string cbooncode { get; set; }
        public string cArea { get; set; }
        public string cNatrueType { get; set; }
        public string citemcode { get; set; }
        public string cPrecision { get; set; }
        public Nullable<decimal> dUpperLimit { get; set; }
        public Nullable<decimal> dLowerLimit { get; set; }
    }
}
