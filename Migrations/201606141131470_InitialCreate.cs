namespace MyProjectV2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.contrats",
                c => new
                    {
                        contrat_Id = c.Int(nullable: false, identity: true),
                        raison_Sociale = c.String(),
                        nom = c.String(),
                    })
                .PrimaryKey(t => t.contrat_Id);

            CreateTable(
                "dbo.tickets",
                c => new
                    {
                        tick_Id = c.Int(nullable: false, identity: true),
                        mail = c.String(),
                        delai = c.Int(nullable: false),
                        date_deb = c.String(),
                        date_fin = c.String(),
                        nom = c.String(),
                        prenom = c.String(),
                        raison_Sociale = c.String(),
                        reclamation = c.String(),
                        tel = c.Int(nullable: false),
                        type_Intervention = c.String(),
                        empl_Id = c.Int(nullable: false),
                        contrat_Id = c.String(),
                        // contrat_contrat_Id = c.Int(),
                    })
                .PrimaryKey(t => t.tick_Id)
                // .ForeignKey("dbo.contrats", t => t.contrat_contrat_Id)
                .ForeignKey("dbo.employes", t => t.empl_Id, cascadeDelete: true)
                .Index(t => t.empl_Id);
              //  .Index(t => t.contrat_contrat_Id);
            
            CreateTable(
                "dbo.employes",
                c => new
                    {
                        empl_Id = c.Int(nullable: false, identity: true),
                        login = c.String(),
                        password = c.String(),
                        nom = c.String(),
                        prenom = c.String(),
                        mail = c.String(),
                        tel = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.empl_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tickets", "empl_Id", "dbo.employes");
          //  DropForeignKey("dbo.tickets", "contrat_contrat_Id", "dbo.contrats");
          //  DropIndex("dbo.tickets", new[] { "contrat_contrat_Id" });
            DropIndex("dbo.tickets", new[] { "empl_Id" });
            DropTable("dbo.employes");
            DropTable("dbo.tickets");
            DropTable("dbo.contrats");
        }
    }
}
