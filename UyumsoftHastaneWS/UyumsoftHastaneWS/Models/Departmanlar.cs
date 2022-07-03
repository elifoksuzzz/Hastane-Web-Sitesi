namespace UyumsoftHastaneWS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Departmanlar")]
    public partial class Departmanlar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Departmanlar()
        {
            IMCalisanlaris = new HashSet<IMCalisanlari>();
        }

        [Key]
        public int departman_id { get; set; }

        [Required]
        [StringLength(100)]
        public string adi { get; set; }

        [StringLength(1000)]
        public string gorevi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IMCalisanlari> IMCalisanlaris { get; set; }
    }
}
