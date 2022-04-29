namespace ApiKPITop500.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class MigrationUpdateUsers : DbMigration
    {
        public override void Up()
        {
            AddColumn("KPI.Cbr_UsersKPI", "StoreId", c => c.Int(nullable: false));
        }

        public override void Down()
        {
            DropColumn("KPI.Cbr_UsersKPI", "StoreId");
        }
    }
}
