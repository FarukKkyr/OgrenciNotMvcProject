//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OgrenciNotMvcProject.Models.EntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_Ogrenci
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_Ogrenci()
        {
            this.Tbl_Notlar = new HashSet<Tbl_Notlar>();
        }
    
        public int OgrenciID { get; set; }
        public string OgrAd { get; set; }
        public string OgrSoyad { get; set; }
        public string OgrFoto { get; set; }
        public string OgrCinsiyet { get; set; }
        public Nullable<byte> OgrKulup { get; set; }
    
        public virtual Tbl_Kulup Tbl_Kulup { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Notlar> Tbl_Notlar { get; set; }
    }
}
