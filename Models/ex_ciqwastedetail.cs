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
    
    public partial class ex_ciqwastedetail
    {
        public int id { get; set; }
        public string guids { get; set; }
        public int autoid { get; set; }
        public string cinvcode { get; set; }
        public Nullable<decimal> fquantity { get; set; }
        public Nullable<decimal> fwastequantity { get; set; }
        public string cnote { get; set; }
        public Nullable<decimal> fnetquantity { get; set; }
        public Nullable<decimal> fprocesslossrate { get; set; }
    
        public virtual ex_ciqwaste ex_ciqwaste { get; set; }
    }
}
