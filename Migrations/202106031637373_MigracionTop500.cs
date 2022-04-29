namespace ApiKPITop500.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class MigracionTop500 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "KPI.Cbr_Faltantes_Top500",
                c => new
                {
                    id = c.Int(nullable: false, identity: true),
                    ItemId = c.Int(nullable: false),
                    disponible = c.Boolean(),
                    Fecha = c.DateTime(),
                    userID = c.Int(),
                })
                .PrimaryKey(t => t.id);

            CreateTable(
                "KPI.Cbr_Item_Top500_Pasillo",
                c => new
                {
                    id = c.Int(nullable: false, identity: true),
                    Pasillo = c.String(maxLength: 50, unicode: false),
                })
                .PrimaryKey(t => t.id);

            CreateTable(
                "KPI.Cbr_Items_Pasillos",
                c => new
                {
                    ItemId = c.Int(nullable: false),
                    PasilloId = c.Int(),
                })
                .PrimaryKey(t => t.ItemId);

            CreateTable(
                "KPI.Cbr_Items_Top500",
                c => new
                {
                    ItemId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.ItemId);

            CreateTable(
                "KPI.Cbr_UsersKPI",
                c => new
                {
                    userID = c.Int(nullable: false, identity: true),
                    NombreCompleto = c.String(maxLength: 50, unicode: false),
                    Rol = c.String(maxLength: 20, unicode: false),
                })
                .PrimaryKey(t => t.userID);


        }

        public override void Down()
        {
            DropTable("dbo.Item");
            DropTable("KPI.Cbr_UsersKPI");
            DropTable("KPI.Cbr_Items_Top500");
            DropTable("KPI.Cbr_Items_Pasillos");
            DropTable("KPI.Cbr_Item_Top500_Pasillo");
            DropTable("KPI.Cbr_Faltantes_Top500");
        }
    }
}
