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
    
    public partial class ecn_proutingdetail
    {
        public int EcnRoutingDId { get; set; }
        public int EcnRoutingId { get; set; }
        public string OpSeq { get; set; }
        public string Description { get; set; }
        public Nullable<int> WcId { get; set; }
        public Nullable<System.DateTime> EffBegDate { get; set; }
        public Nullable<System.DateTime> EffEndDate { get; set; }
        public Nullable<bool> SubFlag { get; set; }
        public string SVendorCode { get; set; }
        public Nullable<bool> RltOptionFlag { get; set; }
        public Nullable<int> LtPercent { get; set; }
        public string Remark { get; set; }
        public Nullable<int> RoutingInspId { get; set; }
        public Nullable<int> OperationId { get; set; }
        public byte[] Ufts { get; set; }
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
        public Nullable<bool> ReportFlag { get; set; }
        public Nullable<bool> BFFlag { get; set; }
        public Nullable<bool> FeeFlag { get; set; }
        public Nullable<bool> PlanSubFlag { get; set; }
        public Nullable<int> DeliveryDays { get; set; }
        public string AuxUnitCode { get; set; }
        public Nullable<decimal> ChangeRate { get; set; }
        public Nullable<bool> LastFlag { get; set; }
        public Nullable<bool> SplitFlag { get; set; }
    
        public virtual ecn_prouting ecn_prouting { get; set; }
    }
}
