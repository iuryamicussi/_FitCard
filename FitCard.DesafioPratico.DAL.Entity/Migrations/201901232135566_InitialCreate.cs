namespace FitCard.DesafioPratico.DAL.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EST_ESTABELECIMENTOS",
                c => new
                    {
                        EST_ID = c.Int(nullable: false, identity: true),
                        EST_RAZAOSOCIAL = c.String(nullable: false, maxLength: 100),
                        EST_NOMEFANTASIA = c.String(maxLength: 100),
                        EST_CNPJ = c.String(nullable: false, maxLength: 18),
                        EST_EMAIL = c.String(maxLength: 100),
                        EST_TELEFONE = c.String(maxLength: 100),
                        EST_CATEGORIA = c.Int(),
                        EST_STATUS = c.Int(),
                        EST_AGENCIA = c.String(maxLength: 5),
                        EST_CONTA = c.String(maxLength: 8),
                    })
                .PrimaryKey(t => t.EST_ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.EST_ESTABELECIMENTOS");
        }
    }
}
