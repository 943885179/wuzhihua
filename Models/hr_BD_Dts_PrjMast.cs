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
    
    public partial class hr_BD_Dts_PrjMast
    {
        public System.Guid prjID { get; set; }
        public string prjName { get; set; }
        public Nullable<int> InputModel { get; set; }
        public string connString { get; set; }
        public Nullable<int> DataSourceType { get; set; }
        public string sqlText { get; set; }
        public Nullable<int> sqlType { get; set; }
        public string parentTab { get; set; }
        public string RecField { get; set; }
        public string FlagField { get; set; }
        public string ParentField { get; set; }
        public string RefField { get; set; }
        public Nullable<int> RecClFs { get; set; }
        public Nullable<int> FlagFieldClFs { get; set; }
        public Nullable<int> TableTypeID { get; set; }
        public string cTableCode { get; set; }
        public Nullable<int> iTableType { get; set; }
        public string wheresql { get; set; }
        public string RecPXZd { get; set; }
        public string FlagClZd { get; set; }
        public string UserName { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<int> SysPrj { get; set; }
    }
}
