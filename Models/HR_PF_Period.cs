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
    
    public partial class HR_PF_Period
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HR_PF_Period()
        {
            this.HR_PF_AppraiseData = new HashSet<HR_PF_AppraiseData>();
            this.HR_PF_FormulaPerformanceResult = new HashSet<HR_PF_FormulaPerformanceResult>();
            this.HR_PF_FormulaPerformanceResultRelation = new HashSet<HR_PF_FormulaPerformanceResultRelation>();
            this.HR_PF_FormulaTarget = new HashSet<HR_PF_FormulaTarget>();
            this.HR_PF_GoalChangeChild = new HashSet<HR_PF_GoalChangeChild>();
            this.HR_PF_OperationFormula = new HashSet<HR_PF_OperationFormula>();
            this.HR_PF_PerformanceResult = new HashSet<HR_PF_PerformanceResult>();
            this.HR_PF_PersonTableStructure = new HashSet<HR_PF_PersonTableStructure>();
            this.HR_PF_Plan = new HashSet<HR_PF_Plan>();
            this.HR_PF_ResultChangeChild = new HashSet<HR_PF_ResultChangeChild>();
            this.HR_PF_ResultChangeTargetChild = new HashSet<HR_PF_ResultChangeTargetChild>();
            this.HR_PF_SchemaTableStructure = new HashSet<HR_PF_SchemaTableStructure>();
            this.HR_PF_TableData = new HashSet<HR_PF_TableData>();
        }
    
        public string cPeriodValue { get; set; }
        public string cPeriodName { get; set; }
        public short sPeriodType { get; set; }
        public string sYear { get; set; }
        public string sHalfYear { get; set; }
        public string sSeason { get; set; }
        public string sMonth { get; set; }
        public string sWeek { get; set; }
        public string sDay { get; set; }
        public byte[] tStamp { get; set; }
        public string cDefine1 { get; set; }
        public string cDefine2 { get; set; }
        public string cDefine3 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HR_PF_AppraiseData> HR_PF_AppraiseData { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HR_PF_FormulaPerformanceResult> HR_PF_FormulaPerformanceResult { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HR_PF_FormulaPerformanceResultRelation> HR_PF_FormulaPerformanceResultRelation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HR_PF_FormulaTarget> HR_PF_FormulaTarget { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HR_PF_GoalChangeChild> HR_PF_GoalChangeChild { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HR_PF_OperationFormula> HR_PF_OperationFormula { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HR_PF_PerformanceResult> HR_PF_PerformanceResult { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HR_PF_PersonTableStructure> HR_PF_PersonTableStructure { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HR_PF_Plan> HR_PF_Plan { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HR_PF_ResultChangeChild> HR_PF_ResultChangeChild { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HR_PF_ResultChangeTargetChild> HR_PF_ResultChangeTargetChild { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HR_PF_SchemaTableStructure> HR_PF_SchemaTableStructure { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HR_PF_TableData> HR_PF_TableData { get; set; }
    }
}
