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
    
    public partial class BG_FetchLog
    {
        public System.Guid cFLId { get; set; }
        public Nullable<System.DateTime> dFetchDate { get; set; }
        public Nullable<int> iBeginPeriod { get; set; }
        public Nullable<int> iEndPeriod { get; set; }
        public Nullable<short> iCheckOutPeriod { get; set; }
        public string cResult { get; set; }
        public byte[] tStamp { get; set; }
        public string cUserID { get; set; }
        public Nullable<System.Guid> cPlanID { get; set; }
        public int iMakeYear { get; set; }
    }
}
