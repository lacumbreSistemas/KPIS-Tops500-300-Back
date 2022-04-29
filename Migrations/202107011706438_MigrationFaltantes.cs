namespace ApiKPITop500.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class MigrationFaltantes : DbMigration
    {
        public override void Up()
        {
            AddColumn("KPI.Cbr_Faltantes_Top500", "StoreId", c => c.Int(nullable: false));
            AddColumn("KPI.Cbr_Faltantes_Top500", "Top500", c => c.Boolean());
            AddColumn("KPI.Cbr_Faltantes_Top500", "Top300", c => c.Boolean());
        }

        public override void Down()
        {
            DropColumn("KPI.Cbr_Faltantes_Top500", "Top300");
            DropColumn("KPI.Cbr_Faltantes_Top500", "Top500");
            DropColumn("KPI.Cbr_Faltantes_Top500", "StoreId");
        }
    }
}
