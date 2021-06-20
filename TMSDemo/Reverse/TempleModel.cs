namespace TMSDemo.Reverse
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TempleModel : DbContext
    {
        public TempleModel()
            : base("name=TempleModel")
        {
        }

        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Distribution_Detail> Distribution_Detail { get; set; }
        public virtual DbSet<Distribution> Distributions { get; set; }
        public virtual DbSet<Prasadam> Prasadams { get; set; }
        public virtual DbSet<PrasadamType> PrasadamTypes { get; set; }
        public virtual DbSet<Priest> Priests { get; set; }
        public virtual DbSet<Responsibility> Responsibilities { get; set; }
        public virtual DbSet<Vehicle> Vehicles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PrasadamType>()
                .HasMany(e => e.Prasadams)
                .WithRequired(e => e.PrasadamType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Priest>()
                .HasOptional(e => e.Address)
                .WithRequired(e => e.Priest);

            modelBuilder.Entity<Priest>()
                .HasMany(e => e.Responsibilities)
                .WithMany(e => e.Priests)
                .Map(m => m.ToTable("ResponsibilityPriests"));
        }
    }
}
