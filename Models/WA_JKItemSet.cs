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
    
    public partial class WA_JKItemSet
    {
        public string cGZGradeNum { get; set; }
        public string cJK_id { get; set; }
        public Nullable<byte> iFileType { get; set; }
        public Nullable<int> iNumber { get; set; }
        public Nullable<int> iStart { get; set; }
        public Nullable<int> iLength { get; set; }
        public Nullable<short> iDecimal { get; set; }
        public Nullable<int> iStrNum { get; set; }
        public string cTableName { get; set; }
        public string cFieldName { get; set; }
        public string cItemName { get; set; }
        public Nullable<int> iGZItem_id { get; set; }
        public int id { get; set; }
    
        public virtual WA_GZtblset WA_GZtblset { get; set; }
        public virtual WA_JKSet WA_JKSet { get; set; }
    }
}
