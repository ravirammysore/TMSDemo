using System.Collections.Generic;

namespace TempleManagement.Data.Entities
{
    public class PrasadamType
    {
        public PrasadamType() 
        { 
            Prasadams = new HashSet<Prasadam>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        
        public virtual ICollection<Prasadam> Prasadams { get; set; }
    }
}
