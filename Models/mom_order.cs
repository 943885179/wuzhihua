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
    
    public partial class mom_order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public mom_order()
        {
            this.mom_orderdetail = new HashSet<mom_orderdetail>();
        }
    
        public int MoId { get; set; }
        public string MoCode { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string CreateUser { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public string ModifyUser { get; set; }
        public Nullable<int> UpdCount { get; set; }
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
        public Nullable<int> iPrintCount { get; set; }
        public Nullable<int> RelsVTid { get; set; }
        public string cSysBarCode { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<mom_orderdetail> mom_orderdetail { get; set; }
    }
}
