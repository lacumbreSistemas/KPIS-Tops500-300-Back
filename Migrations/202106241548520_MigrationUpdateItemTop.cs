namespace ApiKPITop500.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class MigrationUpdateItemTop : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("KPI.Cbr_Items_Top500");
            AddColumn("KPI.Cbr_Items_Top500", "id", c => c.Int(nullable: false, identity: true));
            AddColumn("KPI.Cbr_Items_Top500", "StoreId", c => c.Int(nullable: false));
            AddPrimaryKey("KPI.Cbr_Items_Top500", "id");
        }

        public override void Down()
        {
            DropPrimaryKey("KPI.Cbr_Items_Top500");
            DropColumn("KPI.Cbr_Items_Top500", "StoreId");
            DropColumn("KPI.Cbr_Items_Top500", "id");
            AddPrimaryKey("KPI.Cbr_Items_Top500", "ItemId");
        }
    }
}
