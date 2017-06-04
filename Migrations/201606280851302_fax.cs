namespace MyProjectV2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fax : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tickets", "fax", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.tickets", "fax");
        }
    }
}
