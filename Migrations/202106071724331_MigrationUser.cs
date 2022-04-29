namespace ApiKPITop500.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class MigrationUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("KPI.Cbr_UsersKPI", "Password", c => c.String(maxLength: 50));
            AlterColumn("KPI.Cbr_UsersKPI", "Rol", c => c.Int(nullable: false));
        }

        public override void Down()
        {
            AlterColumn("KPI.Cbr_UsersKPI", "Rol", c => c.String(maxLength: 20, unicode: false));
            DropColumn("KPI.Cbr_UsersKPI", "Password");
        }
    }
}
