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
    
    public partial class HR_BD_AnalyItem
    {
        public Nullable<int> iDirID { get; set; }
        public int iAnalysisID { get; set; }
        public string vAnalysisName { get; set; }
        public string vTableCode { get; set; }
        public Nullable<int> iSetType { get; set; }
        public Nullable<int> iAnalysisWay { get; set; }
        public string vTargetTable { get; set; }
        public string vTargetField { get; set; }
        public Nullable<byte> iTargetFieldDataType { get; set; }
        public string vTargetFieldDesc { get; set; }
        public string vSubID { get; set; }
        public string vFunc { get; set; }
        public string vTargetDesc { get; set; }
        public string cUserID { get; set; }
        public Nullable<bool> bShared { get; set; }
        public string vDrvTable { get; set; }
        public string vClsCode { get; set; }
        public string vStatContent { get; set; }
    }
}
