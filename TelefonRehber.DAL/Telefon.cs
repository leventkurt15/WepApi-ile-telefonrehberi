namespace TelefonRehber.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Telefon")]
    public partial class Telefon
    {
        public int TelefonId { get; set; }

        public int? KisiId { get; set; }

        [StringLength(50)]
        public string TelefonNumarası { get; set; }

        public virtual Kisi Kisi { get; set; }
    }
}
