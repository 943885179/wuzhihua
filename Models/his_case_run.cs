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
    
    public partial class his_case_run
    {
        public long id { get; set; }
        public string casename { get; set; }
        public string startuser { get; set; }
        public string lastperformer { get; set; }
        public decimal state { get; set; }
        public Nullable<decimal> subprocess { get; set; }
        public Nullable<decimal> startsubprocessnum { get; set; }
        public string processindex { get; set; }
        public string processname { get; set; }
        public string processid { get; set; }
        public long startdate { get; set; }
        public long updatedate { get; set; }
        public byte[] caseobject { get; set; }
    }
}
