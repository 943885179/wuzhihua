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
    
    public partial class ex_process_plandetail
    {
        public Nullable<int> id { get; set; }
        public string guid { get; set; }
        public string guids { get; set; }
        public string phaseguid { get; set; }
        public Nullable<int> iorder { get; set; }
        public Nullable<System.DateTime> dplanbegin { get; set; }
        public Nullable<System.DateTime> dplanend { get; set; }
        public Nullable<int> iplanperiod { get; set; }
        public Nullable<int> iexecutetime { get; set; }
        public string cprocesspersoncode { get; set; }
        public string cprocessdepcode { get; set; }
        public Nullable<System.DateTime> dactualbegin { get; set; }
        public Nullable<System.DateTime> dactualend { get; set; }
        public Nullable<int> iactualperiod { get; set; }
        public byte[] ufts { get; set; }
        public string cordercode { get; set; }
        public string processguid { get; set; }
        public string cplandatefield { get; set; }
        public Nullable<int> iplandateshift { get; set; }
        public Nullable<int> iplansplit { get; set; }
        public Nullable<bool> blineclosed { get; set; }
    }
}
