namespace AuctionNet
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MaxBid")]
    public partial class MaxBid
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string ProductName { get; set; }

        [Column("MaxBid")]
        public decimal? MaxBid1 { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime EndTime { get; set; }
    }
}
