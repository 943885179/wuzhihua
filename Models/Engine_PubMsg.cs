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
    
    public partial class Engine_PubMsg
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Engine_PubMsg()
        {
            this.Engine_PubChannelTask = new HashSet<Engine_PubChannelTask>();
        }
    
        public string MsgID { get; set; }
        public string MsgContent { get; set; }
        public string MsgFileName { get; set; }
        public Nullable<long> MsgSize { get; set; }
        public int PriorLevel { get; set; }
        public string OriginMsgType { get; set; }
        public string OriginEntityTag { get; set; }
        public string OriginAppType { get; set; }
        public string OriginAppTag { get; set; }
        public int RetryCount { get; set; }
        public System.DateTime ExpiresTime { get; set; }
        public bool OnLine { get; set; }
        public bool Performed { get; set; }
        public System.DateTime InsertTimestamp { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Engine_PubChannelTask> Engine_PubChannelTask { get; set; }
    }
}
