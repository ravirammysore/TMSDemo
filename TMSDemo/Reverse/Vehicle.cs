namespace TMSDemo.Reverse
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Vehicle
    {
        public int Id { get; set; }

        public string Number { get; set; }

        public string Brand { get; set; }

        public string Color { get; set; }

        public bool IsInsured { get; set; }

        public DateTime? InsuranceValidity { get; set; }

        public int PriestId { get; set; }

        public virtual Priest Priest { get; set; }
    }
}
