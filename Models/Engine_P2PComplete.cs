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
    
    public partial class Engine_P2PComplete
    {
        public string MsgID { get; set; }
        public string OriginMsgID { get; set; }
        public int OriginAppSys { get; set; }
        public Nullable<int> OriginAppType { get; set; }
        public Nullable<int> OriginAppTag { get; set; }
        public Nullable<int> OriginMsgType { get; set; }
        public bool Completed { get; set; }
        public int TotalTaskCount { get; set; }
        public int CurrentTaskCount { get; set; }
        public bool Synchronized { get; set; }
        public bool OnLine { get; set; }
        public Nullable<long> RepSize { get; set; }
        public string ReportGather { get; set; }
        public System.DateTime InsertTimestamp { get; set; }
    }
}
