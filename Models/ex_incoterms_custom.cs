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
    
    public partial class ex_incoterms_custom
    {
        public string guid { get; set; }
        public int iincotermid { get; set; }
        public string cincotermcode { get; set; }
        public string cincotermsremark { get; set; }
        public Nullable<short> istartused { get; set; }
        public Nullable<short> idefault { get; set; }
        public byte[] ufts { get; set; }
        public string cincotermsmemo { get; set; }
        public Nullable<bool> bprefab { get; set; }
    }
}
