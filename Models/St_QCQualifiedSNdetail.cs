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
    
    public partial class St_QCQualifiedSNdetail
    {
        public int AutoID { get; set; }
        public string cVouchType { get; set; }
        public string cWhCode { get; set; }
        public string cInvCode { get; set; }
        public Nullable<double> iquantity { get; set; }
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
        public string cBatch { get; set; }
        public Nullable<System.DateTime> dMadeDate { get; set; }
        public Nullable<short> cMassUnit { get; set; }
        public Nullable<int> imassdate { get; set; }
        public Nullable<System.DateTime> dvdate { get; set; }
        public string cInVouchCode { get; set; }
        public Nullable<long> cVouchCode { get; set; }
        public string cBVencode { get; set; }
        public string cPosition { get; set; }
        public string cMaker { get; set; }
        public System.DateTime dDate { get; set; }
        public string cHandler { get; set; }
        public Nullable<System.DateTime> dVeriDate { get; set; }
        public Nullable<int> iSourceIds { get; set; }
        public Nullable<int> VT_ID { get; set; }
        public Nullable<int> iInvSNCount { get; set; }
        public byte[] ufts { get; set; }
        public string cinvouchtype { get; set; }
    
        public virtual Warehouse Warehouse { get; set; }
    }
}
