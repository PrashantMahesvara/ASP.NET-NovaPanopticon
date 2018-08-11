namespace NovaPanopticon.Web.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class SeedRoles : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO AspNetRoles (Id, Name) VALUES (1, 'Admin') ");
            Sql("INSERT INTO AspNetRoles (Id, Name) VALUES (2, 'Unassigned') ");
        }

        public override void Down()
        {
        }
    }
}
