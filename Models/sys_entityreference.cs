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
    
    public partial class sys_entityreference
    {
        public int ReferenceId { get; set; }
        public Nullable<int> EntityId { get; set; }
        public Nullable<int> SortSeq { get; set; }
        public string RefTableName { get; set; }
        public string RefCol { get; set; }
        public string WhereStr { get; set; }
        public string ResourceCode { get; set; }
    }
}
