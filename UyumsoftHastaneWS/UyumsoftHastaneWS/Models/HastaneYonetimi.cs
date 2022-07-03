namespace UyumsoftHastaneWS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HastaneYonetimi")]
    public partial class HastaneYonetimi
    {
        [Key]
        public int hastaneYonetim_id { get; set; }

        public int baskan { get; set; }

        public int baskanYardimcisi { get; set; }

        public int uye { get; set; }

        public virtual Hekimler Hekimler { get; set; }

        public virtual Hekimler Hekimler1 { get; set; }

        public virtual IMCalisanlari IMCalisanlari { get; set; }
    }
}
