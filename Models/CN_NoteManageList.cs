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
    
    public partial class CN_NoteManageList
    {
        public int ID { get; set; }
        public Nullable<int> ManageAcctID { get; set; }
        public string NoteID { get; set; }
        public Nullable<int> StateID { get; set; }
        public string NoteNumber { get; set; }
        public string PayPW { get; set; }
        public string Payee { get; set; }
        public string PayeeAcct { get; set; }
        public Nullable<int> PayeeID { get; set; }
        public string Payer { get; set; }
        public string PayerAcct { get; set; }
        public Nullable<int> PayerID { get; set; }
        public string Purpose { get; set; }
        public Nullable<decimal> Money { get; set; }
        public Nullable<decimal> Limitation { get; set; }
        public Nullable<int> IsCancel { get; set; }
        public Nullable<int> IsPrint { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> RemitDate { get; set; }
        public Nullable<System.DateTime> UseDate { get; set; }
        public Nullable<System.DateTime> WriteOffDate { get; set; }
        public Nullable<System.DateTime> VerifyDate { get; set; }
        public Nullable<System.DateTime> RemindDate { get; set; }
        public string UseUser { get; set; }
        public string WriteOffUser { get; set; }
        public string VerifyUser { get; set; }
        public string Remark { get; set; }
        public Nullable<int> IsPreInvoice { get; set; }
        public Nullable<int> UnitType { get; set; }
        public string cOper { get; set; }
        public string cOperator { get; set; }
        public Nullable<System.DateTime> dtOperatTime { get; set; }
    }
}
