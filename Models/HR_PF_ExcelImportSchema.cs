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
    
    public partial class HR_PF_ExcelImportSchema
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HR_PF_ExcelImportSchema()
        {
            this.HR_PF_ExcelImportSchemaRelation = new HashSet<HR_PF_ExcelImportSchemaRelation>();
        }
    
        public string cSchemaCode { get; set; }
        public string cSchemaName { get; set; }
        public string cUpUserCode { get; set; }
        public System.DateTime dUpDate { get; set; }
        public byte[] cFileContent { get; set; }
        public short sDataModel { get; set; }
        public byte[] tStamp { get; set; }
        public string cDefine1 { get; set; }
        public string cDefine2 { get; set; }
        public string cDefine3 { get; set; }
        public string cImportUserCode { get; set; }
        public Nullable<System.DateTime> dImportDate { get; set; }
        public Nullable<int> iImportCount { get; set; }
        public Nullable<int> iFailCount { get; set; }
        public string cFileName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HR_PF_ExcelImportSchemaRelation> HR_PF_ExcelImportSchemaRelation { get; set; }
    }
}
