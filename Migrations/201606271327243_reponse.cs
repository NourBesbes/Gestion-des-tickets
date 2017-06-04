namespace MyProjectV2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class reponse : DbMigration
    {
        public override void Up()
        {
            
            
            
            AlterColumn("dbo.tickets", "delai", c => c.String());
            AlterColumn("dbo.tickets", "tel", c => c.String());
            
            AlterColumn("dbo.employes", "tel", c => c.String());
           
        }
        
        public override void Down()
        {
           
            AlterColumn("dbo.employes", "tel", c => c.Int(nullable: false));
            
            AlterColumn("dbo.tickets", "tel", c => c.Int(nullable: false));
            AlterColumn("dbo.tickets", "delai", c => c.Int(nullable: false));
            
        }
    }
}
