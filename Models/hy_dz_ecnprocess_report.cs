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
    
    public partial class hy_dz_ecnprocess_report
    {
        public System.Guid ReportId { get; set; }
        public string selcol { get; set; }
        public Nullable<int> ProId { get; set; }
        public Nullable<int> DocDId { get; set; }
        public Nullable<byte> VoucherType { get; set; }
        public Nullable<int> VoucherId { get; set; }
        public Nullable<int> VoucherDId { get; set; }
        public Nullable<int> NewPartId { get; set; }
        public Nullable<byte> canautoprocess { get; set; }
        public Nullable<byte> ProcessType { get; set; }
        public byte ProcessStatus { get; set; }
        public string Process { get; set; }
        public Nullable<System.DateTime> ProcessDate { get; set; }
        public string ProcessPsn { get; set; }
        public string ReMark { get; set; }
    }
}
