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
    
    public partial class IB_ExceptionReportSubChannel
    {
        public string ID { get; set; }
        public string ChannelName { get; set; }
        public int OriginAppSys { get; set; }
        public int OriginAppType { get; set; }
        public int OriginAppTag { get; set; }
        public int OriginMsgType { get; set; }
        public string EndPointID { get; set; }
        public bool IsTemplate { get; set; }
        public string Description { get; set; }
    }
}
