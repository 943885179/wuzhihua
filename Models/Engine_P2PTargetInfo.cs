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
    
    public partial class Engine_P2PTargetInfo
    {
        public string TargetEntityTag { get; set; }
        public string TargetAppType { get; set; }
        public string TargetAppTag { get; set; }
        public string TargetMsgType { get; set; }
        public string MsgID { get; set; }
        public bool MustReturn { get; set; }
    
        public virtual Engine_P2PMsg Engine_P2PMsg { get; set; }
    }
}
