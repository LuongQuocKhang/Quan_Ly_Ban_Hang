//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

public partial class NHANVIEN
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public NHANVIEN()
    {
        this.HOADONBHs = new HashSet<HOADONBH>();
        this.TAIKHOANs = new HashSet<TAIKHOAN>();
    }

    public string MANHANVIEN { get; set; }
    public string TENNHANVIEN { get; set; }
    public string LOAINHANVIEN { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<HOADONBH> HOADONBHs { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<TAIKHOAN> TAIKHOANs { get; set; }
}
