using System;
using System.Collections.Generic;
using System.Text;

namespace RepoDecorator.Home.Dominio
{
    public interface IRepositorio<T> where T : EntidadeBase
    {
        void Atualizar(T entidade);

        IEnumerable<T> ListarTodos();

        T ObterPorId(Guid id);

        void Remover(T entidade);

        T Salvar(T entidade);
    }
}
