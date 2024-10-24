using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MasterFloor.Models
{
    public partial class MasterFloorDbContext : DbContext
    {
        public MasterFloorDbContext()
            : base("name=MasterFloorDbContext")
        {
        }

        public virtual DbSet<DiscountPartner> DiscountPartners { get; set; }
        public virtual DbSet<HistorySale> HistorySales { get; set; }
        public virtual DbSet<MaterialType> MaterialTypes { get; set; }
        public virtual DbSet<Partner> Partners { get; set; }
        public virtual DbSet<PartnerType> PartnerTypes { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductType> ProductTypes { get; set; }
       

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DiscountPartner>()
                .HasMany(e => e.Partners)
                .WithRequired(e => e.DiscountPartner)
                .HasForeignKey(e => e.discount_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Partner>()
                .HasMany(e => e.HistorySales)
                .WithRequired(e => e.Partner)
                .HasForeignKey(e => e.partner_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PartnerType>()
                .HasMany(e => e.Partners)
                .WithRequired(e => e.PartnerType)
                .HasForeignKey(e => e.partner_type_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProductType>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.ProductType)
                .HasForeignKey(e => e.type_product_id)
                .WillCascadeOnDelete(false);
        }
    }
}
