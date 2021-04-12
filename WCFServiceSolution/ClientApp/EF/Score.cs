namespace ClientApp.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Score")]
    public partial class Score
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Song_Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Voter_Id { get; set; }

        [Column("Score")]
        public int Score1 { get; set; }

        [Column(TypeName = "date")]
        public DateTime Voted_At { get; set; }

        public virtual Song Song { get; set; }

        public virtual Voter Voter { get; set; }
    }
}
