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
    
    public partial class EX_SALES_DEMO
    {
        public int SUBID { get; set; }
        public int MAINID { get; set; }
        public Nullable<int> IORDERSUBID { get; set; }
        public string CINVCODE { get; set; }
        public string CINVNAME { get; set; }
        public string CINVM_UNIT { get; set; }
        public decimal FQTY { get; set; }
        public string CUNITNAME { get; set; }
        public decimal FCHANGERATE { get; set; }
        public Nullable<decimal> FQTYS { get; set; }
        public string CBUPLOAD { get; set; }
        public string CREQUIREMENT { get; set; }
        public decimal FPACKQTY { get; set; }
        public decimal FINVWEIGHT { get; set; }
        public decimal FINVGROSSW { get; set; }
        public decimal FWEIGHT { get; set; }
        public decimal FGROSSW { get; set; }
        public string CVUNIT { get; set; }
        public decimal FINVVOLUME { get; set; }
        public decimal FVOLUME { get; set; }
        public decimal FPRICE { get; set; }
        public decimal FUNITPRICE { get; set; }
        public decimal FMONEY { get; set; }
        public decimal FDISCOUNTRATE { get; set; }
        public decimal FDISCOUNTRATE1 { get; set; }
        public decimal FDISCOUNT { get; set; }
        public Nullable<System.DateTime> DPREBDATE { get; set; }
        public string CWARENAME { get; set; }
    
        public virtual EX_SALE_DEMO EX_SALE_DEMO { get; set; }
    }
}
