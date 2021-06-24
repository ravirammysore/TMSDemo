using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using System;

namespace TempleManagement.Data.Entities
{
    public class Priest
    {
        public Priest() 
        { 
            Responsibilities = new HashSet<Responsibility>();
            Distributions = new HashSet<Distribution>();
            Vehicles = new HashSet<Vehicle>();
        }

        public int Id { get; set; }               
        public string Name { get; set; }
        public int LockerNumber { get; set; }
        public int Age { get; set; }
        public DateTime? DOJ { get; set; }
        //public int NOC { get; set; }

        public virtual ICollection<Vehicle> Vehicles { get; set; }
        public virtual ICollection<Responsibility> Responsibilities { get; set; }
        public virtual ICollection<Distribution> Distributions { get; set; }
        
        public virtual Address Address { get; set; }
    }  

    public class PriestConfig: EntityTypeConfiguration<Priest>
    {
        public PriestConfig()
        {
            Property(e => e.Name).HasMaxLength(30);
            
            HasIndex(e => e.LockerNumber).IsUnique();

            HasOptional(e => e.Address).WithRequired(e => e.Priest);
        }
    }
}