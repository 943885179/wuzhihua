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
    
    public partial class ecn_bom
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ecn_bom()
        {
            this.ecn_opcomponent = new HashSet<ecn_opcomponent>();
        }
    
        public byte BomType { get; set; }
        public int EBomId { get; set; }
        public Nullable<int> ParentId { get; set; }
        public Nullable<decimal> ParentScrap { get; set; }
        public Nullable<int> Version { get; set; }
        public string VersionDesc { get; set; }
        public Nullable<System.DateTime> VersionEffDate { get; set; }
        public string IdentCode { get; set; }
        public string IdentDesc { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string CreateUser { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public string ModifyUser { get; set; }
        public Nullable<int> Updcount { get; set; }
        public byte[] Ufts { get; set; }
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
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<System.DateTime> ModifyTime { get; set; }
        public Nullable<int> ApplyDId { get; set; }
        public Nullable<byte> Status { get; set; }
        public Nullable<System.DateTime> VersionEndDate { get; set; }
        public Nullable<System.DateTime> RelsDate { get; set; }
        public Nullable<System.DateTime> RelsTime { get; set; }
        public string RelsUser { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ecn_opcomponent> ecn_opcomponent { get; set; }
    }
}
