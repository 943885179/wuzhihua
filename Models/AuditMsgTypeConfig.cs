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
    
    public partial class AuditMsgTypeConfig
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AuditMsgTypeConfig()
        {
            this.AuditRouteRules = new HashSet<AuditRouteRules>();
        }
    
        public string cMsgTypeId { get; set; }
        public string cMsgTypeName { get; set; }
        public string cMsgTypeDesc { get; set; }
        public string cBizObjectId { get; set; }
        public string cCompBizEntityId { get; set; }
        public string MOMRegPath { get; set; }
        public string MsgSchema { get; set; }
        public string cKeyFidldPath { get; set; }
        public string cBizEventId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AuditRouteRules> AuditRouteRules { get; set; }
    }
}
