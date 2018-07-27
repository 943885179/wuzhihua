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
    
    public partial class ExpenseItem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ExpenseItem()
        {
            this.ExpenseVouchs = new HashSet<ExpenseVouchs>();
            this.SalePayVouchs = new HashSet<SalePayVouchs>();
            this.SR_ServiceExpense_S = new HashSet<SR_ServiceExpense_S>();
        }
    
        public string cExpCode { get; set; }
        public string cExpName { get; set; }
        public string cExpMemo { get; set; }
        public byte[] pubufts { get; set; }
        public string cExpProfitCode { get; set; }
        public string cExpCCode { get; set; }
        public Nullable<double> iExpTaxRate { get; set; }
        public Nullable<short> iExpProfitItem { get; set; }
        public string CCode { get; set; }
        public Nullable<int> Direction { get; set; }
        public string BudgetItemCode { get; set; }
        public string BudgetItemName { get; set; }
        public string OperationTypeCode { get; set; }
        public string OperationTypeName { get; set; }
        public Nullable<bool> IsSubsidy { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExpenseVouchs> ExpenseVouchs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalePayVouchs> SalePayVouchs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SR_ServiceExpense_S> SR_ServiceExpense_S { get; set; }
    }
}
