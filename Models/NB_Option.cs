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
    
    public partial class NB_Option
    {
        public string cAccountNumber { get; set; }
        public bool bQueryBalance { get; set; }
        public Nullable<bool> bQueryDailyDetail { get; set; }
        public Nullable<byte> iBalanceInterval { get; set; }
        public Nullable<bool> bPopupWindow { get; set; }
        public Nullable<System.DateTime> dQueryDetailTime { get; set; }
        public Nullable<bool> bStoreTo { get; set; }
        public string cStoreDir { get; set; }
    }
}
