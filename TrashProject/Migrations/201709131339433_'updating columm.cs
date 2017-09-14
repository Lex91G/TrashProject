namespace TrashProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatingcolumm : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.Addresses", "HowManyPickUps", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Addresses", "HowManyPickUps");
        }
    }
}
