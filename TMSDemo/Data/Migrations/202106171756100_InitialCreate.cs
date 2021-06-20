namespace TMSDemo.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        PriestId = c.Int(nullable: false),
                        LineOne = c.String(),
                    })
                .PrimaryKey(t => t.PriestId)
                .ForeignKey("dbo.Priests", t => t.PriestId)
                .Index(t => t.PriestId);
            
            CreateTable(
                "dbo.Priests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 30),
                        LockerNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.LockerNumber, unique: true);
            
            CreateTable(
                "dbo.Distributions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateOfDistribution = c.DateTime(nullable: false),
                        PriestId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Priests", t => t.PriestId, cascadeDelete: true)
                .Index(t => t.PriestId);
            
            CreateTable(
                "dbo.Distribution_Detail",
                c => new
                    {
                        DistributionId = c.Int(nullable: false),
                        PrasadamId = c.Int(nullable: false),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.DistributionId, t.PrasadamId })
                .ForeignKey("dbo.Distributions", t => t.DistributionId, cascadeDelete: true)
                .ForeignKey("dbo.Prasadams", t => t.PrasadamId, cascadeDelete: true)
                .Index(t => t.DistributionId)
                .Index(t => t.PrasadamId);
            
            CreateTable(
                "dbo.Prasadams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PrasadamTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PrasadamTypes", t => t.PrasadamTypeId)
                .Index(t => t.PrasadamTypeId);
            
            CreateTable(
                "dbo.PrasadamTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Responsibilities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Vehicles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Number = c.String(),
                        Brand = c.String(),
                        Color = c.String(),
                        IsInsured = c.Boolean(nullable: false),
                        InsuranceValidity = c.DateTime(),
                        PriestId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Priests", t => t.PriestId, cascadeDelete: true)
                .Index(t => t.PriestId);
            
            CreateTable(
                "dbo.ResponsibilityPriests",
                c => new
                    {
                        Responsibility_Id = c.Int(nullable: false),
                        Priest_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Responsibility_Id, t.Priest_Id })
                .ForeignKey("dbo.Responsibilities", t => t.Responsibility_Id, cascadeDelete: true)
                .ForeignKey("dbo.Priests", t => t.Priest_Id, cascadeDelete: true)
                .Index(t => t.Responsibility_Id)
                .Index(t => t.Priest_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vehicles", "PriestId", "dbo.Priests");
            DropForeignKey("dbo.ResponsibilityPriests", "Priest_Id", "dbo.Priests");
            DropForeignKey("dbo.ResponsibilityPriests", "Responsibility_Id", "dbo.Responsibilities");
            DropForeignKey("dbo.Distributions", "PriestId", "dbo.Priests");
            DropForeignKey("dbo.Prasadams", "PrasadamTypeId", "dbo.PrasadamTypes");
            DropForeignKey("dbo.Distribution_Detail", "PrasadamId", "dbo.Prasadams");
            DropForeignKey("dbo.Distribution_Detail", "DistributionId", "dbo.Distributions");
            DropForeignKey("dbo.Addresses", "PriestId", "dbo.Priests");
            DropIndex("dbo.ResponsibilityPriests", new[] { "Priest_Id" });
            DropIndex("dbo.ResponsibilityPriests", new[] { "Responsibility_Id" });
            DropIndex("dbo.Vehicles", new[] { "PriestId" });
            DropIndex("dbo.Prasadams", new[] { "PrasadamTypeId" });
            DropIndex("dbo.Distribution_Detail", new[] { "PrasadamId" });
            DropIndex("dbo.Distribution_Detail", new[] { "DistributionId" });
            DropIndex("dbo.Distributions", new[] { "PriestId" });
            DropIndex("dbo.Priests", new[] { "LockerNumber" });
            DropIndex("dbo.Addresses", new[] { "PriestId" });
            DropTable("dbo.ResponsibilityPriests");
            DropTable("dbo.Vehicles");
            DropTable("dbo.Responsibilities");
            DropTable("dbo.PrasadamTypes");
            DropTable("dbo.Prasadams");
            DropTable("dbo.Distribution_Detail");
            DropTable("dbo.Distributions");
            DropTable("dbo.Priests");
            DropTable("dbo.Addresses");
        }
    }
}
