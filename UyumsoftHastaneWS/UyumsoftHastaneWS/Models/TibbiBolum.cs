namespace UyumsoftHastaneWS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TibbiBolum")]
    public partial class TibbiBolum
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TibbiBolum()
        {
            Hekimlers = new HashSet<Hekimler>();
            Randevulars = new HashSet<Randevular>();
        }

        [Key]
        public int tibbiBolum_id { get; set; }

        [Required]
        [StringLength(100)]
        public string adi { get; set; }

        public string hizmetleri { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Hekimler> Hekimlers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Randevular> Randevulars { get; set; }
    }
}
