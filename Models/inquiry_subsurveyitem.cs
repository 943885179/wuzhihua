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
    
    public partial class inquiry_subsurveyitem
    {
        public long id { get; set; }
        public long surveybasic_id { get; set; }
        public Nullable<int> sort { get; set; }
        public long subsurvey_id { get; set; }
        public string content { get; set; }
        public Nullable<int> vote_count { get; set; }
        public int other_option { get; set; }
    
        public virtual inquiry_surveybasic inquiry_surveybasic { get; set; }
    }
}
