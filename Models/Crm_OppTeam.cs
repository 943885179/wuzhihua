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
    
    public partial class Crm_OppTeam
    {
        public string OID { get; set; }
        public int AutoID { get; set; }
        public string OppID { get; set; }
        public string cDepCode { get; set; }
        public string cTeamMember { get; set; }
        public Nullable<bool> bPrincipal { get; set; }
        public string cCreator { get; set; }
        public string cRevisor { get; set; }
        public Nullable<System.DateTime> dModifyDate { get; set; }
        public string cMainFunc { get; set; }
        public byte[] ufts { get; set; }
    }
}
