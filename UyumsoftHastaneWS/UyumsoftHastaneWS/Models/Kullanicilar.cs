namespace UyumsoftHastaneWS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kullanicilar")]
    public partial class Kullanicilar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kullanicilar()
        {
            Sonuclars = new HashSet<Sonuclar>();
            Randevulars = new HashSet<Randevular>();
        }

        [Key]
        public int kullanicilar_id { get; set; }

        [Required]
        [StringLength(100)]
        public string adi { get; set; }

        [Required]
        [StringLength(100)]
        public string soyadi { get; set; }

        [Required]
        [StringLength(11)]
        public string kimlikNumarasi { get; set; }

        [Required]
        [StringLength(100)]
        public string dogumYili { get; set; }

        [StringLength(13)]
        public string telNo { get; set; }

        [StringLength(100)]
        public string hastalik { get; set; }

        [StringLength(50)]
        public string kullaniciAdi { get; set; }

        [StringLength(50)]
        public string parola { get; set; }

        [StringLength(3)]
        public string rol { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sonuclar> Sonuclars { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Randevular> Randevulars { get; set; }
    }
}
