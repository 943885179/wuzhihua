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
    
    public partial class UA_Account_sub_Ex
    {
        public string cAcc_Id { get; set; }
        public short iYear { get; set; }
        public string cSub_Id { get; set; }
        public bool bIsDelete { get; set; }
        public Nullable<bool> bClosing { get; set; }
        public Nullable<byte> iModiPeri { get; set; }
        public Nullable<System.DateTime> dSubSysUsed { get; set; }
        public string cUser_Id { get; set; }
        public Nullable<System.DateTime> dSubOriDate { get; set; }
    }
}
