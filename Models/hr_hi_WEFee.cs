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
    
    public partial class hr_hi_WEFee
    {
        public System.Guid PK_hr_hi_WEFee { get; set; }
        public string cPsn_Num { get; set; }
        public Nullable<int> iRecordID { get; set; }
        public bool blastflag { get; set; }
        public string vstatus1 { get; set; }
        public Nullable<decimal> nstatus2 { get; set; }
        public Nullable<int> iYear { get; set; }
        public Nullable<int> iMonth { get; set; }
        public Nullable<decimal> nPutUpFee { get; set; }
        public Nullable<decimal> nWaterElecFee { get; set; }
        public Nullable<decimal> nGasFee { get; set; }
        public string cMemo { get; set; }
    }
}
