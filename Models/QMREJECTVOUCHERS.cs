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
    
    public partial class QMREJECTVOUCHERS
    {
        public int ID { get; set; }
        public int AUTOID { get; set; }
        public string CREASONCODE { get; set; }
        public Nullable<decimal> FQUANTITY { get; set; }
        public Nullable<decimal> FNUM { get; set; }
        public string CSCRAPDISCODE { get; set; }
        public Nullable<int> IDISPOSEFLOW { get; set; }
        public string CDIMINVCODE { get; set; }
        public string CDIMUNITID { get; set; }
        public Nullable<decimal> FDIMCHANGRATE { get; set; }
        public Nullable<decimal> FDIMQUANTITY { get; set; }
        public Nullable<decimal> FDIMNUM { get; set; }
        public string CFREE1 { get; set; }
        public string CFREE2 { get; set; }
        public string CFREE3 { get; set; }
        public string CFREE4 { get; set; }
        public string CFREE5 { get; set; }
        public string CFREE6 { get; set; }
        public string CFREE7 { get; set; }
        public string CFREE8 { get; set; }
        public string CFREE9 { get; set; }
        public string CFREE10 { get; set; }
        public string CDEPCODE { get; set; }
        public string CDEFINE22 { get; set; }
        public string CDEFINE23 { get; set; }
        public string CDEFINE24 { get; set; }
        public string CDEFINE25 { get; set; }
        public Nullable<decimal> CDEFINE26 { get; set; }
        public Nullable<decimal> CDEFINE27 { get; set; }
        public string CDEFINE28 { get; set; }
        public string CDEFINE29 { get; set; }
        public string CDEFINE30 { get; set; }
        public string CDEFINE31 { get; set; }
        public string CDEFINE32 { get; set; }
        public string CDEFINE33 { get; set; }
        public Nullable<int> CDEFINE34 { get; set; }
        public Nullable<int> CDEFINE35 { get; set; }
        public Nullable<System.DateTime> CDEFINE36 { get; set; }
        public Nullable<System.DateTime> CDEFINE37 { get; set; }
        public Nullable<bool> BFLAG { get; set; }
        public Nullable<bool> BSTNEXTYEAR { get; set; }
        public Nullable<decimal> FMATCOST { get; set; }
        public Nullable<decimal> FBADLOSE { get; set; }
        public string CDIMBATCH { get; set; }
        public Nullable<System.DateTime> DDIMVDATE { get; set; }
        public Nullable<short> IDIMMASSDATE { get; set; }
        public string CDIMMASSUNIT { get; set; }
        public Nullable<decimal> FSUMREWORKQTY { get; set; }
        public Nullable<decimal> FSUMREWORKNUM { get; set; }
        public string CBVENCODE { get; set; }
        public Nullable<short> iDIMExpiratDateCalcu { get; set; }
        public string cDIMExpirationdate { get; set; }
        public Nullable<System.DateTime> dDIMExpirationdate { get; set; }
        public string CPUPOCODE { get; set; }
        public Nullable<int> IPUPODID { get; set; }
        public string MOORDEROPSEQ { get; set; }
        public string CBWHCODE { get; set; }
        public string CBSYSBARCODE { get; set; }
    
        public virtual Department Department { get; set; }
        public virtual QMSCRAPDISPOSE QMSCRAPDISPOSE { get; set; }
        public virtual Reason Reason { get; set; }
    }
}
