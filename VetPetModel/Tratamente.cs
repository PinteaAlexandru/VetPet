namespace VetPetModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tratamente")]
    public partial class Tratamente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TratamentId { get; set; }

        [StringLength(50)]
        public string TipTratament { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Pret { get; set; }
    }
}
