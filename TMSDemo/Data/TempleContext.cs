using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using TempleManagement.Data.Entities;

namespace TMSDemo.Data
{
    public class TempleContext:DbContext
    {
        public TempleContext():base("TempleDB")
        {

        }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
            builder.Configurations.Add(new Distribution_Detail_Config());
            builder.Configurations.Add(new PriestConfig());
            builder.Configurations.Add(new AddressConfig());
            builder.Configurations.Add(new PrasadamConfig());
        }

        public virtual DbSet<Priest> Priests { get; set; }
        public virtual DbSet<Responsibility> Responsibilities { get; set; }
        public virtual DbSet<Vehicle> Vehicles { get; set; }
        public virtual DbSet<PrasadamType> PrasadamTypes { get; set; }
        public virtual DbSet<Prasadam> Prasadams { get; set; }
        public virtual DbSet<Distribution> Distributions { get; set; }
        public virtual DbSet<Distribution_Detail> Distribution_Details { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
    }
}
