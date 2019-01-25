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
    }
}
