namespace MyProjectV2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class contrat_Id : DbMigration
    {
        public override void Up()
        {
           
            AddColumn("dbo.tickets", "contrat_Id", c => c.Int(nullable: false));
           
        }
        
        public override void Down()
        {
            DropColumn("dbo.tickets", "contrat_Id");
           
        }
    }
}
