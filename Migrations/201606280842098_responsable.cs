namespace MyProjectV2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class responsable : DbMigration
    {
        public override void Up()
        {
           
            AddColumn("dbo.tickets", "responsable", c => c.String());
            
        }
        
        public override void Down()
        {
           
            DropColumn("dbo.tickets", "responsable");
           
        }
    }
}
