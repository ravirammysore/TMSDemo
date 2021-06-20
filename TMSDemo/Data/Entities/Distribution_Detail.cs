using System.Data.Entity.ModelConfiguration;

namespace TempleManagement.Data.Entities
{
    public class Distribution_Detail
    {
        public int DistributionId { get; set; }
        public int PrasadamId { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        
        public virtual Distribution Distribution { get; set; }
        public virtual Prasadam Prasadam { get; set; }
    }

    public class Distribution_Detail_Config: EntityTypeConfiguration<Distribution_Detail>
    {
        public Distribution_Detail_Config()
        {
            HasKey(e => new { e.DistributionId, e.PrasadamId });
        }
    }

}
