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
    
    public partial class InvModify_Log
    {
        public int AutoId { get; set; }
        public System.DateTime dModifyDate { get; set; }
        public string cUserId { get; set; }
        public string cModifyType { get; set; }
        public string cCondition { get; set; }
        public string cModifyInvCode { get; set; }
        public string cSuccessInvCode { get; set; }
        public string cFailInVCode { get; set; }
        public int iModifyNum { get; set; }
        public int iSuccessNum { get; set; }
        public int iFailNum { get; set; }
        public string cModifyItme { get; set; }
    }
}
