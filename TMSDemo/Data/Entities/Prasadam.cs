using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;

namespace TempleManagement.Data.Entities
{
    public class Prasadam
    {
        public Prasadam()
        {
            Distribution_Details = new HashSet<Distribution_Detail>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }        
        
        public int PrasadamTypeId { get; set; }        
        public virtual PrasadamType PrasadamType { get; set; }        
        public ICollection<Distribution_Detail> Distribution_Details { get; set; }
    }

    public class PrasadamConfig : EntityTypeConfiguration<Prasadam>
    {
        public PrasadamConfig()
        {
            //This is only for showing that EF6 does a delete cascade by default, 
                //we can prevent it as below

            HasRequired(e => e.PrasadamType).WithMany(e => e.Prasadams).WillCascadeOnDelete(false);
        }
    }
}