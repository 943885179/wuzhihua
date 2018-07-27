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
    
    public partial class mom_orderdetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public mom_orderdetail()
        {
            this.mom_moallocate = new HashSet<mom_moallocate>();
        }
    
        public int MoDId { get; set; }
        public int MoId { get; set; }
        public int SortSeq { get; set; }
        public Nullable<byte> MoClass { get; set; }
        public Nullable<int> MoTypeId { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public Nullable<decimal> MrpQty { get; set; }
        public string AuxUnitCode { get; set; }
        public Nullable<decimal> AuxQty { get; set; }
        public Nullable<decimal> ChangeRate { get; set; }
        public string MoLotCode { get; set; }
        public string WhCode { get; set; }
        public string MDeptCode { get; set; }
        public Nullable<byte> SoType { get; set; }
        public string SoDId { get; set; }
        public string SoCode { get; set; }
        public Nullable<int> SoSeq { get; set; }
        public Nullable<decimal> DeclaredQty { get; set; }
        public Nullable<decimal> QualifiedInQty { get; set; }
        public Nullable<byte> Status { get; set; }
        public Nullable<byte> OrgStatus { get; set; }
        public Nullable<int> BomId { get; set; }
        public Nullable<int> RoutingId { get; set; }
        public Nullable<int> CustBomId { get; set; }
        public Nullable<int> DemandId { get; set; }
        public string PlanCode { get; set; }
        public Nullable<int> PartId { get; set; }
        public string InvCode { get; set; }
        public string Free1 { get; set; }
        public string Free2 { get; set; }
        public string Free3 { get; set; }
        public string Free4 { get; set; }
        public string Free5 { get; set; }
        public string Free6 { get; set; }
        public string Free7 { get; set; }
        public string Free8 { get; set; }
        public string Free9 { get; set; }
        public string Free10 { get; set; }
        public Nullable<bool> SfcFlag { get; set; }
        public Nullable<bool> CrpFlag { get; set; }
        public Nullable<bool> QcFlag { get; set; }
        public Nullable<System.DateTime> RelsDate { get; set; }
        public string RelsUser { get; set; }
        public Nullable<System.DateTime> CloseDate { get; set; }
        public Nullable<System.DateTime> OrgClsDate { get; set; }
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
        public Nullable<int> LeadTime { get; set; }
        public Nullable<byte> OpScheduleType { get; set; }
        public Nullable<bool> OrdFlag { get; set; }
        public Nullable<byte> WIPType { get; set; }
        public string SupplyWhCode { get; set; }
        public string ReasonCode { get; set; }
        public Nullable<byte> IsWFControlled { get; set; }
        public Nullable<int> iVerifyState { get; set; }
        public Nullable<int> iReturnCount { get; set; }
        public string Remark { get; set; }
        public string SourceMoCode { get; set; }
        public Nullable<int> SourceMoSeq { get; set; }
        public Nullable<int> SourceMoId { get; set; }
        public Nullable<int> SourceMoDId { get; set; }
        public string SourceQCCode { get; set; }
        public Nullable<int> SourceQCId { get; set; }
        public Nullable<int> SourceQCDId { get; set; }
        public string CostItemCode { get; set; }
        public string CostItemName { get; set; }
        public Nullable<System.DateTime> RelsTime { get; set; }
        public string CloseUser { get; set; }
        public Nullable<System.DateTime> CloseTime { get; set; }
        public Nullable<System.DateTime> OrgClsTime { get; set; }
        public Nullable<byte> AuditStatus { get; set; }
        public Nullable<int> PAllocateId { get; set; }
        public string DemandCode { get; set; }
        public Nullable<byte> CollectiveFlag { get; set; }
        public Nullable<byte> OrderType { get; set; }
        public Nullable<int> OrderDId { get; set; }
        public string OrderCode { get; set; }
        public Nullable<int> OrderSeq { get; set; }
        public string ManualCode { get; set; }
        public Nullable<bool> ReformFlag { get; set; }
        public Nullable<byte> SourceQCVouchType { get; set; }
        public Nullable<decimal> OrgQty { get; set; }
        public Nullable<bool> FmFlag { get; set; }
        public string MinSN { get; set; }
        public string MaxSN { get; set; }
        public string SourceSvcCode { get; set; }
        public string SourceSvcId { get; set; }
        public string SourceSvcDId { get; set; }
        public Nullable<byte> BomType { get; set; }
        public Nullable<byte> RoutingType { get; set; }
        public Nullable<int> BusFlowId { get; set; }
        public Nullable<bool> RunCardFlag { get; set; }
        public Nullable<bool> RequisitionFlag { get; set; }
        public Nullable<int> AlloVTid { get; set; }
        public Nullable<int> RelsAlloVTid { get; set; }
        public Nullable<int> iPrintCount { get; set; }
        public string cbSysBarCode { get; set; }
        public string cCurrentAuditor { get; set; }
        public string CustCode { get; set; }
        public string LPlanCode { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<mom_moallocate> mom_moallocate { get; set; }
        public virtual mom_morder mom_morder { get; set; }
        public virtual mom_order mom_order { get; set; }
        public virtual mom_remorder mom_remorder { get; set; }
    }
}
