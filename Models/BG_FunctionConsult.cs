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
    
    public partial class BG_FunctionConsult
    {
        public System.Guid cFLID { get; set; }
        public string cFuncName { get; set; }
        public int iOrder { get; set; }
        public string cParmName { get; set; }
        public short iConsultType { get; set; }
        public string cConsultKey { get; set; }
        public string cSupParmName { get; set; }
        public string cKeyName { get; set; }
        public string cDefaultValue { get; set; }
        public bool bEdit { get; set; }
        public Nullable<bool> bGetName { get; set; }
        public Nullable<bool> bEnd { get; set; }
        public int iMakeYear { get; set; }
    }
}
