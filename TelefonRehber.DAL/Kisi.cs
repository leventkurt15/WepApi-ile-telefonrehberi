namespace TelefonRehber.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kisi")]
    public partial class Kisi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kisi()
        {
            //Telefon = new HashSet<Telefon>();
        }

        public int KisiId { get; set; }

        [StringLength(50)]
        public string KisiAdi { get; set; }

        [StringLength(50)]
        public string Soyadı { get; set; }

        [StringLength(50)]
        public string Meslegi { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Telefon> Telefon { get; set; }
    }
}
