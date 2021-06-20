namespace TMSDemo.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AgeAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Priests", "Age", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Priests", "Age");
        }
    }
}
