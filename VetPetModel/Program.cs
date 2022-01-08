namespace VetPetModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Program")]
    public partial class Program
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Program()
        {
            Programaris = new HashSet<Programari>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProgramId { get; set; }

        [StringLength(50)]
        public string Ziua { get; set; }

        [Column("Ora deschidere", TypeName = "numeric")]
        public decimal? Ora_deschidere { get; set; }

        [Column("Ora inchidere", TypeName = "numeric")]
        public decimal? Ora_inchidere { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Programari> Programaris { get; set; }
    }
}
