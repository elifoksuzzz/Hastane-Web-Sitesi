namespace UyumsoftHastaneWS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PoliklinikYonetimi")]
    public partial class PoliklinikYonetimi
    {
        [Key]
        public int poliklinikYonetim_id { get; set; }

        public int tibbiDirektor { get; set; }

        public int tibbiDirektorYardimcisi { get; set; }

        public int tibbiDirektorAsistani { get; set; }

        public virtual Hekimler Hekimler { get; set; }

        public virtual Hekimler Hekimler1 { get; set; }

        public virtual Hekimler Hekimler2 { get; set; }
    }
}
