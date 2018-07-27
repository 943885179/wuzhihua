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
    
    public partial class addressbook_member
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public addressbook_member()
        {
            this.addressbook_team_members = new HashSet<addressbook_team_members>();
        }
    
        public long id { get; set; }
        public string name { get; set; }
        public string company_name { get; set; }
        public string company_dept { get; set; }
        public string company_level { get; set; }
        public string company_post { get; set; }
        public string company_phone { get; set; }
        public string family_phone { get; set; }
        public string mobilephone { get; set; }
        public string fax { get; set; }
        public string address { get; set; }
        public string postcode { get; set; }
        public string email { get; set; }
        public string website { get; set; }
        public string blog { get; set; }
        public string msn { get; set; }
        public string qq { get; set; }
        public long creator_id { get; set; }
        public string creator_name { get; set; }
        public Nullable<System.DateTime> created_time { get; set; }
        public Nullable<System.DateTime> modified_time { get; set; }
        public string memo { get; set; }
        public Nullable<long> category_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<addressbook_team_members> addressbook_team_members { get; set; }
    }
}
