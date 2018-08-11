namespace NovaPanopticon.Web.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class SeedUserRoles : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO AspNetUserRoles (UserId, RoleId) VALUES ('85d69b77-889e-4931-9b6f-3671708382e5', 1)");
        }
        
        public override void Down()
        {
        }
    }
}
