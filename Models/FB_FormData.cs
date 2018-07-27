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
    
    public partial class FB_FormData
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FB_FormData()
        {
            this.FB_FormData_Dept = new HashSet<FB_FormData_Dept>();
            this.FB_FormData_Item = new HashSet<FB_FormData_Item>();
            this.FB_FormData_Period = new HashSet<FB_FormData_Period>();
            this.FB_FormData_BgItem = new HashSet<FB_FormData_BgItem>();
        }
    
        public System.Guid AutoId { get; set; }
        public string cVouchID { get; set; }
        public int iYear { get; set; }
        public string cFormCode { get; set; }
        public string cBgItemCode { get; set; }
        public string cDepCode { get; set; }
        public string cItemClass { get; set; }
        public string cItemCategory { get; set; }
        public string cItemCode { get; set; }
        public string cVersionCode { get; set; }
        public string cMaker { get; set; }
        public Nullable<System.DateTime> dMakeDate { get; set; }
        public string cSubmitter { get; set; }
        public string cAuditor { get; set; }
        public Nullable<System.DateTime> dAuditDate { get; set; }
        public byte[] tStamp { get; set; }
    
        public virtual FB_Form FB_Form { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FB_FormData_Dept> FB_FormData_Dept { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FB_FormData_Item> FB_FormData_Item { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FB_FormData_Period> FB_FormData_Period { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FB_FormData_BgItem> FB_FormData_BgItem { get; set; }
    }
}
