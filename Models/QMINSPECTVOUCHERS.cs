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
    
    public partial class QMINSPECTVOUCHERS
    {
        public int ID { get; set; }
        public int AUTOID { get; set; }
        public string CITEMCLASS { get; set; }
        public string CITEMCODE { get; set; }
        public string CITEMCNAME { get; set; }
        public string CITEMNAME { get; set; }
        public Nullable<int> REJECTAUTOID { get; set; }
        public Nullable<int> SOURCEAUTOID { get; set; }
        public Nullable<int> ITESTSTYLE { get; set; }
        public string CWHCODE { get; set; }
        public string CINVCODE { get; set; }
        public string CPROBATCH { get; set; }
        public string CBATCH { get; set; }
        public Nullable<System.DateTime> DPRODATE { get; set; }
        public Nullable<System.DateTime> DVDATE { get; set; }
        public string CUNITID { get; set; }
        public Nullable<decimal> FCHANGRATE { get; set; }
        public Nullable<decimal> FQUANTITY { get; set; }
        public Nullable<decimal> FNUM { get; set; }
        public Nullable<bool> BFLAG { get; set; }
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
        public string CPOSITION { get; set; }
        public string CBYPRODUCT { get; set; }
        public Nullable<short> IMASSDATE { get; set; }
        public string CMASSUNIT { get; set; }
        public Nullable<int> IORDERTYPE { get; set; }
        public string CSOORDERCODE { get; set; }
        public string ISOORDERAUTOID { get; set; }
        public Nullable<int> IPROORDERID { get; set; }
        public string CPROORDERCODE { get; set; }
        public Nullable<int> IPROORDERAUTOID { get; set; }
        public string CCONTRACTCODE { get; set; }
        public string CCONTRACTSTRCODE { get; set; }
        public string CPOCODE { get; set; }
        public Nullable<bool> BEXIGENCY { get; set; }
        public string PcsTransType { get; set; }
        public string CVMIVENCODE { get; set; }
        public string CSOURCEPROORDERCODE { get; set; }
        public Nullable<int> ISOURCEPROORDERROWNO { get; set; }
        public Nullable<int> ISOURCEPROORDERID { get; set; }
        public Nullable<int> ISOURCEPROORDERAUTOID { get; set; }
        public Nullable<short> iExpiratDateCalcu { get; set; }
        public string cExpirationdate { get; set; }
        public Nullable<System.DateTime> dExpirationdate { get; set; }
        public Nullable<decimal> cBatchProperty1 { get; set; }
        public Nullable<decimal> cBatchProperty2 { get; set; }
        public Nullable<decimal> cBatchProperty3 { get; set; }
        public Nullable<decimal> cBatchProperty4 { get; set; }
        public Nullable<decimal> cBatchProperty5 { get; set; }
        public string cBatchProperty6 { get; set; }
        public string cBatchProperty7 { get; set; }
        public string cBatchProperty8 { get; set; }
        public string cBatchProperty9 { get; set; }
        public Nullable<System.DateTime> cBatchProperty10 { get; set; }
        public Nullable<int> IORDERDID { get; set; }
        public Nullable<byte> ISOORDERTYPE { get; set; }
        public string CORDERCODE { get; set; }
        public Nullable<int> IORDERSEQ { get; set; }
        public string CRETURNREASONCODE { get; set; }
        public string PFCODE { get; set; }
        public Nullable<decimal> FSUMCHECKQTY { get; set; }
        public Nullable<decimal> FSUMCHECKNUM { get; set; }
        public Nullable<bool> BMERGECHECKFLAG { get; set; }
        public string CCHECKCODE { get; set; }
        public string CBSYSBARCODE { get; set; }
        public string FCVOUCHERCODE { get; set; }
        public Nullable<int> FCVOUCHERSID { get; set; }
        public string PLANLOTNUMBER { get; set; }
    
        public virtual Warehouse Warehouse { get; set; }
    }
}
