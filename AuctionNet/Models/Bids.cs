namespace AuctionNet
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Bids
    {
        public int Id { get; set; }

        public int? CustomerId { get; set; }

        public int? AuctionId { get; set; }

        public decimal Bid { get; set; }

        public DateTime Date { get; set; }

        public virtual Auctions Auctions { get; set; }

        public virtual Customers Customers { get; set; }
    }
}
