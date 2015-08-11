namespace Trails5.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class two : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Trails", "StatusId", "dbo.Status");
            DropIndex("dbo.Trails", new[] { "StatusId" });
            AddColumn("dbo.Trails", "Status", c => c.String());
            DropColumn("dbo.Trails", "StatusId");
            DropTable("dbo.Status");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TrailStatus = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Trails", "StatusId", c => c.Int(nullable: false));
            DropColumn("dbo.Trails", "Status");
            CreateIndex("dbo.Trails", "StatusId");
            AddForeignKey("dbo.Trails", "StatusId", "dbo.Status", "Id", cascadeDelete: true);
        }
    }
}
