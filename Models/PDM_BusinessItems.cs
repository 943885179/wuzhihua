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
    
    public partial class PDM_BusinessItems
    {
        public int id { get; set; }
        public int iMetaId { get; set; }
        public string cRegCode { get; set; }
        public string cSource { get; set; }
        public Nullable<short> bMustSel { get; set; }
        public string cDefault { get; set; }
        public string cRefInvCode { get; set; }
        public string cPDMField { get; set; }
        public string cRemarks { get; set; }
        public short iActionType { get; set; }
        public short bEnabled { get; set; }
        public short bIsPDM { get; set; }
        public Nullable<short> bForceErp { get; set; }
        public string cPdmTable { get; set; }
        public Nullable<short> iNormal { get; set; }
    }
}
