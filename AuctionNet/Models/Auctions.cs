using System;
using System.Collections.Generic;

namespace AuctionNet.Models
{
    public partial class Auctions
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Auctions()
        {
            Bids = new HashSet<Bids>();
        }

        public int Id { get; set; }

        public decimal AcceptPrice { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public int ProductId { get; set; }

        public virtual Products Products { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]


        public virtual ICollection<Bids> Bids{ get; set; }
    }
}
