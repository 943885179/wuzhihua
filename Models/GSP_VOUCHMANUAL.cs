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
    
    public partial class GSP_VOUCHMANUAL
    {
        public int ID { get; set; }
        public string CCODE { get; set; }
        public string CNAME { get; set; }
        public string CDEPCODE { get; set; }
        public string CMAKER { get; set; }
        public string CVERIFIER { get; set; }
        public string CAPPROVER { get; set; }
        public string CVOUCHTYPE { get; set; }
        public Nullable<System.DateTime> DDATE { get; set; }
        public byte[] UFTS { get; set; }
        public Nullable<int> IVTID { get; set; }
        public string CPATH { get; set; }
        public string CTEMPATH { get; set; }
        public Nullable<int> FYEAR { get; set; }
        public byte[] CFILE { get; set; }
    }
}
