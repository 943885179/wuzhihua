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
    
    public partial class hr_pf_NumMode_OLD
    {
        public System.Guid PK_hr_pf_NumMode { get; set; }
        public Nullable<System.Guid> fk_PK_hr_pf_grademode { get; set; }
        public Nullable<decimal> nMaxValue { get; set; }
        public Nullable<decimal> nMinValue { get; set; }
        public byte[] hrts { get; set; }
        public int iRecordID { get; set; }
        public Nullable<decimal> nStatus2 { get; set; }
        public string vStatus1 { get; set; }
        public Nullable<bool> blastflag { get; set; }
    }
}
