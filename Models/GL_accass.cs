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
    
    public partial class GL_accass
    {
        public int i_id { get; set; }
        public string ccode { get; set; }
        public string cexch_name { get; set; }
        public string cdept_id { get; set; }
        public string cperson_id { get; set; }
        public string ccus_id { get; set; }
        public string csup_id { get; set; }
        public string citem_class { get; set; }
        public string citem_id { get; set; }
        public byte iperiod { get; set; }
        public string cbegind_c { get; set; }
        public string cbegind_c_engl { get; set; }
        public decimal mb { get; set; }
        public decimal md { get; set; }
        public decimal mc { get; set; }
        public string cendd_c { get; set; }
        public string cendd_c_engl { get; set; }
        public decimal me { get; set; }
        public decimal mb_f { get; set; }
        public decimal md_f { get; set; }
        public decimal mc_f { get; set; }
        public decimal me_f { get; set; }
        public double nb_s { get; set; }
        public double nd_s { get; set; }
        public double nc_s { get; set; }
        public double ne_s { get; set; }
        public Nullable<short> iyear { get; set; }
        public Nullable<int> iYPeriod { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Department Department { get; set; }
        public virtual Person Person { get; set; }
        public virtual Vendor Vendor { get; set; }
    }
}
