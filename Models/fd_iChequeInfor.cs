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
    
    public partial class fd_iChequeInfor
    {
        public string icheque_sId { get; set; }
        public string icheque_scode { get; set; }
        public string accUnit_id { get; set; }
        public string taken_Name { get; set; }
        public System.DateTime taken_date { get; set; }
        public string Lower_Limit { get; set; }
        public string Upper_Limit { get; set; }
        public byte iState { get; set; }
        public string Degist { get; set; }
        public string bill_name { get; set; }
        public Nullable<short> pre_length { get; set; }
        public byte[] ufts { get; set; }
    }
}
