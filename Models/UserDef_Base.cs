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
    
    public partial class UserDef_Base
    {
        public string cID { get; set; }
        public string cClass { get; set; }
        public string cItem { get; set; }
        public string cType { get; set; }
        public Nullable<short> iMaxLen { get; set; }
        public Nullable<short> iLength { get; set; }
        public bool bFixLength { get; set; }
        public bool bCheckVal { get; set; }
        public bool bInput { get; set; }
        public bool bArchive { get; set; }
        public short iDataSource { get; set; }
        public string cRelArchive { get; set; }
        public string cRelField { get; set; }
        public string cDefaultVal { get; set; }
        public byte[] pubufts { get; set; }
        public Nullable<byte> iDecimalDigits { get; set; }
        public string cDicDbName { get; set; }
        public string CTableDesc { get; set; }
        public Nullable<bool> bMultiSel { get; set; }
        public string cParentID { get; set; }
        public Nullable<bool> bIsUserDefAttachFile { get; set; }
    }
}
