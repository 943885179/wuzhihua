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
    
    public partial class vouchers_base
    {
        public string CardNumber { get; set; }
        public Nullable<bool> Shield { get; set; }
        public string Name { get; set; }
        public string CardType { get; set; }
        public string ItemTblName { get; set; }
        public Nullable<int> itemCol { get; set; }
        public string BTTblName { get; set; }
        public string BTQName { get; set; }
        public string BWTblName { get; set; }
        public string BWQName { get; set; }
        public string VchListQName { get; set; }
        public bool HaveBodyGrid { get; set; }
        public Nullable<bool> BodyModify { get; set; }
        public Nullable<int> VoucherWidth { get; set; }
        public Nullable<int> VoucherHeight { get; set; }
        public Nullable<int> BodyTop { get; set; }
        public Nullable<int> BodyLeft { get; set; }
        public Nullable<int> BodyWidth { get; set; }
        public Nullable<int> BodyHeight { get; set; }
        public string SelfDef1 { get; set; }
        public string SelfDef2 { get; set; }
        public string SelfDef3 { get; set; }
        public Nullable<int> DEF_ID { get; set; }
        public Nullable<int> DEF_ID_PRN { get; set; }
        public string cSub_Id { get; set; }
        public string Memo { get; set; }
        public int iOrder { get; set; }
        public string cIndustry { get; set; }
        public bool bAllowMulTemp { get; set; }
        public string cDefWhere { get; set; }
        public byte[] pubufts { get; set; }
        public string vchtblPrimarykeyNames { get; set; }
        public string ReceiptNoFieldName { get; set; }
        public Nullable<bool> IsPrintLimited { get; set; }
        public Nullable<bool> AllowDateTimeFormat { get; set; }
        public Nullable<bool> NotAppiesAuth { get; set; }
        public string InventoryFieldName { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
        public string cHeadBusObjectId { get; set; }
        public string cBodyBusObjectId { get; set; }
        public string cHeadFuncName { get; set; }
        public string cBodyFuncName { get; set; }
        public string cFieldAuthid { get; set; }
        public string vchBodyPKName { get; set; }
        public string BodyFKName { get; set; }
        public string BodyDefaultConditionFieldName { get; set; }
        public Nullable<bool> IsAuditedPrint { get; set; }
        public Nullable<bool> IsAlertAuditedPrint { get; set; }
        public string AuditFieldName { get; set; }
        public string AlertFieldName { get; set; }
        public string AlertAuditFieldName { get; set; }
        public string PrintCountFieldName { get; set; }
        public string iVT_IDFieldName { get; set; }
        public string cSub_IdLocation { get; set; }
        public Nullable<bool> bApplyWordTemplate { get; set; }
        public string cBarCodeFieldNames { get; set; }
        public string cParentKey { get; set; }
        public string cKey { get; set; }
    }
}
