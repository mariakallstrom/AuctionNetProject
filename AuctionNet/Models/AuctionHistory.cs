namespace AuctionNet
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AuctionHistory")]
    public partial class AuctionHistory
    {
        public int Id { get; set; }

        public int AuctionNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string ProductName { get; set; }

        [Required]
        [StringLength(50)]
        public string SuplierName { get; set; }

        [Required]
        [StringLength(50)]
        public string CustomerName { get; set; }

        public decimal StartPrice { get; set; }

        public decimal EndPrice { get; set; }
    }
}
