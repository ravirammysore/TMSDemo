namespace TMSDemo.Reverse
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Address
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PriestId { get; set; }

        public string LineOne { get; set; }

        public virtual Priest Priest { get; set; }
    }
}
