namespace TrashProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAddressTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        HomeAddress = c.String(),
                        City = c.String(),
                        State = c.String(),
                        ZipCode = c.String(),
                        DateForPickup = c.String(),
                       
                })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Addresses");
        }
    }
}
