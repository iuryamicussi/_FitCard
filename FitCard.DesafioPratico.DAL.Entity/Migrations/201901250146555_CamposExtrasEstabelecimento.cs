namespace FitCard.DesafioPratico.DAL.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CamposExtrasEstabelecimento : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EST_ESTABELECIMENTOS", "EST_ENDERECO", c => c.String(maxLength: 100));
            AddColumn("dbo.EST_ESTABELECIMENTOS", "EST_CIDADE", c => c.String(maxLength: 100));
            AddColumn("dbo.EST_ESTABELECIMENTOS", "EST_ESTADO", c => c.String(maxLength: 50));
            AddColumn("dbo.EST_ESTABELECIMENTOS", "EST_DATACADASTRO", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.EST_ESTABELECIMENTOS", "EST_DATACADASTRO");
            DropColumn("dbo.EST_ESTABELECIMENTOS", "EST_ESTADO");
            DropColumn("dbo.EST_ESTABELECIMENTOS", "EST_CIDADE");
            DropColumn("dbo.EST_ESTABELECIMENTOS", "EST_ENDERECO");
        }
    }
}
