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
    
    public partial class CN_NoteImage
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public Nullable<int> Type { get; set; }
        public string KeyValue { get; set; }
        public byte[] Data { get; set; }
        public Nullable<int> Width { get; set; }
        public Nullable<int> Height { get; set; }
    }
}
