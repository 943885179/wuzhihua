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
    
    public partial class MaterialAppVouch
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MaterialAppVouch()
        {
            this.MaterialAppVouchs = new HashSet<MaterialAppVouchs>();
        }
    
        public int ID { get; set; }
        public System.DateTime dDate { get; set; }
        public string cCode { get; set; }
        public string cRdCode { get; set; }
        public string cDepCode { get; set; }
        public string cPersonCode { get; set; }
        public string cItem_class { get; set; }
        public string cItemCode { get; set; }
        public string cName { get; set; }
        public string cItemCName { get; set; }
        public string cHandler { get; set; }
        public string cMemo { get; set; }
        public string cCloser { get; set; }
        public string cMaker { get; set; }
        public string cDefine1 { get; set; }
        public string cDefine2 { get; set; }
        public string cDefine3 { get; set; }
        public Nullable<System.DateTime> cDefine4 { get; set; }
        public Nullable<int> cDefine5 { get; set; }
        public Nullable<System.DateTime> cDefine6 { get; set; }
        public Nullable<double> cDefine7 { get; set; }
        public string cDefine8 { get; set; }
        public string cDefine9 { get; set; }
        public string cDefine10 { get; set; }
        public Nullable<System.DateTime> dVeriDate { get; set; }
        public Nullable<int> VT_ID { get; set; }
        public string cDefine11 { get; set; }
        public string cDefine12 { get; set; }
        public string cDefine13 { get; set; }
        public string cDefine14 { get; set; }
        public Nullable<int> cDefine15 { get; set; }
        public Nullable<double> cDefine16 { get; set; }
        public byte[] ufts { get; set; }
        public Nullable<int> ireturncount { get; set; }
        public Nullable<int> iverifystate { get; set; }
        public Nullable<int> iswfcontrolled { get; set; }
        public string cModifyPerson { get; set; }
        public Nullable<System.DateTime> dModifyDate { get; set; }
        public Nullable<System.DateTime> dnmaketime { get; set; }
        public Nullable<System.DateTime> dnmodifytime { get; set; }
        public Nullable<System.DateTime> dnverifytime { get; set; }
        public Nullable<int> iPrintCount { get; set; }
        public string cSource { get; set; }
        public string cvencode { get; set; }
        public Nullable<decimal> imquantity { get; set; }
        public string csysbarcode { get; set; }
        public string cCurrentAuditor { get; set; }
        public string cChanger { get; set; }
    
        public virtual Department Department { get; set; }
        public virtual Person Person { get; set; }
        public virtual Rd_Style Rd_Style { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaterialAppVouchs> MaterialAppVouchs { get; set; }
    }
}
