namespace TMSDemo.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DOJCanBeNull : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Priests", "DOJ", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Priests", "DOJ", c => c.DateTime(nullable: false));
        }
    }
}
