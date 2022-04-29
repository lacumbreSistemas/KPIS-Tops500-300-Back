using System.Data.Entity;

namespace ApiKPITop500
{
    public partial class ModelItem : DbContext
    {
        public ModelItem()
            : base("name=ModelItem")
        {
        }

        public virtual DbSet<Item> Item { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>()
                .Property(e => e.BuydownPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Item>()
                .Property(e => e.CommissionAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Item>()
                .Property(e => e.CommissionMaximum)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Item>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Item>()
                .Property(e => e.PriceA)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Item>()
                .Property(e => e.PriceB)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Item>()
                .Property(e => e.PriceC)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Item>()
                .Property(e => e.SalePrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Item>()
                .Property(e => e.Cost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Item>()
                .Property(e => e.PriceLowerBound)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Item>()
                .Property(e => e.PriceUpperBound)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Item>()
                .Property(e => e.DBTimeStamp)
                .IsFixedLength();

            modelBuilder.Entity<Item>()
                .Property(e => e.LastCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Item>()
                .Property(e => e.ReplacementCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Item>()
                .Property(e => e.MSRP)
                .HasPrecision(19, 4);
        }
    }
}
