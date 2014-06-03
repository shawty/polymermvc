namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMoreFieldsToPersonEntity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "TwitterHandle", c => c.String(maxLength: 4000));
            AddColumn("dbo.People", "Department", c => c.String(maxLength: 4000));
            AddColumn("dbo.People", "EMail", c => c.String(maxLength: 4000));
            AddColumn("dbo.People", "Telephone", c => c.String(maxLength: 4000));
            AddColumn("dbo.People", "Notes", c => c.String(maxLength: 4000));
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "Notes");
            DropColumn("dbo.People", "Telephone");
            DropColumn("dbo.People", "EMail");
            DropColumn("dbo.People", "Department");
            DropColumn("dbo.People", "TwitterHandle");
        }
    }
}
