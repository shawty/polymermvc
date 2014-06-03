namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBlogUrl : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "BlogPage", c => c.String(maxLength: 4000));
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "BlogPage");
        }
    }
}
