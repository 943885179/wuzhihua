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
    
    public partial class HR_BD_RPT_SECTION
    {
        public int iRptCode { get; set; }
        public int iSectionID { get; set; }
        public int iBeginRow { get; set; }
        public string vGroupField { get; set; }
        public Nullable<bool> bNewPage { get; set; }
        public Nullable<int> iPageRecCount { get; set; }
        public string vFunction { get; set; }
        public string vGroupDesc { get; set; }
        public Nullable<bool> bSortDir { get; set; }
    }
}
