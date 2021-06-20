namespace TMSDemo.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DOJAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Priests", "DOJ", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Priests", "DOJ");
        }
    }
}
