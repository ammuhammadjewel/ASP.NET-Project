namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserAcademicInfoes",
                c => new
                    {
                        RId = c.Int(nullable: false, identity: true),
                        JSC = c.String(nullable: false),
                        JSC_reg = c.String(nullable: false),
                        SSC = c.String(nullable: false),
                        SSC_reg = c.String(nullable: false),
                        HSC = c.String(nullable: false),
                        HSC_reg = c.String(nullable: false),
                        NID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RId)
                .ForeignKey("dbo.UserDetails", t => t.NID, cascadeDelete: true)
                .Index(t => t.NID);
            
            CreateTable(
                "dbo.UserDetails",
                c => new
                    {
                        NId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Fathers_Name = c.String(nullable: false),
                        Mothers_Name = c.String(nullable: false),
                        Nationality = c.String(nullable: false),
                        Religion = c.String(nullable: false),
                        Gender = c.String(nullable: false),
                        Status = c.String(nullable: false),
                        address = c.String(),
                        Uid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.NId)
                .ForeignKey("dbo.Users", t => t.Uid, cascadeDelete: true)
                .Index(t => t.Uid);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        username = c.String(nullable: false),
                        password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.JobApplies",
                c => new
                    {
                        JId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Date = c.DateTime(nullable: false),
                        NID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.JId)
                .ForeignKey("dbo.UserDetails", t => t.NID, cascadeDelete: true)
                .Index(t => t.NID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.JobApplies", "NID", "dbo.UserDetails");
            DropForeignKey("dbo.UserAcademicInfoes", "NID", "dbo.UserDetails");
            DropForeignKey("dbo.UserDetails", "Uid", "dbo.Users");
            DropIndex("dbo.JobApplies", new[] { "NID" });
            DropIndex("dbo.UserDetails", new[] { "Uid" });
            DropIndex("dbo.UserAcademicInfoes", new[] { "NID" });
            DropTable("dbo.JobApplies");
            DropTable("dbo.Users");
            DropTable("dbo.UserDetails");
            DropTable("dbo.UserAcademicInfoes");
        }
    }
}
