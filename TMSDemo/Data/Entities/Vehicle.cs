using System;
using System.Data.Entity.ModelConfiguration;

namespace TempleManagement.Data.Entities
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public bool IsInsured { get; set; }        
        public DateTime? InsuranceValidity { get; set; }

        public int PriestId { get; set; }
        public virtual Priest Priest { get; set; }
    }

    public class VehicleConfig : EntityTypeConfiguration<Vehicle>
    {
        public VehicleConfig()
        {          
            HasIndex(e => e.PriestId).IsUnique();
            Property(e => e.Brand).HasMaxLength(20).IsRequired();
            Property(e => e.Color).HasMaxLength(10);
        }
    }
}
