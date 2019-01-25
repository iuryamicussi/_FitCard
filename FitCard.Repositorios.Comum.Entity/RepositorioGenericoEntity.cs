using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitCard.Repositorios.Comum.Entity
{
    public class RepositorioGenericoEntity<TEntidade, TChave> : IRepositorioGenerico<TEntidade, TChave>
        where TEntidade : class
    {
        protected DbContext _contexto;

        public RepositorioGenericoEntity(DbContext contexto)
        {
            _contexto = contexto;
        }

        public virtual void Alterar(TEntidade entidade)
        {
            _contexto.Set<TEntidade>().Attach(entidade);
            _contexto.Entry(entidade).State = EntityState.Modified;
            _contexto.SaveChanges();
        }

        public void Excluir(TEntidade entidade)
        {
            _contexto.Set<TEntidade>().Attach(entidade);
            _contexto.Entry(entidade).State = EntityState.Deleted;
            _contexto.SaveChanges();
        }

        public void ExcluirPorId(TChave id)
        {
            TEntidade entidade = SelecionarPorId(id);
            Excluir(entidade);
        }

        public virtual void Inserir(TEntidade entidade)
        {
            _contexto.Set<TEntidade>().Add(entidade);
            _contexto.SaveChanges();
        }

        public IList<TEntidade> Selecionar() => _contexto.Set<TEntidade>().ToList();

        public IList<TEntidade> Selecionar(Func<TEntidade, bool> predicate) =>
            _contexto.Set<TEntidade>().Where(predicate).ToList();

        public TEntidade SelecionarPorId(TChave id) => _contexto.Set<TEntidade>().Find(id);
    }
}
