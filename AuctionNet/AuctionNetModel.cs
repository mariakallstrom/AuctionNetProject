using AuctionNet.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
 

namespace AuctionNet
{


    public partial class AuctionNetModel : DbContext
    {
        public AuctionNetModel()
            : base("name=AuctionNetModelDb")
        {
        }

        public virtual DbSet<AuctionHistory> AuctionHistory { get; set; }
        public virtual DbSet<Auctions> Auctions { get; set; }
        public virtual DbSet<Bids> Bids { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Suppliers> Suppliers { get; set; }
        public virtual DbSet<MaxBid> MaxBid { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuctionHistory>()
                .Property(e => e.CustomerName)
                .IsUnicode(false);

            modelBuilder.Entity<AuctionHistory>()
                .Property(e => e.StartPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<AuctionHistory>()
                .Property(e => e.EndPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Auctions>()
                .Property(e => e.AcceptPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Auctions>()
                .HasMany(e => e.Bids)
                .WithOptional(e => e.Auctions)
                .HasForeignKey(e => e.AuctionId);

            modelBuilder.Entity<Bids>()
                .Property(e => e.Bid)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Customers>()
                .HasMany(e => e.Bids)
                .WithOptional(e => e.Customers)
                .HasForeignKey(e => e.CustomerId);

            modelBuilder.Entity<Products>()
                .Property(e => e.StartPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Products>()
                .Property(e => e.Commission)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Products>()
                .HasMany(e => e.Auctions)
                .WithRequired(e => e.Products)
                .HasForeignKey(e => e.ProductId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Suppliers>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.Suppliers)
                .HasForeignKey(e => e.SupplierId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MaxBid>()
                .Property(e => e.MaxBid1)
                .HasPrecision(18, 0);
        }
    }
}
