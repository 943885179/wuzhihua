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
    
    public partial class hr_tr_resevaluate
    {
        public System.Guid PK_hr_tr_resevaluate { get; set; }
        public string vactcode { get; set; }
        public System.Guid fk_PK_hr_tr_activity { get; set; }
        public string rrestype { get; set; }
        public string vrescode { get; set; }
        public string revaluateresult { get; set; }
        public byte[] hrts { get; set; }
        public Nullable<int> irecordid { get; set; }
        public Nullable<bool> blastflag { get; set; }
        public string vwholeevaluate { get; set; }
        public Nullable<decimal> nstatus2 { get; set; }
        public string vstatus1 { get; set; }
    }
}
