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
    
    public partial class rb_OrderDetails
    {
        public string OrderID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public string ModelName { get; set; }
        public string ModelNumber { get; set; }
        public decimal UnitPrice { get; set; }
        public float Weight { get; set; }
        public string MetadataXml { get; set; }
    
        public virtual rb_Orders rb_Orders { get; set; }
    }
}
