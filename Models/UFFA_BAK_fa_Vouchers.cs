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
    
    public partial class UFFA_BAK_fa_Vouchers
    {
        public string sNum { get; set; }
        public string sCardNum { get; set; }
        public int lOptID { get; set; }
        public string sZWVoucherType { get; set; }
        public string sZWVoucherNum { get; set; }
        public Nullable<int> lPreOptID { get; set; }
        public short iVoucherType { get; set; }
        public string sItemID { get; set; }
        public string sVoucherName { get; set; }
        public string sVoucherEngName { get; set; }
        public string sBeforeVoucher { get; set; }
        public string sAfterVoucher { get; set; }
        public string memReason { get; set; }
        public Nullable<System.DateTime> dTransdate { get; set; }
        public Nullable<short> iTransPeriod { get; set; }
        public string sOperatorVou { get; set; }
        public string sCurrencyVou { get; set; }
        public Nullable<double> dblExchangeRateVou { get; set; }
        public string sSiteAfter { get; set; }
        public string sLockedBy { get; set; }
        public bool bAct { get; set; }
        public bool bGroup { get; set; }
        public short imonthJZ { get; set; }
        public short iyearJZ { get; set; }
        public string sKeeperAfter { get; set; }
        public string dblAddValueVou { get; set; }
    }
}
