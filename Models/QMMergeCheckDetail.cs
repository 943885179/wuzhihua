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
    
    public partial class QMMergeCheckDetail
    {
        public int ID { get; set; }
        public int AUTOID { get; set; }
        public int INSPECTID { get; set; }
        public string CINSPECTCODE { get; set; }
        public int INSPECTAUTOID { get; set; }
        public int SOURCEID { get; set; }
        public string SOURCECODE { get; set; }
        public int SOURCEAUTOID { get; set; }
        public string CCHECKTYPECODE { get; set; }
        public string CCONTRACTCODE { get; set; }
        public string CCONTRACTSTRCODE { get; set; }
        public string CVENCODE { get; set; }
        public string CPOCODE { get; set; }
        public Nullable<System.DateTime> DARRIVALDATE { get; set; }
        public string CINSPECTDEPCODE { get; set; }
        public string CVOUCHTYPE { get; set; }
        public string CINSPECTPERSON { get; set; }
        public Nullable<System.DateTime> DINSPECTDATE { get; set; }
        public string CINSPECTTIME { get; set; }
        public Nullable<int> IORDERTYPE { get; set; }
        public string ISOORDERAUTOID { get; set; }
        public string CSOORDERCODE { get; set; }
        public Nullable<byte> ISOORDERTYPE { get; set; }
        public string CORDERCODE { get; set; }
        public Nullable<int> IORDERSEQ { get; set; }
        public Nullable<int> IORDERDID { get; set; }
        public string CITEMCLASS { get; set; }
        public string CITEMCNAME { get; set; }
        public string CITEMCODE { get; set; }
        public string CITEMNAME { get; set; }
        public string CWHCODE { get; set; }
        public Nullable<bool> BEXIGENCY { get; set; }
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
        public Nullable<System.DateTime> DPRODATE { get; set; }
        public Nullable<short> IMASSDATE { get; set; }
        public string CMASSUNIT { get; set; }
        public Nullable<System.DateTime> DVDATE { get; set; }
        public string CEXPIRATIONDATE { get; set; }
        public Nullable<System.DateTime> DEXPIRATIONDATE { get; set; }
        public Nullable<short> IEXPIRATDATECALCU { get; set; }
        public Nullable<decimal> FCHANGRATE { get; set; }
        public Nullable<decimal> FCHECKCHANGRATE { get; set; }
        public Nullable<decimal> FCHECKRATE { get; set; }
        public Nullable<decimal> FCHECKNUM { get; set; }
        public Nullable<decimal> FCHECKQTY { get; set; }
        public Nullable<decimal> FQUANTITY { get; set; }
        public Nullable<decimal> FNUM { get; set; }
        public string CCHECKUNIT { get; set; }
        public string CUNITID { get; set; }
        public Nullable<decimal> FREGQUANTITY { get; set; }
        public Nullable<decimal> FREGNUM { get; set; }
        public Nullable<decimal> FCONQUANTIY { get; set; }
        public Nullable<decimal> FCONNUM { get; set; }
        public Nullable<decimal> FDISQUANTITY { get; set; }
        public Nullable<decimal> FDISNUM { get; set; }
        public Nullable<decimal> FREGBREAKQUANTITY { get; set; }
        public Nullable<decimal> FREGBREAKNUM { get; set; }
        public Nullable<int> IFREGBREAKQTYDEALTYPE { get; set; }
        public Nullable<int> IDISBREAKQTYDEALTYPE { get; set; }
        public Nullable<int> IBATCHCHKRESULT { get; set; }
        public Nullable<decimal> FSUMQUANTITY { get; set; }
        public Nullable<decimal> FSUMNUM { get; set; }
        public Nullable<bool> BPUINFLAG { get; set; }
        public Nullable<bool> BREJFLAG { get; set; }
        public string CMEMO { get; set; }
        public byte[] UFTS { get; set; }
        public string CSOURCEPROORDERCODE { get; set; }
        public Nullable<int> ISOURCEPROORDERAUTOID { get; set; }
        public string CPROORDERCODE { get; set; }
        public string IPROORDERID { get; set; }
        public string IPROORDERAUTOID { get; set; }
        public string ISOURCEPROORDERID { get; set; }
        public string bproinflag { get; set; }
        public string ISOURCEPROORDERROWNO { get; set; }
        public string CPROBATCH { get; set; }
        public string PLANLOTNUMBER { get; set; }
    
        public virtual Department Department { get; set; }
        public virtual Vendor Vendor { get; set; }
        public virtual Warehouse Warehouse { get; set; }
    }
}
