namespace VetPetModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Programari")]
    public partial class Programari
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProgramareId { get; set; }

        public int? MedicId { get; set; }

        public int? ProgramId { get; set; }

        public virtual Medici Medici { get; set; }

        public virtual Program Program { get; set; }
    }
}
