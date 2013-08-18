namespace Cervezas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Questions : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SurveyId = c.Int(nullable: false),
                        DisplayOrder = c.Int(nullable: false),
                        Text = c.String(nullable: false, maxLength: 1024),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Surveys", t => t.SurveyId, cascadeDelete: true)
                .Index(t => t.SurveyId);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Questions", new[] { "SurveyId" });
            DropForeignKey("dbo.Questions", "SurveyId", "dbo.Surveys");
            DropTable("dbo.Questions");
        }
    }
}
