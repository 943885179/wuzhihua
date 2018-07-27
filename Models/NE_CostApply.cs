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
    
    public partial class NE_CostApply
    {
        public System.Guid ID { get; set; }
        public byte[] ts { get; set; }
        public int AutoID { get; set; }
        public Nullable<int> IsProxyVoucher { get; set; }
        public string OperationTypeCode { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string ApplyDeptID { get; set; }
        public string ApplicantID { get; set; }
        public System.DateTime ApplyDate { get; set; }
        public Nullable<System.DateTime> PreExpenseDate { get; set; }
        public string Used { get; set; }
        public string ItemClassID { get; set; }
        public string ItemID { get; set; }
        public string VenCode { get; set; }
        public string CusCode { get; set; }
        public decimal ApplyMoney { get; set; }
        public decimal LocalMoney { get; set; }
        public string Currency { get; set; }
        public double ExchangeRate { get; set; }
        public string SpreadDeptID { get; set; }
        public Nullable<bool> IsCanLoan { get; set; }
        public Nullable<decimal> LoanLimit { get; set; }
        public Nullable<decimal> LoanMoney { get; set; }
        public Nullable<decimal> AvailableMoney { get; set; }
        public string BudgetItemID { get; set; }
        public Nullable<System.DateTime> BudgetDate { get; set; }
        public Nullable<System.DateTime> InvalidateDate { get; set; }
        public string Port1 { get; set; }
        public string Port1Value { get; set; }
        public string Port2 { get; set; }
        public string Port2Value { get; set; }
        public string Port3 { get; set; }
        public string Port3Value { get; set; }
        public string Port4 { get; set; }
        public string Port4Value { get; set; }
        public string Port5 { get; set; }
        public string Port5Value { get; set; }
        public string Port6 { get; set; }
        public string Port6Value { get; set; }
        public Nullable<int> OverBudget { get; set; }
        public string OverBudgetAuditDesc { get; set; }
        public Nullable<System.DateTime> OverBudgetAuditDate { get; set; }
        public string OverBudgetAuditor { get; set; }
        public string EntryID { get; set; }
        public System.DateTime EntryDate { get; set; }
        public string ModifierID { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public string SummittedBy { get; set; }
        public Nullable<System.DateTime> SummmitDate { get; set; }
        public string AuditorID { get; set; }
        public Nullable<System.DateTime> AuditDate { get; set; }
        public string AuditInfo { get; set; }
        public Nullable<int> VouchState { get; set; }
        public Nullable<bool> IsAudit { get; set; }
        public Nullable<int> BudgetState { get; set; }
        public bool IsClose { get; set; }
        public string cDefine1 { get; set; }
        public string cDefine2 { get; set; }
        public string cDefine3 { get; set; }
        public Nullable<System.DateTime> cDefine4 { get; set; }
        public Nullable<int> cDefine5 { get; set; }
        public Nullable<System.DateTime> cDefine6 { get; set; }
        public Nullable<double> cDefine7 { get; set; }
        public string cDefine8 { get; set; }
        public string cDefine9 { get; set; }
        public string cDefine10 { get; set; }
        public string cDefine11 { get; set; }
        public string cDefine12 { get; set; }
        public string cDefine13 { get; set; }
        public string cDefine14 { get; set; }
        public Nullable<int> cDefine15 { get; set; }
        public Nullable<double> cDefine16 { get; set; }
        public string Verifier { get; set; }
        public Nullable<System.DateTime> VerifyDate { get; set; }
        public Nullable<int> IVerifyState { get; set; }
        public Nullable<System.DateTime> AuditDateTime { get; set; }
        public Nullable<int> IReturnCount { get; set; }
        public Nullable<int> IsWfControlled { get; set; }
        public Nullable<int> AuditState { get; set; }
        public Nullable<int> PrintCount { get; set; }
        public Nullable<bool> IsAutoGenerate { get; set; }
        public Nullable<bool> IsAutoClosed { get; set; }
        public Nullable<bool> IsFinalAudit { get; set; }
        public Nullable<int> UAPRuntime_RowNO { get; set; }
        public string Formula { get; set; }
        public string SystemID { get; set; }
        public string OA_VouchID { get; set; }
        public string Attachment { get; set; }
        public string Attachment_UAPRuntime_FileID { get; set; }
        public string cSysBarCode { get; set; }
        public string OverBudgetDesc { get; set; }
        public string cCurrentAuditor { get; set; }
        public string WFAuditorName { get; set; }
        public Nullable<int> WFAction { get; set; }
        public string WFOpinion { get; set; }
        public Nullable<System.DateTime> WFAuditDate { get; set; }
        public string cCurrentAuditorID { get; set; }
        public string SourceVoucherID { get; set; }
        public string SourceVoucherCode { get; set; }
        public Nullable<int> SourceType { get; set; }
        public Nullable<decimal> ActionCode { get; set; }
        public Nullable<int> Stage { get; set; }
        public Nullable<decimal> ReimbursedMoney { get; set; }
        public Nullable<decimal> ExpendedMoney { get; set; }
        public Nullable<decimal> LocalReimbursedMoney { get; set; }
        public Nullable<decimal> LocalExpendedMoney { get; set; }
        public Nullable<int> ivtid { get; set; }
        public Nullable<int> OriginalOverBudget { get; set; }
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
        public Nullable<decimal> OverBudgetMoney { get; set; }
        public Nullable<decimal> MaxRowVoucherMoney { get; set; }
        public Nullable<decimal> SumRowVoucherMoney { get; set; }
        public int IsOverBudget { get; set; }
        public bool IsOverBudgetAudit { get; set; }
        public string BudgetResultInfo { get; set; }
        public Nullable<bool> IsOrdered { get; set; }
        public Nullable<bool> IsSynchro { get; set; }
        public string BankCode { get; set; }
        public string BankAccount { get; set; }
    }
}
