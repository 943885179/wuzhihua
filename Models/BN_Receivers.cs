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
    
    public partial class BN_Receivers
    {
        public string cReceiverId { get; set; }
        public string cBizNotifyId { get; set; }
        public byte iReceiverType { get; set; }
        public string cReceiverValue { get; set; }
        public string cEmailTemplateId { get; set; }
        public string cPortalTemplateId { get; set; }
        public string cSMSTemplateId { get; set; }
        public string cUTUTemplateId { get; set; }
        public string cPhoneNo { get; set; }
        public string cEmailAddress { get; set; }
        public string OpathInfoXml { get; set; }
        public byte iSendTarget { get; set; }
        public string cTargetId { get; set; }
        public byte iTargetType { get; set; }
        public string cQueryConditionExpression { get; set; }
        public Nullable<int> iSequence { get; set; }
        public string cWeChatTemplateId { get; set; }
    }
}
