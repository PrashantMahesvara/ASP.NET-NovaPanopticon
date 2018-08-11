namespace NovaPanopticon.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPersonClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        MiddleName = c.String(),
                        LastName = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        SocialSecurityNumber = c.String(),
                        StreetAddress = c.String(),
                        StreetNumber = c.String(),
                        ApartmentNumber = c.String(),
                        PostalCode = c.String(),
                        City = c.String(),
                        County = c.String(),
                        Municipal = c.String(),
                        Email = c.String(),
                        PhoneNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.People");
        }
    }
}
