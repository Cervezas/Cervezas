namespace Cervezas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Surveys : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Surveys",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SiteId = c.Int(nullable: false),
                        Title = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sites", t => t.SiteId, cascadeDelete: true)
                .Index(t => t.SiteId);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Surveys", new[] { "SiteId" });
            DropForeignKey("dbo.Surveys", "SiteId", "dbo.Sites");
            DropTable("dbo.Surveys");
        }
    }
}
