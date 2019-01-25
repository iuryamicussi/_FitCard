using FitCard.DesafioPratico.DAL.Entity.TypeConfiguration;
using FitCard.DesafioPratico.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitCard.DesafioPratico.DAL.Entity.Context
{
    public class DesafioPraticoDbContext : DbContext
    {
        public DbSet<Estabelecimento> Estabelecimentos { get; set; }

        public DesafioPraticoDbContext()
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EstabelecimentoTypeConfiguration());
        }

    }
}
