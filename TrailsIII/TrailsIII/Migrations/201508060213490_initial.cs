namespace TrailsIII.Migrations
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
                        Id = c.Int(nullable: false, identity: true),
                        TrailStatus = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Trails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TrailNumber = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                        Time = c.DateTime(nullable: false),
                        StatusId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
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
