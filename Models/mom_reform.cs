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
    
    public partial class mom_reform
    {
        public int ReformId { get; set; }
        public byte RefType { get; set; }
        public string DocCode { get; set; }
        public Nullable<System.DateTime> DocDate { get; set; }
        public Nullable<int> OrgMoDId { get; set; }
        public string OrgMoCode { get; set; }
        public Nullable<int> RefMoId { get; set; }
        public Nullable<int> RefMoDId { get; set; }
        public string RefMoCode { get; set; }
        public string ReasonCode { get; set; }
        public string Remark { get; set; }
        public Nullable<decimal> OrderQty { get; set; }
        public Nullable<decimal> ReformQty { get; set; }
        public Nullable<decimal> ReformMrpQty { get; set; }
        public Nullable<bool> ReformFlag { get; set; }
        public string CreateUser { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public string ModifyUser { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public Nullable<System.DateTime> ModifyTime { get; set; }
        public string Define1 { get; set; }
        public string Define2 { get; set; }
        public string Define3 { get; set; }
        public Nullable<System.DateTime> Define4 { get; set; }
        public Nullable<int> Define5 { get; set; }
        public Nullable<System.DateTime> Define6 { get; set; }
        public Nullable<double> Define7 { get; set; }
        public string Define8 { get; set; }
        public string Define9 { get; set; }
        public string Define10 { get; set; }
        public string Define11 { get; set; }
        public string Define12 { get; set; }
        public string Define13 { get; set; }
        public string Define14 { get; set; }
        public Nullable<int> Define15 { get; set; }
        public Nullable<double> Define16 { get; set; }
        public Nullable<int> VTid { get; set; }
        public byte[] Ufts { get; set; }
        public Nullable<int> UpdCount { get; set; }
        public Nullable<byte> Status { get; set; }
        public Nullable<int> TmpMoId { get; set; }
        public string RelsUser { get; set; }
        public Nullable<System.DateTime> RelsDate { get; set; }
        public Nullable<System.DateTime> RelsTime { get; set; }
        public Nullable<int> iPrintCount { get; set; }
    }
}
