using System.Data.Entity;

namespace ApiKPITop500
{
    public partial class KPIModel : DbContext
    {
        public KPIModel()
            : base("name=KPIModel6")
        {
        }

        public virtual DbSet<Item> Item { get; set; }
        public virtual DbSet<Cbr_Faltantes_Top500> Cbr_Faltantes_Top500 { get; set; }
        public virtual DbSet<Cbr_Item_Top500_Pasillo> Cbr_Item_Top500_Pasillo { get; set; }
        public virtual DbSet<Cbr_Items_Pasillos> Cbr_Items_Pasillos { get; set; }
        public virtual DbSet<Cbr_UsersKPI> Cbr_UsersKPI { get; set; }
        public virtual DbSet<Cbr_Items_Top500> Cbr_Items_Top500 { get; set; }

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

            modelBuilder.Entity<Cbr_Item_Top500_Pasillo>()
                .Property(e => e.Pasillo)
                .IsUnicode(false);

            modelBuilder.Entity<Cbr_UsersKPI>()
                .Property(e => e.NombreCompleto)
                .IsUnicode(false);

        }
    }
}
