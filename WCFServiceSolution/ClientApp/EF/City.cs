namespace ClientApp.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("City")]
    public partial class City
    {
        [Key]
        public int City_Id { get; set; }

        [StringLength(50)]
        public string City_Name { get; set; }

        public int? Country_Id { get; set; }

        public virtual Country Country { get; set; }
    }
}
