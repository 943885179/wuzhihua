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
    
    public partial class hr_tr_subjectscore
    {
        public System.Guid fk_PK_hr_tr_subject { get; set; }
        public Nullable<System.Guid> fk_PK_hr_hi_training { get; set; }
        public Nullable<System.Guid> rteacher { get; set; }
        public string vteachaddress { get; set; }
        public string vteachcontent { get; set; }
        public Nullable<decimal> nteachperiod { get; set; }
        public string dteachstart { get; set; }
        public string vteachstarttime { get; set; }
        public string dteachend { get; set; }
        public string vteachendtime { get; set; }
        public Nullable<decimal> ntra_score { get; set; }
        public string rtra_result { get; set; }
        public byte[] hrts { get; set; }
        public Nullable<int> irecordid { get; set; }
        public Nullable<bool> blastflag { get; set; }
        public Nullable<decimal> nstatus2 { get; set; }
        public string vstatus1 { get; set; }
        public System.Guid PK_hr_tr_subjectscore { get; set; }
    }
}
