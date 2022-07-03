namespace UyumsoftHastaneWS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sonuclar")]
    public partial class Sonuclar
    {
        [Key]
        public int sonuc_id { get; set; }

        public int kullanicilar_id { get; set; }

        [StringLength(300)]
        public string sonuc { get; set; }

        public virtual Kullanicilar Kullanicilar { get; set; }
    }
}
