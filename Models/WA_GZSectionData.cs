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
    
    public partial class WA_GZSectionData
    {
        public string cGZGradeNum { get; set; }
        public string cPsn_Num { get; set; }
        public string cPsn_Name { get; set; }
        public string cDept_Num { get; set; }
        public int iYear { get; set; }
        public int iMonth { get; set; }
        public Nullable<bool> bLastFlag { get; set; }
        public int iRecordID { get; set; }
        public string cJobCode { get; set; }
        public int iPeriodNum { get; set; }
        public System.DateTime dBeginDate { get; set; }
        public System.DateTime dEndDate { get; set; }
        public int F_10000 { get; set; }
        public int iPayMonth { get; set; }
        public System.DateTime iCreatedDate { get; set; }
    
        public virtual Department Department { get; set; }
    }
}
