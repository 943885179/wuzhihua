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
    
    public partial class Crm_SurveyQuestionary
    {
        public string OID { get; set; }
        public int AUTOID { get; set; }
        public string cQuestionaryCode { get; set; }
        public string cQuestionaryName { get; set; }
        public string cQuestionarySubject { get; set; }
        public string cHeaderMemo { get; set; }
        public string cTailMemo { get; set; }
        public string cInquirer { get; set; }
        public Nullable<int> bcTypesetStatus { get; set; }
        public Nullable<int> bcStatus { get; set; }
        public string cCreator { get; set; }
        public Nullable<System.DateTime> dCreateDate { get; set; }
        public string cRevisor { get; set; }
        public Nullable<System.DateTime> dModifyDate { get; set; }
        public byte[] ufts { get; set; }
    }
}
