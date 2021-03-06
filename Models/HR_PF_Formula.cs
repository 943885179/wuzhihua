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
    
    public partial class HR_PF_Formula
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HR_PF_Formula()
        {
            this.HR_PF_FormulaCondition = new HashSet<HR_PF_FormulaCondition>();
        }
    
        public System.Guid uFormulaPK { get; set; }
        public int iOrder { get; set; }
        public short sFormulaType { get; set; }
        public short sCalcProcess { get; set; }
        public string cSchemaCode { get; set; }
        public string cPlanCode { get; set; }
        public string cDepCode { get; set; }
        public string cPsn_Num { get; set; }
        public string cTargetCode { get; set; }
        public Nullable<short> sColumnType { get; set; }
        public string cColumnCode { get; set; }
        public Nullable<short> sCaculateType { get; set; }
        public string cFormulaSQL { get; set; }
        public string cFormulaDesc { get; set; }
        public string cColumnsInFormula { get; set; }
        public byte[] tStamp { get; set; }
        public string cDefine1 { get; set; }
        public string cDefine2 { get; set; }
        public string cDefine3 { get; set; }
        public Nullable<bool> bIsStart { get; set; }
    
        public virtual Department Department { get; set; }
        public virtual hr_hi_person hr_hi_person { get; set; }
        public virtual HR_PF_Column HR_PF_Column { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HR_PF_FormulaCondition> HR_PF_FormulaCondition { get; set; }
        public virtual HR_PF_Plan HR_PF_Plan { get; set; }
        public virtual HR_PF_Schema HR_PF_Schema { get; set; }
        public virtual HR_PF_Target HR_PF_Target { get; set; }
    }
}
