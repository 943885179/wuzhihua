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
    
    public partial class SR_ServiceAgType
    {
        public string OID { get; set; }
        public int AutoID { get; set; }
        public string cSerTypeCode { get; set; }
        public string cSerTypeName { get; set; }
        public Nullable<bool> bDefault { get; set; }
        public string cMemo { get; set; }
        public string cCreator { get; set; }
        public Nullable<System.DateTime> dCreatedDate { get; set; }
        public Nullable<System.DateTime> dModifiedDate { get; set; }
        public string cModifier { get; set; }
        public byte[] ufts { get; set; }
    }
}
