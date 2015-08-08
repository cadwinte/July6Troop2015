namespace TrailProjectIV.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        StatusId = c.Int(nullable: false, identity: true),
                        TrailStatus = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.StatusId);
            
            CreateTable(
                "dbo.Trails",
                c => new
                    {
                        TrailId = c.Int(nullable: false, identity: true),
                        TrailNumber = c.Int(nullable: false),
                        TrailName = c.String(),
                        TrailStatusUpdated = c.DateTime(nullable: false),
                        StatusId = c.Int(nullable: false),
                        CreatedUserId = c.String(),
                        UpdatedUserId = c.String(),
                        DateUpdated = c.DateTime(nullable: false),
                        TimeUpdated = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.TrailId)
                .ForeignKey("dbo.Status", t => t.StatusId, cascadeDelete: true)
                .Index(t => t.StatusId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Trails", "StatusId", "dbo.Status");
            DropIndex("dbo.Trails", new[] { "StatusId" });
            DropTable("dbo.Trails");
            DropTable("dbo.Status");
        }
    }
}
