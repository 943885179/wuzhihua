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
    
    public partial class EX_COURSESETS_DEMO
    {
        public int SUBID { get; set; }
        public int MAINID { get; set; }
        public string CBUSTACHECODE { get; set; }
        public string CBUSTACHENAME { get; set; }
        public string CBUSTACHEEXPLAIN { get; set; }
        public string CEXECUTEORDER { get; set; }
    
        public virtual EX_COURSESET_DEMO EX_COURSESET_DEMO { get; set; }
    }
}
