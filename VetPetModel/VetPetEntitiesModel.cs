using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace VetPetModel
{
    public partial class VetPetEntitiesModel : DbContext
    {
        public VetPetEntitiesModel()
            : base("name=VetPetEntitiesModel")
        {
        }

        public virtual DbSet<Medici> Medicis { get; set; }
        public virtual DbSet<Program> Programs { get; set; }
        public virtual DbSet<Programari> Programaris { get; set; }
        public virtual DbSet<Tratamente> Tratamentes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Medici>()
                .Property(e => e.Nume)
                .IsUnicode(false);

            modelBuilder.Entity<Medici>()
                .Property(e => e.Prenume)
                .IsUnicode(false);

            modelBuilder.Entity<Medici>()
                .HasMany(e => e.Programaris)
                .WithOptional(e => e.Medici)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Program>()
                .Property(e => e.Ora_deschidere)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Program>()
                .Property(e => e.Ora_inchidere)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Program>()
                .HasMany(e => e.Programaris)
                .WithOptional(e => e.Program)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Tratamente>()
                .Property(e => e.Pret)
                .HasPrecision(18, 0);
        }
    }
}
