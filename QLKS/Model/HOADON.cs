
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace QLKS.Model
{

using System;
    using System.Collections.Generic;
    
public partial class HOADON
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public HOADON()
    {

        this.CHITIET_HDAU = new HashSet<CHITIET_HDAU>();

        this.CHITIET_HDDC = new HashSet<CHITIET_HDDC>();

        this.CHITIET_HDGU = new HashSet<CHITIET_HDGU>();

        this.CHITIET_HDLT = new HashSet<CHITIET_HDLT>();

    }


    public int MA_HD { get; set; }

    public int MA_NV { get; set; }

    public int MA_KH { get; set; }

    public Nullable<System.DateTime> THOIGIANLAP_HD { get; set; }

    public Nullable<bool> TINHTRANG_HD { get; set; }

    public Nullable<decimal> TRIGIA_HD { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<CHITIET_HDAU> CHITIET_HDAU { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<CHITIET_HDDC> CHITIET_HDDC { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<CHITIET_HDGU> CHITIET_HDGU { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<CHITIET_HDLT> CHITIET_HDLT { get; set; }

    public virtual KHACHHANG KHACHHANG { get; set; }

    public virtual NHANVIEN NHANVIEN { get; set; }

}

}
