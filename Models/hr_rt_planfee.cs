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
    
    public partial class hr_rt_planfee
    {
        public System.Guid pk_hr_rt_planfee { get; set; }
        public string cBillNo { get; set; }
        public string cBusinessId { get; set; }
        public string vFeeItem { get; set; }
        public Nullable<decimal> nBudPrice { get; set; }
        public Nullable<decimal> nFactPrice { get; set; }
        public Nullable<int> iRecordID { get; set; }
        public string bLastFlag { get; set; }
        public string vStatus1 { get; set; }
        public Nullable<decimal> nStatus2 { get; set; }
    }
}
