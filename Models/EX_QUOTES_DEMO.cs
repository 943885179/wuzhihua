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
    
    public partial class EX_QUOTES_DEMO
    {
        public int SUBID { get; set; }
        public int MAINID { get; set; }
        public string CINVCODE { get; set; }
        public string CINVNAME { get; set; }
        public string CINVM_UNIT { get; set; }
        public double FQTY { get; set; }
        public string CUNITNAME { get; set; }
        public Nullable<double> FCHANGERATE { get; set; }
        public Nullable<double> FQTYS { get; set; }
        public string CBUPLOAD { get; set; }
        public string CREQUIREMENT { get; set; }
        public Nullable<double> FPACKQTY { get; set; }
        public Nullable<double> FINVWEIGHT { get; set; }
        public Nullable<double> FINVGROSSW { get; set; }
        public Nullable<double> FWEIGHT { get; set; }
        public Nullable<double> FGROSSW { get; set; }
        public string CVUNIT { get; set; }
        public Nullable<double> FINVVOLUME { get; set; }
        public Nullable<double> FVOLUME { get; set; }
        public Nullable<double> FPRICE { get; set; }
        public Nullable<double> FUNITPRICE { get; set; }
        public Nullable<double> FMONEY { get; set; }
        public Nullable<double> FDISCOUNTRATE { get; set; }
        public Nullable<double> FDISCOUNTRATE1 { get; set; }
        public Nullable<double> FDISCOUNT { get; set; }
    
        public virtual EX_QUOTE_DEMO EX_QUOTE_DEMO { get; set; }
    }
}
