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
    
    public partial class rb_Milestones
    {
        public int ItemID { get; set; }
        public Nullable<int> ModuleID { get; set; }
        public string CreatedByUser { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string Title { get; set; }
        public Nullable<System.DateTime> EstCompleteDate { get; set; }
        public string Status { get; set; }
    
        public virtual rb_Modules rb_Modules { get; set; }
    }
}
