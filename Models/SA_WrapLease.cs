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
    
    public partial class SA_WrapLease
    {
        public int AutoID { get; set; }
        public Nullable<bool> bIWLType { get; set; }
        public string cWLCode { get; set; }
        public string cCusCode { get; set; }
        public string cDLCode { get; set; }
        public string cSBVCode { get; set; }
        public string cInvCode { get; set; }
        public System.DateTime dDate { get; set; }
        public Nullable<double> iWLAmount { get; set; }
        public Nullable<decimal> iWLMoney { get; set; }
        public string cReceiver { get; set; }
        public Nullable<double> iHandBackAmount { get; set; }
        public Nullable<decimal> iHandBackMoney { get; set; }
        public string cMemo { get; set; }
        public string cHandler { get; set; }
        public string cDepCode { get; set; }
        public Nullable<int> DLID { get; set; }
        public Nullable<int> SBVID { get; set; }
        public string cItemCode { get; set; }
        public string cItem_class { get; set; }
        public int iVTid { get; set; }
        public byte[] ufts { get; set; }
        public string cCusInvCode { get; set; }
        public string cCusInvName { get; set; }
        public string cSysBarCode { get; set; }
    
        public virtual Customer Customer { get; set; }
    }
}
