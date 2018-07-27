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
    
    public partial class IM_Order_History
    {
        public string guid { get; set; }
        public int id { get; set; }
        public string ccode { get; set; }
        public System.DateTime ddate { get; set; }
        public string cvencode { get; set; }
        public string cbargainno { get; set; }
        public string cdepcode { get; set; }
        public string cpersoncode { get; set; }
        public Nullable<int> iimbustype { get; set; }
        public string cptcode { get; set; }
        public string ctmcode { get; set; }
        public string cincotermcode { get; set; }
        public string cpaycode { get; set; }
        public string cpayitem { get; set; }
        public string csscode { get; set; }
        public string cgatheringplan { get; set; }
        public Nullable<System.DateTime> dcreditstart { get; set; }
        public Nullable<System.DateTime> dgatheringdate { get; set; }
        public Nullable<int> icreditdays { get; set; }
        public string cexch_name { get; set; }
        public Nullable<decimal> fexchrate { get; set; }
        public Nullable<int> idec { get; set; }
        public Nullable<bool> bcal { get; set; }
        public string csportcode { get; set; }
        public string caportcode { get; set; }
        public string csccode { get; set; }
        public string carrivalplace { get; set; }
        public Nullable<System.DateTime> dlastladedate { get; set; }
        public Nullable<decimal> fgeneraloverflowrange { get; set; }
        public Nullable<System.DateTime> dplanarrivaldate { get; set; }
        public string cmemo { get; set; }
        public string cinvgeneraldesc { get; set; }
        public Nullable<decimal> fsummoney { get; set; }
        public string cchinesesummoney { get; set; }
        public string cenglishsummoney { get; set; }
        public Nullable<decimal> fnatsummoney { get; set; }
        public string cmaker { get; set; }
        public string calter { get; set; }
        public Nullable<System.DateTime> dalterdate { get; set; }
        public string cverifier { get; set; }
        public Nullable<System.DateTime> dverifydate { get; set; }
        public Nullable<int> iverifystate { get; set; }
        public string cprinter { get; set; }
        public Nullable<System.DateTime> dprintdate { get; set; }
        public Nullable<int> iprinttime { get; set; }
        public string ccloser { get; set; }
        public Nullable<System.DateTime> dclosedate { get; set; }
        public string clocker { get; set; }
        public string cdefine1 { get; set; }
        public string cdefine2 { get; set; }
        public string cdefine3 { get; set; }
        public Nullable<System.DateTime> cdefine4 { get; set; }
        public Nullable<int> cdefine5 { get; set; }
        public Nullable<System.DateTime> cdefine6 { get; set; }
        public Nullable<decimal> cdefine7 { get; set; }
        public string cdefine8 { get; set; }
        public string cdefine9 { get; set; }
        public string cdefine10 { get; set; }
        public string cdefine11 { get; set; }
        public string cdefine12 { get; set; }
        public string cdefine13 { get; set; }
        public string cdefine14 { get; set; }
        public Nullable<int> cdefine15 { get; set; }
        public Nullable<double> cdefine16 { get; set; }
        public Nullable<byte> cstate { get; set; }
        public int ivtid { get; set; }
        public byte[] ufts { get; set; }
        public Nullable<int> iflowstate { get; set; }
        public Nullable<int> ireturncount { get; set; }
        public Nullable<bool> iswfcontrolled { get; set; }
        public Nullable<System.DateTime> dmodifydate { get; set; }
        public Nullable<System.DateTime> dmodifysystime { get; set; }
        public Nullable<System.DateTime> dverifysystime { get; set; }
        public Nullable<System.DateTime> dcreatesystime { get; set; }
        public string cmodifier { get; set; }
        public Nullable<long> HistoryId { get; set; }
        public Nullable<int> VariationLogId { get; set; }
        public Nullable<byte> VariationAction { get; set; }
        public Nullable<byte> SubVariationAction { get; set; }
        public Nullable<System.DateTime> dclosetime { get; set; }
        public string cvenpersoncode { get; set; }
        public string cvenperson { get; set; }
        public string cvenbank { get; set; }
        public string cvenaccount { get; set; }
        public string cCurrentAuditor { get; set; }
        public string ccuscode { get; set; }
        public Nullable<short> iagentfeecalctype { get; set; }
        public Nullable<decimal> fagentfeemoneyrate { get; set; }
        public Nullable<double> fagentfeeqtyrate { get; set; }
        public Nullable<double> fnatagentfee { get; set; }
        public Nullable<decimal> fagentfeesettled { get; set; }
        public Nullable<decimal> fnatsummoneysettled { get; set; }
        public Nullable<bool> bimportagentstore { get; set; }
        public string ccuspersoncode { get; set; }
        public string ccusperson { get; set; }
        public string ccusaccount { get; set; }
        public Nullable<decimal> fpaysummoney { get; set; }
        public Nullable<decimal> fnatpaysummoney { get; set; }
    }
}
