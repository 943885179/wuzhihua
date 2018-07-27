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
    
    public partial class NE_ExpenseVouch_Sub
    {
        public System.Guid ID { get; set; }
        public System.Guid ExpenseVouchID { get; set; }
        public Nullable<int> RowNO { get; set; }
        public int AutoID { get; set; }
        public Nullable<System.DateTime> BeginDate { get; set; }
        public string BeginTime { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string EmdTime { get; set; }
        public string BeginZero { get; set; }
        public string EndZero { get; set; }
        public string VehicleCode { get; set; }
        public string CostItemClassID { get; set; }
        public string CostItemID { get; set; }
        public Nullable<decimal> VouchMoney { get; set; }
        public Nullable<decimal> Number { get; set; }
        public Nullable<decimal> Rate { get; set; }
        public Nullable<decimal> Quota { get; set; }
        public Nullable<decimal> OverQuotaRate { get; set; }
        public decimal ExpenseMoney { get; set; }
        public decimal LocalMoney { get; set; }
        public Nullable<int> AttachmentNum { get; set; }
        public string Memo { get; set; }
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
        public string BudgetItemID { get; set; }
        public string Port1 { get; set; }
        public string Port1Value { get; set; }
        public string Port2 { get; set; }
        public string Port2Value { get; set; }
        public string Port3 { get; set; }
        public string Port3Value { get; set; }
        public string OverBudgetDesc { get; set; }
        public string OverBudgetAuditDesc { get; set; }
        public string ItemClassID { get; set; }
        public string ItemID { get; set; }
        public string VenCode { get; set; }
        public string CusCode { get; set; }
        public string DeptID { get; set; }
        public string ExpenserID { get; set; }
        public Nullable<decimal> BudgetAmount { get; set; }
        public string Port4 { get; set; }
        public string Port4Value { get; set; }
        public string Port5 { get; set; }
        public string Port5Value { get; set; }
        public string Port6 { get; set; }
        public string Port6Value { get; set; }
        public string SpreadDeptID { get; set; }
        public Nullable<int> UAPRuntime_RowNO { get; set; }
        public byte[] ts { get; set; }
        public Nullable<System.Guid> CostApplySubID { get; set; }
        public string Formula { get; set; }
        public string cSysBarCode { get; set; }
        public Nullable<System.Guid> RedVouchSubID { get; set; }
        public int IsErrorFlag { get; set; }
        public Nullable<bool> IsAutoCreate { get; set; }
        public string cNeDefine1 { get; set; }
        public string cNeDefine2 { get; set; }
        public string cNeDefine3 { get; set; }
        public string cNeDefine4 { get; set; }
        public string cNeDefine5 { get; set; }
        public string cNeDefine6 { get; set; }
        public string cNeDefine7 { get; set; }
        public string cNeDefine8 { get; set; }
        public string cNeDefine9 { get; set; }
        public string cNeDefine10 { get; set; }
        public string cNeDefine11 { get; set; }
        public string cNeDefine12 { get; set; }
        public string cNeDefine13 { get; set; }
        public string cNeDefine14 { get; set; }
        public string cNeDefine15 { get; set; }
        public Nullable<decimal> cNeDefine16 { get; set; }
        public Nullable<decimal> cNeDefine17 { get; set; }
        public Nullable<decimal> cNeDefine18 { get; set; }
        public Nullable<decimal> cNeDefine19 { get; set; }
        public Nullable<decimal> cNeDefine20 { get; set; }
        public Nullable<decimal> cNeDefine21 { get; set; }
        public Nullable<decimal> cNeDefine22 { get; set; }
        public Nullable<decimal> cNeDefine23 { get; set; }
        public Nullable<decimal> cNeDefine24 { get; set; }
        public Nullable<decimal> cNeDefine25 { get; set; }
        public Nullable<decimal> cNeDefine26 { get; set; }
        public Nullable<decimal> cNeDefine27 { get; set; }
        public Nullable<decimal> cNeDefine28 { get; set; }
        public Nullable<decimal> cNeDefine29 { get; set; }
        public Nullable<decimal> cNeDefine30 { get; set; }
        public Nullable<decimal> ApplyExpensedMoney { get; set; }
        public Nullable<decimal> ApplyExpensedLocalMoney { get; set; }
        public string ThirdPartyCode { get; set; }
        public Nullable<System.Guid> ThirdPartyTicketID { get; set; }
        public string OrderID { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<decimal> AmountSub { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<decimal> Tax { get; set; }
        public Nullable<decimal> OilFee { get; set; }
        public string ClassName { get; set; }
        public Nullable<decimal> PriceRate { get; set; }
    }
}
