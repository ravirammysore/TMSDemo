namespace TMSDemo.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NOCAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Priests", "NOC", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Priests", "NOC");
        }
    }
}
