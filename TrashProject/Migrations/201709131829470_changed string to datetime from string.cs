namespace TrashProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedstringtodatetimefromstring : DbMigration
    {
        public override void Up()
        {
            //AlterColumn("dbo.Addresses", "DateForPickup", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Addresses", "DateForPickup", c => c.String());
        }
    }
}
