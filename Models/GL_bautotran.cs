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
    
    public partial class GL_bautotran
    {
        public int i_id { get; set; }
        public byte itype { get; set; }
        public string ctran_id { get; set; }
        public short inid { get; set; }
        public string csign { get; set; }
        public string ctext { get; set; }
        public Nullable<short> idoc { get; set; }
        public string ccode { get; set; }
        public string cexch_name { get; set; }
        public string cdigest { get; set; }
        public string ccus_id { get; set; }
        public string csup_id { get; set; }
        public string cperson_id { get; set; }
        public string cdept_id { get; set; }
        public string citem_class { get; set; }
        public string citem_id { get; set; }
        public Nullable<bool> bd_c { get; set; }
        public string cformula { get; set; }
        public string cformula_s { get; set; }
        public string cformula_f { get; set; }
        public string cItemCCode { get; set; }
        public string cDefine1 { get; set; }
        public string cDefine2 { get; set; }
        public string cDefine3 { get; set; }
        public Nullable<System.DateTime> cDefine4 { get; set; }
        public Nullable<int> cDefine5 { get; set; }
        public Nullable<System.DateTime> cDefine6 { get; set; }
        public Nullable<double> cDefine7 { get; set; }
        public string cDefine8 { get; set; }
        public string cDefine9 { get; set; }
        public string cDefine10 { get; set; }
        public string cDefine11 { get; set; }
        public string cDefine12 { get; set; }
        public string cDefine13 { get; set; }
        public string cDefine14 { get; set; }
        public Nullable<int> cDefine15 { get; set; }
        public Nullable<double> cDefine16 { get; set; }
        public Nullable<short> RefVouchYear { get; set; }
        public Nullable<byte> RefVouchPeriod { get; set; }
        public string RefVouchSign { get; set; }
        public Nullable<int> RefVouchNo { get; set; }
        public string cplan { get; set; }
        public Nullable<decimal> RefJe { get; set; }
        public Nullable<decimal> RefJe_f { get; set; }
        public Nullable<double> RefSL { get; set; }
        public Nullable<short> iCount { get; set; }
        public Nullable<decimal> Je { get; set; }
        public Nullable<double> Rate { get; set; }
        public string operater { get; set; }
        public Nullable<bool> bAuto { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Department Department { get; set; }
        public virtual Person Person { get; set; }
        public virtual Vendor Vendor { get; set; }
    }
}
