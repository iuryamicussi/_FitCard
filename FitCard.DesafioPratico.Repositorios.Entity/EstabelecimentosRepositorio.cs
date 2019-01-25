using FitCard.DesafioPratico.DAL.Entity.Context;
using FitCard.DesafioPratico.Dominio;
using FitCard.Repositorios.Comum.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitCard.DesafioPratico.Repositorios.Entity
{
    public class EstabelecimentosRepositorio : RepositorioGenericoEntity<Estabelecimento,int>
    {
        public EstabelecimentosRepositorio(DesafioPraticoDbContext contexto) :
            base(contexto)
        {
            
        }

        public override void Inserir(Estabelecimento entidade)
        {
            Validar(entidade);
            base.Inserir(entidade);
        }

        public override void Alterar(Estabelecimento entidade)
        {
            Validar(entidade);
            base.Alterar(entidade);
        }

        private void Validar(Estabelecimento entidade)
        {
            if (entidade.Categoria == Categoria.Supermercado && string.IsNullOrEmpty(entidade.Telefone))
                throw new CustomValidationException(nameof(entidade.Telefone),"O Telefone é obrigatório para Estabelecimentos da categoria 'Supermercado'");
        }
    }
}
