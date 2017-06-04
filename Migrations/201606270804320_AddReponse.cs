namespace MyProjectV2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddReponse : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tickets", "reponse", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.tickets", "reponse");
        }
    }
}
