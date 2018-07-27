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
    
    public partial class mps_plancode
    {
        public int PlanCodeId { get; set; }
        public string PlanCode { get; set; }
        public string Description { get; set; }
        public Nullable<byte> PlanType { get; set; }
        public Nullable<bool> DefPlanFlag { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string CreateUser { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public string ModifyUser { get; set; }
        public Nullable<int> UpdCount { get; set; }
        public byte[] Ufts { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<System.DateTime> ModifyTime { get; set; }
        public Nullable<System.DateTime> AnchorDate { get; set; }
        public Nullable<int> TbId { get; set; }
        public Nullable<int> TfId { get; set; }
        public Nullable<int> FVersionId { get; set; }
        public Nullable<int> DSType { get; set; }
        public Nullable<bool> PeggingFlag { get; set; }
        public Nullable<int> MpsPlanCodeId { get; set; }
        public Nullable<int> MrpPlanCodeId { get; set; }
        public Nullable<bool> ReplaceFlag { get; set; }
        public Nullable<bool> SubstituteFlag { get; set; }
        public Nullable<bool> DefActiveFlag { get; set; }
        public Nullable<byte> TFPrioty { get; set; }
        public Nullable<byte> OpeningStock { get; set; }
        public Nullable<bool> PastDueProc { get; set; }
        public Nullable<bool> ShpConsmpFlag { get; set; }
        public Nullable<int> Period { get; set; }
        public Nullable<int> PastDuePeriod { get; set; }
        public Nullable<int> PlanPeriod { get; set; }
        public Nullable<System.DateTime> LstEndDate { get; set; }
        public Nullable<System.DateTime> LstProDate { get; set; }
        public Nullable<System.DateTime> LstHorizonDate { get; set; }
        public Nullable<bool> CompConsmpFlag { get; set; }
        public Nullable<System.DateTime> LstProcTime { get; set; }
        public Nullable<System.DateTime> LstProcEndTime { get; set; }
        public Nullable<int> DFId { get; set; }
    }
}
