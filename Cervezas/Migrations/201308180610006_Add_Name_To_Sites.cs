namespace Cervezas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Name_To_Sites : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Sites", "Name", c => c.String(nullable: false, maxLength: 256));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Sites", "Name");
        }
    }
}
