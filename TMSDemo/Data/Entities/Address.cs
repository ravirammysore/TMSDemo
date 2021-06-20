using System.Data.Entity.ModelConfiguration;

namespace TempleManagement.Data.Entities
{
    public class Address
    {
        public int PriestId { get; set; }
        public string LineOne { get; set; }        
        
        public virtual Priest Priest { get; set; }
    }

    public class AddressConfig:EntityTypeConfiguration<Address>
    {
        public AddressConfig()
        {
            HasKey(e => e.PriestId);           
        }
    }
}
