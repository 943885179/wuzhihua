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
    
    public partial class HY_DZ_BorrowOuts
    {
        public long ID { get; set; }
        public long AutoID { get; set; }
        public string cinvcode { get; set; }
        public string cwhcode { get; set; }
        public string cPosition { get; set; }
        public Nullable<decimal> iquantity { get; set; }
        public Nullable<decimal> inum { get; set; }
        public Nullable<decimal> iinvexchrate { get; set; }
        public Nullable<decimal> iQtyOut { get; set; }
        public Nullable<decimal> iQtyOut2 { get; set; }
        public Nullable<decimal> iQtyBack { get; set; }
        public Nullable<decimal> iQtyBack2 { get; set; }
        public Nullable<decimal> iQtyCOut { get; set; }
        public Nullable<decimal> iQtyCOut2 { get; set; }
        public Nullable<decimal> iQtyCSale { get; set; }
        public Nullable<decimal> iQtyCSale2 { get; set; }
        public Nullable<decimal> iQtyCFree { get; set; }
        public Nullable<decimal> iQtyCFree2 { get; set; }
        public Nullable<decimal> iQtyCOver { get; set; }
        public Nullable<decimal> iQtyCOver2 { get; set; }
        public Nullable<System.DateTime> backdate { get; set; }
        public string cmemo { get; set; }
        public string cunitid { get; set; }
        public string cbatch { get; set; }
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
        public string cdefine22 { get; set; }
        public string cdefine23 { get; set; }
        public string cdefine24 { get; set; }
        public string cdefine25 { get; set; }
        public Nullable<decimal> cdefine26 { get; set; }
        public Nullable<decimal> cdefine27 { get; set; }
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
        public string MycdefineB1 { get; set; }
        public string MycdefineB2 { get; set; }
        public string MycdefineB3 { get; set; }
        public string MycdefineB4 { get; set; }
        public string MycdefineB5 { get; set; }
        public string MycdefineB6 { get; set; }
        public string MycdefineB7 { get; set; }
        public string MycdefineB8 { get; set; }
        public string MycdefineB9 { get; set; }
        public string MycdefineB10 { get; set; }
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
        public string cbsysbarcode { get; set; }
        public Nullable<System.DateTime> dmadedate { get; set; }
        public Nullable<int> imassdate { get; set; }
        public Nullable<short> cmassunit { get; set; }
        public Nullable<System.DateTime> dvdate { get; set; }
        public Nullable<System.DateTime> dexpirationdate { get; set; }
        public Nullable<short> iexpiratDateCalcu { get; set; }
        public string cexpirationdate { get; set; }
        public Nullable<short> bborrowoutback { get; set; }
        public string smpdescription { get; set; }
        public Nullable<System.DateTime> expdate { get; set; }
        public Nullable<System.DateTime> expfeedbackdate { get; set; }
        public Nullable<decimal> untreatedqty { get; set; }
    
        public virtual HY_DZ_BorrowOut HY_DZ_BorrowOut { get; set; }
    }
}
