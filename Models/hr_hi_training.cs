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
    
    public partial class hr_hi_training
    {
        public System.Guid PK_hr_hi_training { get; set; }
        public string cPsn_Num { get; set; }
        public Nullable<int> iRecordID { get; set; }
        public Nullable<bool> blastflag { get; set; }
        public string vstatus1 { get; set; }
        public Nullable<decimal> nstatus2 { get; set; }
        public string rtra_Type { get; set; }
        public string rtra_chara { get; set; }
        public string rtra_mode { get; set; }
        public string dbegindate { get; set; }
        public string denddate { get; set; }
        public Nullable<decimal> itra_time { get; set; }
        public string vtra_content { get; set; }
        public string vtra_className { get; set; }
        public string vtra_act { get; set; }
        public Nullable<decimal> ntra_cost { get; set; }
        public Nullable<decimal> ntra_score { get; set; }
        public string rtra_result { get; set; }
        public string vChargeUnit { get; set; }
        public string rcuType { get; set; }
        public string vStudyUnit { get; set; }
        public string rsuType { get; set; }
        public Nullable<System.Guid> fk_PK_hr_tr_activity { get; set; }
        public string rtrainitem { get; set; }
        public string rtrainlevel { get; set; }
        public string rtraindpt { get; set; }
        public Nullable<int> itrainyear { get; set; }
        public Nullable<int> itrainseason { get; set; }
        public string vtrainsubject { get; set; }
        public string vtrainaim { get; set; }
        public string vtraincertificate { get; set; }
        public string rorgname { get; set; }
        public string vtrainaddress { get; set; }
        public string vtrainprotocalnum { get; set; }
        public bool btrainafterunit { get; set; }
        public string vremark { get; set; }
        public byte[] hrts { get; set; }
        public string dCertificateValidate { get; set; }
        public string dCertificateFailure { get; set; }
        public string cVoucherId { get; set; }
    }
}
