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
    
    public partial class Ca_Amoct_Movement
    {
        public int iPeriod { get; set; }
        public int cPPid { get; set; }
        public string cBatch { get; set; }
        public int cPPidTo { get; set; }
        public string cBatchTo { get; set; }
        public int cAmoType { get; set; }
        public string cAmoID { get; set; }
        public Nullable<decimal> iQua { get; set; }
        public Nullable<decimal> iAmo { get; set; }
        public Nullable<double> fUseQuaRate { get; set; }
        public Nullable<double> fUseAmoRate { get; set; }
        public Nullable<int> iSource { get; set; }
    }
}
