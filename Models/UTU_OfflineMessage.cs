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
    
    public partial class UTU_OfflineMessage
    {
        public System.Guid uidID { get; set; }
        public string cToAccount { get; set; }
        public byte[] Msg { get; set; }
        public string cFromAccount { get; set; }
        public System.DateTime dSendTime { get; set; }
        public int iMessageType { get; set; }
        public string cChatIdentify { get; set; }
    }
}
