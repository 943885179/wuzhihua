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
    
    public partial class hr_rt_plan
    {
        public Nullable<System.Guid> pk_hr_rt_plan { get; set; }
        public string cBusinessId { get; set; }
        public string cBillNo { get; set; }
        public string vPlanName { get; set; }
        public string dMakeDate { get; set; }
        public string cMaker { get; set; }
        public string cVerifier { get; set; }
        public string dVerifyDate { get; set; }
        public string vVerifyNote { get; set; }
        public string cInvalider { get; set; }
        public string vMemo { get; set; }
        public string cPlanPerCode { get; set; }
        public string cPlanDepCode { get; set; }
        public string bSealFlag { get; set; }
        public byte[] hrts { get; set; }
    }
}
