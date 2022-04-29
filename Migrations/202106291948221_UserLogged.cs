namespace ApiKPITop500.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class UserLogged : DbMigration
    {
        public override void Up()
        {
            AddColumn("KPI.Cbr_UsersKPI", "IsLogged", c => c.Boolean(nullable: false));
        }

        public override void Down()
        {
            DropColumn("KPI.Cbr_UsersKPI", "IsLogged");
        }
    }
}
