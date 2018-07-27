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
    
    public partial class AP_ApplyPayVouchs
    {
        public int AutoID { get; set; }
        public int PID { get; set; }
        public string cSource { get; set; }
        public string cCoVouchType { get; set; }
        public string cCoVouchID { get; set; }
        public Nullable<int> iBVid { get; set; }
        public Nullable<System.Guid> BalancesGuid { get; set; }
        public string cDepCode { get; set; }
        public string cPerson { get; set; }
        public Nullable<byte> iOrderType { get; set; }
        public string cOrderNo { get; set; }
        public string cContractType { get; set; }
        public string cContractID { get; set; }
        public string cItemCode { get; set; }
        public string cItemName { get; set; }
        public string cItem_Class { get; set; }
        public decimal iApplyAmt_f { get; set; }
        public decimal iApplyAmt { get; set; }
        public Nullable<double> iApplyAmt_s { get; set; }
        public string cSrcExchName { get; set; }
        public Nullable<decimal> iSrcApplyAmt_f { get; set; }
        public Nullable<decimal> iSrcApplyAmt { get; set; }
        public Nullable<decimal> iAuditAmt_f { get; set; }
        public Nullable<decimal> iAuditAmt { get; set; }
        public Nullable<decimal> iSrcAuditAmt_f { get; set; }
        public Nullable<decimal> iSrcAuditAmt { get; set; }
        public Nullable<decimal> iPayAmt_f { get; set; }
        public Nullable<decimal> iPayAmt { get; set; }
        public Nullable<System.DateTime> dPrePayDate { get; set; }
        public Nullable<System.DateTime> dActPayDate { get; set; }
        public string cbg_itemcode { get; set; }
        public string cbg_itemname { get; set; }
        public string cbg_caliberkey1 { get; set; }
        public string cbg_caliberkeyname1 { get; set; }
        public string cbg_caliberkey2 { get; set; }
        public string cbg_caliberkeyname2 { get; set; }
        public string cbg_caliberkey3 { get; set; }
        public string cbg_caliberkeyname3 { get; set; }
        public string cbg_calibercode1 { get; set; }
        public string cbg_calibername1 { get; set; }
        public string cbg_calibercode2 { get; set; }
        public string cbg_calibername2 { get; set; }
        public string cbg_calibercode3 { get; set; }
        public string cbg_calibername3 { get; set; }
        public Nullable<bool> ibg_ctrl { get; set; }
        public string cbg_auditopinion { get; set; }
        public string cDefine22 { get; set; }
        public string cDefine23 { get; set; }
        public string cDefine24 { get; set; }
        public string cDefine25 { get; set; }
        public Nullable<double> cDefine26 { get; set; }
        public Nullable<double> cDefine27 { get; set; }
        public string cDefine28 { get; set; }
        public string cDefine29 { get; set; }
        public string cDefine30 { get; set; }
        public string cDefine31 { get; set; }
        public string cDefine32 { get; set; }
        public string cDefine33 { get; set; }
        public Nullable<int> cDefine34 { get; set; }
        public Nullable<int> cDefine35 { get; set; }
        public Nullable<System.DateTime> cDefine36 { get; set; }
        public Nullable<System.DateTime> cDefine37 { get; set; }
        public string cLineCloser { get; set; }
        public Nullable<System.DateTime> dLineCloseDate { get; set; }
        public string cStageCode { get; set; }
        public string cInvCode { get; set; }
        public Nullable<int> iPOsID { get; set; }
        public string cbg_caliberkey4 { get; set; }
        public string cbg_caliberkeyname4 { get; set; }
        public string cbg_caliberkey5 { get; set; }
        public string cbg_caliberkeyname5 { get; set; }
        public string cbg_caliberkey6 { get; set; }
        public string cbg_caliberkeyname6 { get; set; }
        public string cbg_calibercode4 { get; set; }
        public string cbg_calibername4 { get; set; }
        public string cbg_calibercode5 { get; set; }
        public string cbg_calibername5 { get; set; }
        public string cbg_calibercode6 { get; set; }
        public string cbg_calibername6 { get; set; }
        public string cExpCode { get; set; }
        public string cbsysbarcode { get; set; }
        public Nullable<decimal> iOriSum { get; set; }
        public Nullable<decimal> iSum { get; set; }
        public Nullable<decimal> iOriTaxCost { get; set; }
        public Nullable<decimal> inattaxprice { get; set; }
    }
}
