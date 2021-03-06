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
    
    public partial class sfc_processflowdetail
    {
        public int PFDId { get; set; }
        public Nullable<int> PFId { get; set; }
        public Nullable<int> MoRoutingDId { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> StartTime { get; set; }
        public Nullable<System.DateTime> DueDate { get; set; }
        public Nullable<System.DateTime> DueTime { get; set; }
        public string OpSeq { get; set; }
        public Nullable<int> OperationId { get; set; }
        public string Description { get; set; }
        public Nullable<int> WcId { get; set; }
        public Nullable<bool> SubFlag { get; set; }
        public string SVendorCode { get; set; }
        public string AuxUnitCode { get; set; }
        public Nullable<decimal> ChangeRate { get; set; }
        public Nullable<bool> PlanSubFlag { get; set; }
        public Nullable<int> DeliveryDays { get; set; }
        public Nullable<bool> FeeFlag { get; set; }
        public Nullable<decimal> WorkHour { get; set; }
        public Nullable<decimal> BalMachiningQty { get; set; }
        public Nullable<decimal> BalQualifiedQty { get; set; }
        public Nullable<decimal> BalRefusedQty { get; set; }
        public Nullable<decimal> BalDeclareQty { get; set; }
        public Nullable<decimal> BalScrapQty { get; set; }
        public Nullable<decimal> CompleteQty { get; set; }
        public Nullable<bool> SplitFlag { get; set; }
        public Nullable<decimal> SubQty { get; set; }
        public Nullable<decimal> ReworkQty { get; set; }
        public Nullable<decimal> ReworkedQty { get; set; }
        public Nullable<decimal> PostReworkedQty { get; set; }
        public Nullable<decimal> RdReworkedQty { get; set; }
        public Nullable<decimal> PostScrapQty { get; set; }
        public Nullable<decimal> RdScrapQty { get; set; }
        public string Define22 { get; set; }
        public string Define23 { get; set; }
        public string Define24 { get; set; }
        public string Define25 { get; set; }
        public Nullable<double> Define26 { get; set; }
        public Nullable<double> Define27 { get; set; }
        public string Define28 { get; set; }
        public string Define29 { get; set; }
        public string Define30 { get; set; }
        public string Define31 { get; set; }
        public string Define32 { get; set; }
        public string Define33 { get; set; }
        public Nullable<int> Define34 { get; set; }
        public Nullable<int> Define35 { get; set; }
        public Nullable<System.DateTime> Define36 { get; set; }
        public Nullable<System.DateTime> Define37 { get; set; }
        public byte[] Ufts { get; set; }
        public string cbSysBarCode { get; set; }
        public Nullable<bool> ReportFlag { get; set; }
    }
}
