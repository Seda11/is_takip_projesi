//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace is_takip_proje.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_Cagri
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_Cagri()
        {
            this.Tbl_CagriDetay = new HashSet<Tbl_CagriDetay>();
        }
    
        public int ID { get; set; }
        public Nullable<int> CagriFirma { get; set; }
        public string Konu { get; set; }
        public string Aciklama { get; set; }
        public Nullable<bool> Durum { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
        public Nullable<int> CagriPersonel { get; set; }
    
        public virtual Tbl_Firmalar Tbl_Firmalar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_CagriDetay> Tbl_CagriDetay { get; set; }
        public virtual Tbl_Personel Tbl_Personel { get; set; }
    }
}
