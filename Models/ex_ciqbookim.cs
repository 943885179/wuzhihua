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
    
    public partial class ex_ciqbookim
    {
        public int id { get; set; }
        public string cinvcode { get; set; }
        public string cciqcode { get; set; }
        public string cnationcode { get; set; }
        public string ccomunitcode { get; set; }
        public decimal fquantity { get; set; }
        public Nullable<decimal> fprice { get; set; }
        public Nullable<decimal> fnatprice { get; set; }
        public Nullable<decimal> fmoney { get; set; }
        public Nullable<decimal> fnatmoney { get; set; }
        public string clevyproperty { get; set; }
        public Nullable<decimal> finquantity { get; set; }
        public Nullable<decimal> foutquantity { get; set; }
        public Nullable<decimal> fcheckquantity { get; set; }
        public string cnote { get; set; }
        public Nullable<int> irowno { get; set; }
        public string cvencode { get; set; }
        public string cnapeitem { get; set; }
        public Nullable<decimal> ftransferinquantity { get; set; }
        public Nullable<decimal> ftransferoutquantity { get; set; }
        public Nullable<decimal> fotherinqty { get; set; }
        public Nullable<decimal> fotheroutqty { get; set; }
        public Nullable<decimal> frejectqty { get; set; }
        public int autoid { get; set; }
    
        public virtual ex_ciqbook ex_ciqbook { get; set; }
    }
}
