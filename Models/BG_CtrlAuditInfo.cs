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
    
    public partial class BG_CtrlAuditInfo
    {
        public System.Guid cAccountId { get; set; }
        public string cSysid { get; set; }
        public string cPKID { get; set; }
        public string cAuditInfoXml { get; set; }
        public byte[] tStamp { get; set; }
        public Nullable<short> iYear { get; set; }
    }
}
