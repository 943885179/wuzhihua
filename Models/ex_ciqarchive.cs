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
    
    public partial class ex_ciqarchive
    {
        public string guid { get; set; }
        public int id { get; set; }
        public string cciqcode { get; set; }
        public string cciqname { get; set; }
        public string ccomunitcode { get; set; }
        public Nullable<decimal> fimtaxrate { get; set; }
        public Nullable<decimal> fextaxrate { get; set; }
        public Nullable<decimal> fexrettaxrate { get; set; }
        public string cnote { get; set; }
        public byte[] ufts { get; set; }
        public string cciqenglishname { get; set; }
        public Nullable<decimal> fexciserate { get; set; }
        public Nullable<decimal> fvatrate { get; set; }
    }
}
