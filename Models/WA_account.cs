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
    
    public partial class WA_account
    {
        public string cGZGradeNum { get; set; }
        public string cGZGradename { get; set; }
        public bool bHZGrade { get; set; }
        public Nullable<bool> bOnlyGZGrade { get; set; }
        public Nullable<System.DateTime> dStart_time { get; set; }
        public Nullable<bool> bOpenClose { get; set; }
        public string cMoney { get; set; }
        public Nullable<bool> bBank { get; set; }
        public Nullable<bool> bMinus_tax { get; set; }
        public Nullable<bool> bInteger { get; set; }
        public byte iInteger_DW { get; set; }
        public byte iPsn_len { get; set; }
        public Nullable<byte> iLastMonth { get; set; }
        public short iLastYear { get; set; }
        public Nullable<bool> bPRCal { get; set; }
        public string cGZDLCode { get; set; }
        public string cFFCSName { get; set; }
        public Nullable<int> iTaxYD { get; set; }
        public Nullable<int> iTaxNZ { get; set; }
        public Nullable<int> iCheckFlag { get; set; }
        public Nullable<bool> bSectionPay { get; set; }
        public Nullable<int> iSectionPeriodType { get; set; }
        public Nullable<int> iSectionPeriod { get; set; }
    }
}
