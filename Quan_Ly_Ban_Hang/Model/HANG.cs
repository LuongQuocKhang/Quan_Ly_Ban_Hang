//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Quan_Ly_Ban_Hang.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class HANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HANG()
        {
            this.CHITIETDONDATHANGs = new HashSet<CHITIETDONDATHANG>();
            this.CHITIETHOADONs = new HashSet<CHITIETHOADON>();
        }
    
        public string MAHANG { get; set; }
        public string TENHANG { get; set; }
        public Nullable<decimal> DONGIA { get; set; }
        public Nullable<int> SOLUONGTON { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETDONDATHANG> CHITIETDONDATHANGs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETHOADON> CHITIETHOADONs { get; set; }
    }
}
