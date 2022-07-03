namespace UyumsoftHastaneWS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Randevular")]
    public partial class Randevular
    {
        [Key]
        public int randevu_id { get; set; }

        public int tibbiBolum_id { get; set; }

        public int hekim_id { get; set; }

        public int kullanicilar_id { get; set; }

        public DateTime tarih { get; set; }

        public virtual Hekimler Hekimler { get; set; }

        public virtual Kullanicilar Kullanicilar { get; set; }

        public virtual TibbiBolum TibbiBolum { get; set; }
    }
}
