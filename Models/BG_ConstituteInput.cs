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
    
    public partial class BG_ConstituteInput
    {
        public System.Guid id { get; set; }
        public string cFormCode { get; set; }
        public string cItemCode { get; set; }
        public string cTargetCode { get; set; }
        public System.Guid cCalibersId { get; set; }
        public System.Guid cHeadId { get; set; }
        public Nullable<int> iYear { get; set; }
        public Nullable<short> iPeriodType { get; set; }
        public Nullable<short> iPeriod { get; set; }
        public Nullable<decimal> fPeriod { get; set; }
        public Nullable<int> iColPos { get; set; }
        public Nullable<int> iRowPos { get; set; }
        public int iMakeYear { get; set; }
    }
}
