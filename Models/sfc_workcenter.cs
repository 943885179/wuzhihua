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
    
    public partial class sfc_workcenter
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public sfc_workcenter()
        {
            this.QMCHECKVOUCHER = new HashSet<QMCHECKVOUCHER>();
            this.QMINSPECTVOUCHER = new HashSet<QMINSPECTVOUCHER>();
            this.QMREJECTVOUCHER = new HashSet<QMREJECTVOUCHER>();
            this.SQ_BOMMANHOUR = new HashSet<SQ_BOMMANHOUR>();
        }
    
        public int WcId { get; set; }
        public string WcCode { get; set; }
        public string Description { get; set; }
        public Nullable<int> CalendarId { get; set; }
        public Nullable<bool> ProductLineFlag { get; set; }
        public string DeptCode { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string CreateUser { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public string ModifyUser { get; set; }
        public Nullable<int> UpdCount { get; set; }
        public byte[] Ufts { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<System.DateTime> ModifyTime { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QMCHECKVOUCHER> QMCHECKVOUCHER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QMINSPECTVOUCHER> QMINSPECTVOUCHER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QMREJECTVOUCHER> QMREJECTVOUCHER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SQ_BOMMANHOUR> SQ_BOMMANHOUR { get; set; }
    }
}
