namespace Cervezas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Sites : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sites",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DomainName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Sites");
        }
    }
}
