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
    
    public partial class hr_rt_request_app
    {
        public string cBusinessId { get; set; }
        public string cBillNo { get; set; }
        public string vReqName { get; set; }
        public string dMakeDate { get; set; }
        public string cMaker { get; set; }
        public string cVerifier { get; set; }
        public string dVerifyDate { get; set; }
        public string vVerifyNote { get; set; }
        public string cInvalider { get; set; }
        public string vMemo { get; set; }
        public string dAbateDate { get; set; }
        public string cReqPerCode { get; set; }
        public string cReqDepCode { get; set; }
        public byte[] hrts { get; set; }
        public string rDemandType { get; set; }
        public string VoucherId { get; set; }
        public string VoucherCode { get; set; }
        public string VoucherType { get; set; }
        public Nullable<System.DateTime> CreateOn { get; set; }
        public string Creator { get; set; }
        public string Submiter { get; set; }
        public Nullable<System.DateTime> SubmitOn { get; set; }
        public Nullable<System.DateTime> AuditOn { get; set; }
        public string Auditor { get; set; }
        public string Status { get; set; }
        public string Role { get; set; }
    }
}
