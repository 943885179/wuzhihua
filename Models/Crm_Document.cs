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
    
    public partial class Crm_Document
    {
        public string OID { get; set; }
        public int AutoID { get; set; }
        public Nullable<int> bcSourceType { get; set; }
        public string SourceID { get; set; }
        public string cDocCode { get; set; }
        public string cSubject { get; set; }
        public Nullable<double> fFileSize { get; set; }
        public string cDocAddress { get; set; }
        public string cCreator { get; set; }
        public Nullable<System.DateTime> dCreatDate { get; set; }
        public string cRevisor { get; set; }
        public string cMemo { get; set; }
        public byte[] ufts { get; set; }
    }
}
