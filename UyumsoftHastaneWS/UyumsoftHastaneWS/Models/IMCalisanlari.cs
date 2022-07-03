namespace UyumsoftHastaneWS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IMCalisanlari")]
    public partial class IMCalisanlari
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IMCalisanlari()
        {
            HastaneYonetimis = new HashSet<HastaneYonetimi>();
        }

        [Key]
        public int IMCalisan_id { get; set; }

        public int departman_id { get; set; }

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
        public string dilBilgisi { get; set; }

        [Required]
        [StringLength(13)]
        public string telNo { get; set; }

        [StringLength(100)]
        public string mail { get; set; }

        public virtual Departmanlar Departmanlar { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HastaneYonetimi> HastaneYonetimis { get; set; }
    }
}
