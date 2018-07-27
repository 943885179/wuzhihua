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
    
    public partial class SO_SODetailsHistory
    {
        public int AutoID { get; set; }
        public string cSOCode { get; set; }
        public string cInvCode { get; set; }
        public Nullable<System.DateTime> dPreDate { get; set; }
        public Nullable<double> iQuantity { get; set; }
        public Nullable<double> iNum { get; set; }
        public Nullable<double> iQuotedPrice { get; set; }
        public Nullable<double> iUnitPrice { get; set; }
        public Nullable<double> iTaxUnitPrice { get; set; }
        public Nullable<decimal> iMoney { get; set; }
        public Nullable<decimal> iTax { get; set; }
        public Nullable<decimal> iSum { get; set; }
        public Nullable<decimal> iDisCount { get; set; }
        public Nullable<double> iNatUnitPrice { get; set; }
        public Nullable<decimal> iNatMoney { get; set; }
        public Nullable<decimal> iNatTax { get; set; }
        public Nullable<decimal> iNatSum { get; set; }
        public Nullable<decimal> iNatDisCount { get; set; }
        public Nullable<double> iFHNum { get; set; }
        public Nullable<double> iFHQuantity { get; set; }
        public Nullable<decimal> iFHMoney { get; set; }
        public Nullable<double> iKPQuantity { get; set; }
        public Nullable<double> iKPNum { get; set; }
        public Nullable<decimal> iKPMoney { get; set; }
        public string cMemo { get; set; }
        public string cFree1 { get; set; }
        public string cFree2 { get; set; }
        public Nullable<int> bFH { get; set; }
        public int iSOsID { get; set; }
        public Nullable<double> KL { get; set; }
        public Nullable<double> KL2 { get; set; }
        public string cInvName { get; set; }
        public Nullable<double> iTaxRate { get; set; }
        public string cDefine22 { get; set; }
        public string cDefine23 { get; set; }
        public string cDefine24 { get; set; }
        public string cDefine25 { get; set; }
        public Nullable<double> cDefine26 { get; set; }
        public Nullable<double> cDefine27 { get; set; }
        public string cItemCode { get; set; }
        public string cItem_class { get; set; }
        public string cItemName { get; set; }
        public string cItem_CName { get; set; }
        public string cFree3 { get; set; }
        public string cFree4 { get; set; }
        public string cFree5 { get; set; }
        public string cFree6 { get; set; }
        public string cFree7 { get; set; }
        public string cFree8 { get; set; }
        public string cFree9 { get; set; }
        public string cFree10 { get; set; }
        public Nullable<decimal> iInvExchRate { get; set; }
        public string cUnitID { get; set; }
        public Nullable<int> ID { get; set; }
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
        public Nullable<decimal> FPurQuan { get; set; }
        public Nullable<double> fSaleCost { get; set; }
        public Nullable<double> fSalePrice { get; set; }
        public string cQuoCode { get; set; }
        public Nullable<int> iQuoID { get; set; }
        public string cSCloser { get; set; }
        public Nullable<System.DateTime> dPreMoDate { get; set; }
        public Nullable<int> iRowNo { get; set; }
        public Nullable<int> iCusBomID { get; set; }
        public Nullable<decimal> iMoQuantity { get; set; }
        public string cContractID { get; set; }
        public string cContractTagCode { get; set; }
        public Nullable<System.Guid> cContractRowGuid { get; set; }
        public Nullable<int> iPPartSeqID { get; set; }
        public Nullable<int> iPPartID { get; set; }
        public Nullable<decimal> iPPartQty { get; set; }
        public string cCusInvCode { get; set; }
        public string cCusInvName { get; set; }
        public Nullable<decimal> iPreKeepQuantity { get; set; }
        public Nullable<decimal> iPreKeepNum { get; set; }
        public Nullable<decimal> iPreKeepTotQuantity { get; set; }
        public Nullable<decimal> iPreKeepTotNum { get; set; }
        public Nullable<System.DateTime> dreleasedate { get; set; }
        public Nullable<decimal> fcusminprice { get; set; }
        public Nullable<decimal> fimquantity { get; set; }
        public Nullable<decimal> fomquantity { get; set; }
        public Nullable<bool> ballpurchase { get; set; }
        public long HistoryId { get; set; }
        public Nullable<byte> VariationAction { get; set; }
        public Nullable<int> VariationLogId { get; set; }
        public Nullable<byte> SubVariationAction { get; set; }
        public Nullable<bool> bOrderBOM { get; set; }
        public Nullable<byte> bOrderBOMOver { get; set; }
        public Nullable<short> idemandtype { get; set; }
        public string cdemandcode { get; set; }
        public string cdemandmemo { get; set; }
        public string cChangeFlag { get; set; }
        public string cbSysBarCode { get; set; }
        public Nullable<bool> bsaleprice { get; set; }
        public Nullable<bool> bgift { get; set; }
        public Nullable<int> forecastdid { get; set; }
        public string cdetailsdemandcode { get; set; }
        public string cdetailsdemandmemo { get; set; }
        public Nullable<decimal> fTransedQty { get; set; }
        public Nullable<decimal> fappqty { get; set; }
        public string cParentCode { get; set; }
        public string cChildCode { get; set; }
        public Nullable<decimal> fchildqty { get; set; }
        public Nullable<decimal> fchildrate { get; set; }
        public Nullable<byte> iCalcType { get; set; }
    }
}
