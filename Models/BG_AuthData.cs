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
    
    public partial class BG_AuthData
    {
        public System.Guid cUID { get; set; }
        public string cUserID { get; set; }
        public Nullable<bool> bGroup { get; set; }
        public System.Guid cRelAuthID { get; set; }
        public string cAuthKey1 { get; set; }
        public string cAuthCode1 { get; set; }
        public string cAuthKey2 { get; set; }
        public string cAuthCode2 { get; set; }
        public string cAuthKey3 { get; set; }
        public string cAuthCode3 { get; set; }
        public string cAuthKey4 { get; set; }
        public string cAuthCode4 { get; set; }
        public string cAuths { get; set; }
        public int iMakeYear { get; set; }
    
        public virtual BG_AuthRelation BG_AuthRelation { get; set; }
    }
}
