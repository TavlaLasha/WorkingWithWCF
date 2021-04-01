namespace WorkingWithWcfService.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PriceManagement.PriceChanges")]
    public partial class PriceChanx
    {
        public int Id { get; set; }

        public int ProductID { get; set; }

        public DateTime ChangedDate { get; set; }

        [Column(TypeName = "money")]
        public decimal NewPrice { get; set; }

        public virtual Product Product { get; set; }
    }
}
