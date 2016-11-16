using AuctionNet.Models;

namespace AuctionNet
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Products
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Products()
        {
            Auctions = new HashSet<Auctions>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string ProductName { get; set; }

        [Required]
        [StringLength(200)]
        public string Description { get; set; }

        public decimal StartPrice { get; set; }

        public decimal Commission { get; set; }

        public int SupplierId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Auctions> Auctions { get; set; }

        public virtual Suppliers Suppliers { get; set; }
    }
}
