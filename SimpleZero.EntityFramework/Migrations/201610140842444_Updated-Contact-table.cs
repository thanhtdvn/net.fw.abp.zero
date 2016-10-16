namespace SimpleZero.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedContacttable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contacts", "ContactGroupId", c => c.Int());
            CreateIndex("dbo.Contacts", "ContactGroupId");
            AddForeignKey("dbo.Contacts", "ContactGroupId", "dbo.ContactGroups", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Contacts", "ContactGroupId", "dbo.ContactGroups");
            DropIndex("dbo.Contacts", new[] { "ContactGroupId" });
            DropColumn("dbo.Contacts", "ContactGroupId");
        }
    }
}
