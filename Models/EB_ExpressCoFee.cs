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
    
    public partial class EB_ExpressCoFee
    {
        public long AutoID { get; set; }
        public long OID { get; set; }
        public string cOrigProvinceID { get; set; }
        public string cOrigCityID { get; set; }
        public string cTargetProvinceID { get; set; }
        public string cTargetCityID { get; set; }
        public Nullable<decimal> iYkg { get; set; }
        public Nullable<decimal> iYkgPrice { get; set; }
        public Nullable<decimal> iCkg { get; set; }
        public Nullable<decimal> iCkgPrice { get; set; }
        public string cMemo { get; set; }
        public Nullable<System.DateTime> dValidDate { get; set; }
    }
}
