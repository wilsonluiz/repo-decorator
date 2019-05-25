using System;
using System.Collections.Generic;
using System.Text;

namespace RepoDecorator.Home.Dominio
{
    public abstract class RepositorioBaseDecorator<T> : IRepositorio<T> 
        where T : EntidadeBase
    {
        protected readonly IRepositorio<T> RepoBase;

        protected RepositorioBaseDecorator(IRepositorio<T> repoBase)
        {
            RepoBase = repoBase;
        }

        public virtual void Atualizar(T entidade)
        {
            RepoBase.Atualizar(entidade);
        }

        public virtual IEnumerable<T> ListarTodos()
        {
            return RepoBase.ListarTodos();
        }

        public virtual T ObterPorId(Guid id)
        {
            return RepoBase.ObterPorId(id);
        }

        public virtual void Remover(T entidade)
        {
            RepoBase.Remover(entidade);
        }

        public virtual T Salvar(T entidade)
        {
            return RepoBase.Salvar(entidade);
        }
    }
}
