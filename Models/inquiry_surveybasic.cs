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
    
    public partial class inquiry_surveybasic
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public inquiry_surveybasic()
        {
            this.inquiry_scope = new HashSet<inquiry_scope>();
            this.inquiry_subsurvey = new HashSet<inquiry_subsurvey>();
            this.inquiry_subsurveyitem = new HashSet<inquiry_subsurveyitem>();
            this.inquiry_surveydiscuss = new HashSet<inquiry_surveydiscuss>();
            this.inquiry_votedefinite = new HashSet<inquiry_votedefinite>();
        }
    
        public long id { get; set; }
        public Nullable<int> totals { get; set; }
        public long surveytype_id { get; set; }
        public long creater_id { get; set; }
        public Nullable<long> censor_id { get; set; }
        public Nullable<System.DateTime> send_date { get; set; }
        public Nullable<System.DateTime> close_date { get; set; }
        public Nullable<int> click_count { get; set; }
        public Nullable<int> vote_count { get; set; }
        public Nullable<int> censor { get; set; }
        public Nullable<long> department_id { get; set; }
        public Nullable<int> cryptonym { get; set; }
        public string survey_name { get; set; }
        public string surveydesc { get; set; }
        public Nullable<int> flag { get; set; }
        public string check_mind { get; set; }
        public Nullable<long> issuer_id { get; set; }
        public Nullable<byte> att_flag { get; set; }
        public byte allow_view_result { get; set; }
        public byte allow_view_result_ahead { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<inquiry_scope> inquiry_scope { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<inquiry_subsurvey> inquiry_subsurvey { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<inquiry_subsurveyitem> inquiry_subsurveyitem { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<inquiry_surveydiscuss> inquiry_surveydiscuss { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<inquiry_votedefinite> inquiry_votedefinite { get; set; }
        public virtual inquiry_surveytype inquiry_surveytype { get; set; }
    }
}
