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
    
    public partial class SA_CusPriceJustDetail
    {
        public int autoid { get; set; }
        public Nullable<long> id { get; set; }
        public string operationtype { get; set; }
        public Nullable<long> ipriceid { get; set; }
        public string ccuscode { get; set; }
        public string ccusccode { get; set; }
        public string cinvcode { get; set; }
        public string cfree1 { get; set; }
        public string cfree2 { get; set; }
        public string cfree3 { get; set; }
        public string cfree4 { get; set; }
        public string cfree5 { get; set; }
        public string cfree6 { get; set; }
        public string cfree7 { get; set; }
        public string cfree8 { get; set; }
        public string cfree9 { get; set; }
        public string cfree10 { get; set; }
        public Nullable<decimal> iinvscost { get; set; }
        public Nullable<decimal> iinvsalecost { get; set; }
        public Nullable<decimal> icusdisrate { get; set; }
        public Nullable<decimal> iinvnowcost { get; set; }
        public string cbodymemo { get; set; }
        public Nullable<System.DateTime> dstartdate { get; set; }
        public Nullable<System.DateTime> denddate { get; set; }
        public string cdesc { get; set; }
        public string cdefine22 { get; set; }
        public string cdefine23 { get; set; }
        public string cdefine24 { get; set; }
        public string cdefine25 { get; set; }
        public Nullable<double> cdefine26 { get; set; }
        public Nullable<double> cdefine27 { get; set; }
        public string cdefine28 { get; set; }
        public string cdefine29 { get; set; }
        public string cdefine30 { get; set; }
        public string cdefine31 { get; set; }
        public string cdefine32 { get; set; }
        public string cdefine33 { get; set; }
        public Nullable<int> cdefine34 { get; set; }
        public Nullable<int> cdefine35 { get; set; }
        public Nullable<System.DateTime> cdefine36 { get; set; }
        public Nullable<System.DateTime> cdefine37 { get; set; }
        public Nullable<bool> bsales { get; set; }
        public Nullable<decimal> fminquantity { get; set; }
        public Nullable<decimal> fcusminprice { get; set; }
        public string cCusInvCode { get; set; }
        public string cCusInvName { get; set; }
        public string cexch_name { get; set; }
        public Nullable<int> irowno { get; set; }
        public string ccusproperty1 { get; set; }
        public string cbSysBarCode { get; set; }
    
        public virtual SA_CusPriceJustMain SA_CusPriceJustMain { get; set; }
    }
}
