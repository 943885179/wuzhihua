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
    
    public partial class RP_FlowDZ
    {
        public int i_id { get; set; }
        public string cflowid { get; set; }
        public string cSysSource { get; set; }
        public string cSysDest { get; set; }
        public string cBillType { get; set; }
        public string cBillNo { get; set; }
        public Nullable<short> iYear { get; set; }
        public string iperiod { get; set; }
        public string csign { get; set; }
        public string iVoucherNo { get; set; }
        public string cSigner { get; set; }
        public Nullable<bool> bRef { get; set; }
    }
}
