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
    
    public partial class Crm_SurveyFeedback
    {
        public string OID { get; set; }
        public int AutoID { get; set; }
        public Nullable<float> fScore { get; set; }
        public string SurveyActiveID { get; set; }
        public Nullable<int> bcInformantType { get; set; }
        public string cInputer { get; set; }
        public Nullable<System.DateTime> dInputDate { get; set; }
        public byte[] ufts { get; set; }
    }
}
