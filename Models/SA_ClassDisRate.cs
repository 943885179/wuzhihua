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
    
    public partial class SA_ClassDisRate
    {
        public int Autoid { get; set; }
        public int iType { get; set; }
        public string cCusCCode { get; set; }
        public string cCusCode { get; set; }
        public string cInvCCode { get; set; }
        public decimal iDisRate { get; set; }
        public string cMemo { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual CustomerClass CustomerClass { get; set; }
        public virtual InventoryClass InventoryClass { get; set; }
    }
}
