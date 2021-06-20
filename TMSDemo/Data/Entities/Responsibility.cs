using System.Collections.Generic;

namespace TempleManagement.Data.Entities
{
    public class Responsibility
    {
        public Responsibility() 
        {
            Priests = new HashSet<Priest>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        
        public virtual ICollection<Priest> Priests { get; set; }
    }
}
