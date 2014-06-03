namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GraphEntrys",
                c => new
                    {
                        RecordId = c.Int(nullable: false, identity: true),
                        Tag = c.String(maxLength: 4000),
                        Value = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RecordId);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        RecordId = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 4000),
                        Role = c.String(maxLength: 4000),
                        Age = c.Int(nullable: false),
                        ContactPic = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.RecordId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.People");
            DropTable("dbo.GraphEntrys");
        }
    }
}
