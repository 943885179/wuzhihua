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
    
    public partial class hr_tm_Machine
    {
        public System.Guid Pk_hr_tm_Machine { get; set; }
        public int iMachineNo { get; set; }
        public string vDescription { get; set; }
        public Nullable<int> iCom { get; set; }
        public string vLinkType { get; set; }
        public string vstatus1 { get; set; }
        public Nullable<decimal> nstatus2 { get; set; }
    }
}
