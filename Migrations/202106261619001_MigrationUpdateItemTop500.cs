namespace ApiKPITop500.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class MigrationUpdateItemTop500 : DbMigration
    {
        public override void Up()
        {
            AddColumn("KPI.Cbr_Items_Top500", "Top500", c => c.Boolean(nullable: false));
            AddColumn("KPI.Cbr_Items_Top500", "Top300", c => c.Boolean(nullable: false));
        }

        public override void Down()
        {
            DropColumn("KPI.Cbr_Items_Top500", "Top300");
            DropColumn("KPI.Cbr_Items_Top500", "Top500");
        }
    }
}
