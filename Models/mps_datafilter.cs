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
    
    public partial class mps_datafilter
    {
        public int DFId { get; set; }
        public string DFCode { get; set; }
        public string DFDesc { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string CreateUser { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public string ModifyUser { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<System.DateTime> ModifyTime { get; set; }
        public byte[] Ufts { get; set; }
        public Nullable<int> UpdCount { get; set; }
    }
}
