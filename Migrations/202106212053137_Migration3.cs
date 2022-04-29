namespace ApiKPITop500.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class Migration3 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("KPI.Cbr_Items_Pasillos");
            AddColumn("KPI.Cbr_Items_Pasillos", "id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("KPI.Cbr_Items_Pasillos", "id");
        }

        public override void Down()
        {
            DropPrimaryKey("KPI.Cbr_Items_Pasillos");
            DropColumn("KPI.Cbr_Items_Pasillos", "id");
            AddPrimaryKey("KPI.Cbr_Items_Pasillos", "ItemId");
        }
    }
}
