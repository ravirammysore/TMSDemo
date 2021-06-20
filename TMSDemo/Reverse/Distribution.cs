namespace TMSDemo.Reverse
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Distribution
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Distribution()
        {
            Distribution_Detail = new HashSet<Distribution_Detail>();
        }

        public int Id { get; set; }

        public DateTime DateOfDistribution { get; set; }

        public int PriestId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Distribution_Detail> Distribution_Detail { get; set; }

        public virtual Priest Priest { get; set; }
    }
}
