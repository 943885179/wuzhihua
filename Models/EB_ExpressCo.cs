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
    
    public partial class EB_ExpressCo
    {
        public long OID { get; set; }
        public string cExpressCoCode { get; set; }
        public string cExpressCoName { get; set; }
        public string cVenCode { get; set; }
        public string cVenName { get; set; }
        public Nullable<int> iYKg { get; set; }
        public Nullable<decimal> iYKgPrice { get; set; }
        public string cPriceExplain { get; set; }
        public string cUnreachProvinceCode { get; set; }
        public string cUnreachProvinceName { get; set; }
        public string cUnreachCityCode { get; set; }
        public string cUnreachCityName { get; set; }
        public string cUnreachDistrictCode { get; set; }
        public string cUnreachDistrictName { get; set; }
        public Nullable<bool> bCOD { get; set; }
        public Nullable<decimal> decCODCommission { get; set; }
        public Nullable<bool> bDefault { get; set; }
        public Nullable<bool> bUsing { get; set; }
        public Nullable<int> cExpressPrintTempCode { get; set; }
        public string cStartExpressCode { get; set; }
        public string cExpressPrinter { get; set; }
        public byte[] utfs { get; set; }
        public string cCompanyCode { get; set; }
        public string Telephone { get; set; }
        public Nullable<byte> bOffline { get; set; }
        public string iGrade { get; set; }
    }
}
