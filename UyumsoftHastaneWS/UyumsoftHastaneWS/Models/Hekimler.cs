namespace UyumsoftHastaneWS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Hekimler")]
    public partial class Hekimler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Hekimler()
        {
            HastaneYonetimis = new HashSet<HastaneYonetimi>();
            HastaneYonetimis1 = new HashSet<HastaneYonetimi>();
            PoliklinikYonetimis = new HashSet<PoliklinikYonetimi>();
            PoliklinikYonetimis1 = new HashSet<PoliklinikYonetimi>();
            Randevulars = new HashSet<Randevular>();
            PoliklinikYonetimis2 = new HashSet<PoliklinikYonetimi>();
        }

        [Key]
        public int hekim_id { get; set; }

        public int tibbiBolum_id { get; set; }

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
        public string akademikUnvani { get; set; }

        [StringLength(100)]
        public string dilBilgisi { get; set; }

        [StringLength(13)]
        public string telNo { get; set; }

        [Required]
        [StringLength(100)]
        public string mail { get; set; }

        [StringLength(100)]
        public string egitimBilgileri { get; set; }

        public string imagePath { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HastaneYonetimi> HastaneYonetimis { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HastaneYonetimi> HastaneYonetimis1 { get; set; }

        public virtual TibbiBolum TibbiBolum { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PoliklinikYonetimi> PoliklinikYonetimis { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PoliklinikYonetimi> PoliklinikYonetimis1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Randevular> Randevulars { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PoliklinikYonetimi> PoliklinikYonetimis2 { get; set; }
    }
}
