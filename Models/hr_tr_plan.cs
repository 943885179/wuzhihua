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
    
    public partial class hr_tr_plan
    {
        public string vplanname { get; set; }
        public string rplanlevel { get; set; }
        public string rplandpt { get; set; }
        public string rplantype { get; set; }
        public int iplanyear { get; set; }
        public Nullable<int> iplanseason { get; set; }
        public Nullable<int> iplanmonth { get; set; }
        public Nullable<decimal> nplanbudget { get; set; }
        public string rorganizer { get; set; }
        public string dauthorize { get; set; }
        public string vremark { get; set; }
        public System.Guid PK_hr_tr_plan { get; set; }
        public Nullable<int> irecordid { get; set; }
        public Nullable<bool> blastflag { get; set; }
        public Nullable<decimal> nstatus2 { get; set; }
        public string vstatus1 { get; set; }
        public byte[] hrts { get; set; }
    }
}
