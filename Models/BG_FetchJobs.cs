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
    
    public partial class BG_FetchJobs
    {
        public System.Guid cJobID { get; set; }
        public string cPlanID { get; set; }
        public string cPlanName { get; set; }
        public Nullable<int> iBeginPeriod { get; set; }
        public Nullable<int> iEndPeriod { get; set; }
        public short iFrequency { get; set; }
        public int iSpace { get; set; }
        public Nullable<int> iLocation { get; set; }
        public string cUserName { get; set; }
        public Nullable<System.DateTime> dPlanDate { get; set; }
        public System.DateTime dStartup { get; set; }
        public byte[] tStamp { get; set; }
        public byte iJobType { get; set; }
        public int iMakeYear { get; set; }
    }
}
