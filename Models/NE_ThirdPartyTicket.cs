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
    
    public partial class NE_ThirdPartyTicket
    {
        public System.Guid ID { get; set; }
        public Nullable<System.Guid> CostApplySubID { get; set; }
        public Nullable<System.Guid> CostApplyVouchID { get; set; }
        public Nullable<System.Guid> ExpenVouchSubID { get; set; }
        public Nullable<System.Guid> ExpenseVouchID { get; set; }
        public string CostApplyOperationType { get; set; }
        public string ExpenseOperationType { get; set; }
        public string CostApplyVouchCode { get; set; }
        public string ExpenseVouchCode { get; set; }
        public Nullable<System.Guid> OrderID { get; set; }
        public string OrderCode { get; set; }
        public string PassengerName { get; set; }
        public string NationalityCode { get; set; }
        public string NationalityName { get; set; }
        public string CardTypeName { get; set; }
        public string CardTypeNumber { get; set; }
        public Nullable<decimal> UnitInsuranceFee { get; set; }
        public Nullable<decimal> InsuranceQuantity { get; set; }
        public Nullable<decimal> InsuranceAmount { get; set; }
        public string CorpEid { get; set; }
        public string PassengerNamePY { get; set; }
        public string PassengerCostCenter { get; set; }
        public string Dept1 { get; set; }
        public string Dept2 { get; set; }
        public string Dept3 { get; set; }
        public string Dept4 { get; set; }
        public string Dept5 { get; set; }
        public string TicketNo { get; set; }
        public string Flight { get; set; }
        public string AirlineCode { get; set; }
        public string AirLineName { get; set; }
        public string DCityCode { get; set; }
        public string DCityName { get; set; }
        public string ACityCode { get; set; }
        public string ACityName { get; set; }
        public string DPortCode { get; set; }
        public string DPortName { get; set; }
        public string APortCode { get; set; }
        public string APortName { get; set; }
        public Nullable<System.DateTime> TakeOffTime { get; set; }
        public Nullable<System.DateTime> ArrivalTime { get; set; }
        public string Class { get; set; }
        public string ClassName { get; set; }
        public string AgeType { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<decimal> PriceRate { get; set; }
        public string Remark { get; set; }
        public Nullable<decimal> PrintPrice { get; set; }
        public Nullable<decimal> ServerFee { get; set; }
        public Nullable<decimal> CorpPrice { get; set; }
        public Nullable<decimal> AmountSub { get; set; }
        public Nullable<decimal> Tax { get; set; }
        public Nullable<decimal> OilFee { get; set; }
        public Nullable<decimal> StandardPrice { get; set; }
    }
}
