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
    
    public partial class hr_tr_calUnAttendSubPsn
    {
        public Nullable<System.Guid> PK_hr_tr_calUnAttendSubPsn { get; set; }
        public string cPsn_Num { get; set; }
        public Nullable<System.Guid> fk_PK_hr_tr_subject { get; set; }
        public Nullable<bool> bGenerateReq { get; set; }
        public byte[] hrts { get; set; }
    }
}
