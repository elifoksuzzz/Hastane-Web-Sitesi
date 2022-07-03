namespace UyumsoftHastaneWS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ISBasvurulari")]
    public partial class ISBasvurulari
    {
        [Key]
        public int basvuru_id { get; set; }

        [Required]
        [StringLength(300)]
        public string cv { get; set; }
    }
}
