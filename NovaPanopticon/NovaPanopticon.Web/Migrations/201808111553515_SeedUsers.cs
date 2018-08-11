namespace NovaPanopticon.Web.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName])
VALUES
(N'85d69b77-889e-4931-9b6f-3671708382e5', N'prashantmahesvara@gmail.com', 0, N'AMJ4ZMDaHJpyzZbgabyFv2jqzYHNuMlwD4/4r9bE8lvd6JU05kdbEQqNkfwXudN55g==', N'db309bcd-b9e6-4cb1-a82f-e6e48aed9028', NULL, 0, 0, NULL, 1, 0, N'prashantmahesvara@gmail.com')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
