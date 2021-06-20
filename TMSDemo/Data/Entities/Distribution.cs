using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;

namespace TempleManagement.Data.Entities
{
    public class Distribution
    {
        public Distribution() 
        { 
            Distribution_Details = new HashSet<Distribution_Detail>(); 
        }
        public int Id { get; set; }
        public DateTime DateOfDistribution { get; set; }

        public int PriestId { get; set; }
        public virtual Priest Priest { get; set; }
        public virtual ICollection<Distribution_Detail> Distribution_Details { get; set; }
    }   
}
