using FitCard.Comum.Entity;
using FitCard.DesafioPratico.Dominio;
using System;

namespace FitCard.DesafioPratico.DAL.Entity.TypeConfiguration
{
    public class EstabelecimentoTypeConfiguration : FitCardEntityAbstractConfig<Estabelecimento>
    {
        protected override void ConfigurarCamposTabela()
        {
            Property(p => p.Id)
                .IsRequired()
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)
                .HasColumnName("EST_ID");

            Property(p => p.RazaoSocial)
                .IsRequired()
                .HasColumnName("EST_RAZAOSOCIAL")
                .HasMaxLength(100);

            Property(p => p.NomeFantasia)
                .IsOptional()
                .HasColumnName("EST_NOMEFANTASIA")
                .HasMaxLength(100);

            Property(p => p.CNPJ)
                .IsRequired()
                .HasColumnName("EST_CNPJ")
                .HasMaxLength(18);

            Property(p => p.Email)
                .IsOptional()
                .HasColumnName("EST_EMAIL")
                .HasMaxLength(100);

            Property(p => p.Endereco)
                .IsOptional()
                .HasColumnName("EST_ENDERECO")
                .HasMaxLength(100);

            Property(p => p.Cidade)
                .IsOptional()
                .HasColumnName("EST_CIDADE")
                .HasMaxLength(100);

            Property(p => p.Estado)
                .IsOptional()
                .HasColumnName("EST_ESTADO")
                .HasMaxLength(50);

            Property(p => p.Telefone)
                .IsOptional()
                .HasColumnName("EST_TELEFONE")
                .HasMaxLength(100);

            Property(p => p.DataCadastro)
                .IsOptional()
                .HasColumnName("EST_DATACADASTRO");

            Property(p => p.Categoria)
                .IsOptional()
                .HasColumnName("EST_CATEGORIA");

            Property(p => p.Status)
                .IsOptional()
                .HasColumnName("EST_STATUS");

            Property(p => p.Agencia)
                .IsOptional()
                .HasColumnName("EST_AGENCIA")
                .HasMaxLength(5);

            Property(p => p.Conta)
                .IsOptional()
                .HasColumnName("EST_CONTA")
                .HasMaxLength(8);
        }

        protected override void ConfigurarChavePrimaria()
        {
            HasKey(pk => pk.Id);
        }

        protected override void ConfigurarChavesEstrangeiras()
        {
            //Sem FKs
        }

        protected override void ConfigurarNomeTabela()
        {
            ToTable("EST_ESTABELECIMENTOS");
        }
    }
}
