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
    
    public partial class pl_CO_InventoryNum_DifDetails
    {
        public int Ia_AutoId { get; set; }
        public string cInvCode { get; set; }
        public string cWarhouse { get; set; }
        public byte iDimension { get; set; }
        public string cRdCode { get; set; }
        public Nullable<byte> iVoucherType { get; set; }
        public Nullable<long> modid { get; set; }
        public double iNum { get; set; }
        public double iTransferNum { get; set; }
        public string cBusDepCode { get; set; }
        public int iPartId { get; set; }
        public Nullable<bool> bTransferOut { get; set; }
        public Nullable<bool> bOrtherOut { get; set; }
    }
}
