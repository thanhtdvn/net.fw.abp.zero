namespace SimpleZero.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedContactgrouptable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ContactGroups", "IsActive", c => c.Boolean(nullable: false));
            AlterColumn("dbo.ContactGroups", "Name", c => c.String(nullable: false, maxLength: 256));
            DropColumn("dbo.ContactGroups", "Status");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ContactGroups", "Status", c => c.String());
            AlterColumn("dbo.ContactGroups", "Name", c => c.String(nullable: false));
            DropColumn("dbo.ContactGroups", "IsActive");
        }
    }
}
