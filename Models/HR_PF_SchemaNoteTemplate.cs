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
    
    public partial class HR_PF_SchemaNoteTemplate
    {
        public System.Guid uSchemaNoteTemplatePK { get; set; }
        public string cSchemaCode { get; set; }
        public short sMsgTemplateType { get; set; }
        public string cTargetCode { get; set; }
        public string cColumnCode { get; set; }
        public int iRowNumber { get; set; }
        public byte[] tStamp { get; set; }
        public string cDefine1 { get; set; }
        public string cDefine2 { get; set; }
        public string cDefine3 { get; set; }
    
        public virtual HR_PF_Column HR_PF_Column { get; set; }
        public virtual HR_PF_Schema HR_PF_Schema { get; set; }
        public virtual HR_PF_Target HR_PF_Target { get; set; }
    }
}
