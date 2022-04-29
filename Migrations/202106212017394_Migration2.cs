namespace ApiKPITop500.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class Migration2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("KPI.Cbr_Items_Pasillos", "Tienda", c => c.Int(nullable: false));
        }

        public override void Down()
        {
            DropColumn("KPI.Cbr_Items_Pasillos", "Tienda");
        }
    }
}
