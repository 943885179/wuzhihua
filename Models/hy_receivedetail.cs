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
    
    public partial class hy_receivedetail
    {
        public int receiveDId { get; set; }
        public Nullable<int> receiveId { get; set; }
        public Nullable<int> iSortSeq { get; set; }
        public Nullable<int> iOrderDId { get; set; }
        public Nullable<int> iOrderId { get; set; }
        public Nullable<int> iMoRoutingDId { get; set; }
        public Nullable<decimal> iQuantity { get; set; }
        public string cUnitID { get; set; }
        public Nullable<decimal> iNum { get; set; }
        public Nullable<decimal> iChangeRate { get; set; }
        public Nullable<decimal> iQualifiedQty { get; set; }
        public Nullable<decimal> iLabScrapQty { get; set; }
        public Nullable<decimal> iMatScrapQty { get; set; }
        public Nullable<decimal> iReworkQty { get; set; }
        public Nullable<int> iUsedVouchAutoId { get; set; }
        public string cUsedVouchCode { get; set; }
        public string cQualifiedReason { get; set; }
        public string cLabScrapReason { get; set; }
        public string cMatScrapReason { get; set; }
        public string cReworkReason { get; set; }
        public Nullable<bool> QcFlag { get; set; }
        public Nullable<bool> QcCompletion { get; set; }
        public Nullable<decimal> iDeclaredQty { get; set; }
        public Nullable<int> iMoOrderId { get; set; }
        public Nullable<int> iMoOrderDId { get; set; }
        public string cMoOrderCode { get; set; }
        public Nullable<int> iMoOrderSeq { get; set; }
        public string cHyOrderCode { get; set; }
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
        public byte[] ufts { get; set; }
        public Nullable<bool> isFirstOP { get; set; }
        public Nullable<bool> isLastOP { get; set; }
        public string cdemandcode { get; set; }
        public string cdemandmemo { get; set; }
        public Nullable<decimal> iReworkJFQty { get; set; }
        public string citem_class { get; set; }
        public string citemcode { get; set; }
        public string citemname { get; set; }
        public Nullable<byte> cSource { get; set; }
        public string InvCode { get; set; }
        public Nullable<int> PartId { get; set; }
        public string OpCode { get; set; }
        public string Description { get; set; }
        public string moDeptCode { get; set; }
        public string MoLotCode { get; set; }
        public string cFree1 { get; set; }
        public string cFree2 { get; set; }
        public string cFree3 { get; set; }
        public string cFree4 { get; set; }
        public string cFree5 { get; set; }
        public string cFree6 { get; set; }
        public string cFree7 { get; set; }
        public string cFree8 { get; set; }
        public string cFree9 { get; set; }
        public string cFree10 { get; set; }
        public Nullable<System.DateTime> dArriveDate { get; set; }
        public Nullable<int> bTaxCost { get; set; }
        public Nullable<decimal> fTaxRate { get; set; }
        public Nullable<decimal> fUnitPrice { get; set; }
        public Nullable<decimal> fMoney { get; set; }
        public Nullable<decimal> fTax { get; set; }
        public Nullable<decimal> ftaxunitprice { get; set; }
        public Nullable<decimal> fTaxSum { get; set; }
        public Nullable<decimal> fNatUnitPrice { get; set; }
        public Nullable<decimal> fNatMoney { get; set; }
        public Nullable<decimal> fNatTax { get; set; }
        public Nullable<decimal> fNatTaxPrice { get; set; }
        public Nullable<decimal> fNatTaxSum { get; set; }
        public Nullable<decimal> fValidUnitPrice { get; set; }
        public Nullable<decimal> fValidMoney { get; set; }
        public Nullable<byte> iMaScrapdealtype { get; set; }
        public Nullable<decimal> fMaScrapUnitPrice { get; set; }
        public Nullable<decimal> fMaScrapMoney { get; set; }
        public Nullable<byte> iopscrapdealtype { get; set; }
        public Nullable<decimal> fOpScrapUnitPrice { get; set; }
        public Nullable<decimal> fOpScrapMoney { get; set; }
        public Nullable<decimal> fReworkJFPrice { get; set; }
        public Nullable<decimal> fReworkJFMoney { get; set; }
        public string cbSysBarCode { get; set; }
        public Nullable<decimal> iPriceNum { get; set; }
    
        public virtual hy_receive hy_receive { get; set; }
    }
}
