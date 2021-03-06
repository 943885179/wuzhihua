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
    
    public partial class Warehouse
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Warehouse()
        {
            this.AssemVouchs = new HashSet<AssemVouchs>();
            this.CheckVouch = new HashSet<CheckVouch>();
            this.DispatchLists = new HashSet<DispatchLists>();
            this.EnDispatchs = new HashSet<EnDispatchs>();
            this.JustInVouch = new HashSet<JustInVouch>();
            this.MaterialAppVouchs = new HashSet<MaterialAppVouchs>();
            this.ProductStructures = new HashSet<ProductStructures>();
            this.PU_ArrivalVouchs = new HashSet<PU_ArrivalVouchs>();
            this.PU_T_VMIUsedVouchs = new HashSet<PU_T_VMIUsedVouchs>();
            this.QMCHECKVOUCHER = new HashSet<QMCHECKVOUCHER>();
            this.QMINSPECTVOUCHERS = new HashSet<QMINSPECTVOUCHERS>();
            this.QMMergeCheckDetail = new HashSet<QMMergeCheckDetail>();
            this.QMREJECTVOUCHER = new HashSet<QMREJECTVOUCHER>();
            this.rdrecord891bak = new HashSet<rdrecord891bak>();
            this.SaleBillVouchs = new HashSet<SaleBillVouchs>();
            this.St_QCQualifiedSNdetail = new HashSet<St_QCQualifiedSNdetail>();
            this.TransVouch = new HashSet<TransVouch>();
            this.TransVouch1 = new HashSet<TransVouch>();
            this.Vendor = new HashSet<Vendor>();
            this.ATP_ProjectMain = new HashSet<ATP_ProjectMain>();
        }
    
        public string cWhCode { get; set; }
        public string cWhName { get; set; }
        public string cDepCode { get; set; }
        public string cWhAddress { get; set; }
        public string cWhPhone { get; set; }
        public string cWhPerson { get; set; }
        public string cWhValueStyle { get; set; }
        public bool bWhPos { get; set; }
        public Nullable<double> iWhFundQuota { get; set; }
        public string cMonth { get; set; }
        public string cWhMemo { get; set; }
        public bool bFreeze { get; set; }
        public string cBarCode { get; set; }
        public bool bMRP { get; set; }
        public byte[] pubufts { get; set; }
        public bool bROP { get; set; }
        public Nullable<short> iFrequency { get; set; }
        public string cFrequency { get; set; }
        public Nullable<short> iDays { get; set; }
        public Nullable<System.DateTime> dLastDate { get; set; }
        public short iWHProperty { get; set; }
        public bool bShop { get; set; }
        public bool bControlSerial { get; set; }
        public bool bInCost { get; set; }
        public bool bInAvailCalcu { get; set; }
        public bool bProxyWh { get; set; }
        public short iSAConMode { get; set; }
        public short iEXConMode { get; set; }
        public short iSTConMode { get; set; }
        public bool bBondedWh { get; set; }
        public bool bWhAsset { get; set; }
        public Nullable<double> fWhQuota { get; set; }
        public Nullable<System.DateTime> dWhEndDate { get; set; }
        public Nullable<bool> bCheckSubitemCost { get; set; }
        public string cPickPos { get; set; }
        public Nullable<bool> bEB { get; set; }
        public Nullable<System.DateTime> dModifyDate { get; set; }
        public string cWareGroupCode { get; set; }
        public string cProvince { get; set; }
        public string cCity { get; set; }
        public string cCounty { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssemVouchs> AssemVouchs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CheckVouch> CheckVouch { get; set; }
        public virtual Department Department { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DispatchLists> DispatchLists { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EnDispatchs> EnDispatchs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JustInVouch> JustInVouch { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaterialAppVouchs> MaterialAppVouchs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductStructures> ProductStructures { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PU_ArrivalVouchs> PU_ArrivalVouchs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PU_T_VMIUsedVouchs> PU_T_VMIUsedVouchs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QMCHECKVOUCHER> QMCHECKVOUCHER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QMINSPECTVOUCHERS> QMINSPECTVOUCHERS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QMMergeCheckDetail> QMMergeCheckDetail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QMREJECTVOUCHER> QMREJECTVOUCHER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rdrecord891bak> rdrecord891bak { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SaleBillVouchs> SaleBillVouchs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<St_QCQualifiedSNdetail> St_QCQualifiedSNdetail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransVouch> TransVouch { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransVouch> TransVouch1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vendor> Vendor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ATP_ProjectMain> ATP_ProjectMain { get; set; }
    }
}
