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
    
    public partial class HY_DZ_ECNMAIN
    {
        public long id { get; set; }
        public string DocCode { get; set; }
        public System.DateTime cdate { get; set; }
        public byte cstate { get; set; }
        public string cmemo { get; set; }
        public string cmaker { get; set; }
        public string cverifier { get; set; }
        public Nullable<System.DateTime> makedate { get; set; }
        public Nullable<System.DateTime> verifydate { get; set; }
        public Nullable<byte> AuditStatus { get; set; }
        public string cinvalider { get; set; }
        public Nullable<System.DateTime> cinvaliddate { get; set; }
        public byte[] ufts { get; set; }
        public long btype { get; set; }
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
        public Nullable<double> otrel { get; set; }
        public Nullable<double> ntrel { get; set; }
        public string cdepcode { get; set; }
        public Nullable<System.DateTime> chdate { get; set; }
        public Nullable<int> iverifystate { get; set; }
        public Nullable<byte> iswfcontrolled { get; set; }
        public Nullable<int> ireturncount { get; set; }
        public string VoucherType { get; set; }
        public Nullable<int> iPrintCount { get; set; }
        public string ivtid { get; set; }
        public Nullable<int> UpdCount { get; set; }
        public string cCurrentAuditor { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public string CreateUser { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public Nullable<System.DateTime> ModifyTime { get; set; }
        public string ModifyUser { get; set; }
        public Nullable<System.DateTime> RelsDate { get; set; }
        public Nullable<System.DateTime> RelsTime { get; set; }
        public string RelsUser { get; set; }
        public Nullable<System.DateTime> CloseDate { get; set; }
        public Nullable<System.DateTime> CloseTime { get; set; }
        public string CloseUser { get; set; }
        public Nullable<int> BomId { get; set; }
        public Nullable<int> ParentId { get; set; }
        public Nullable<int> NewComponentId { get; set; }
        public Nullable<int> OldComponentId { get; set; }
        public Nullable<int> Version { get; set; }
        public Nullable<bool> IsNewVersion { get; set; }
        public Nullable<int> NewVersion { get; set; }
        public string NewVersionDesc { get; set; }
        public Nullable<System.DateTime> ReplaceDate { get; set; }
        public Nullable<byte> ChangeType { get; set; }
        public Nullable<byte> EffectType { get; set; }
    }
}
