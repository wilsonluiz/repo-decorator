using System;
using System.Collections.Generic;
using System.Diagnostics;
using RepoDecorator.Home.Dominio;

namespace RepoDecorator.Home.Infraestrutura
{
    public class RepositorioBase<T> : IRepositorio<T> 
        where T : EntidadeBase
    {
        public void Atualizar(T entidade)
        {
            Debug.Write($"Atualizando entidade '{typeof(T).Name}' na base de dados{Environment.NewLine}");
        }

        public IEnumerable<T> ListarTodos()
        {
            Debug.Write($"Listando todas as entidade '{typeof(T).Name}'{Environment.NewLine}");
            return new List<T>();
        }

        public T ObterPorId(Guid id)
        {
            Debug.Write($"Obtendo entidade '{typeof(T).Name}' na base de dados #{id}{Environment.NewLine}");
            return null;
        }

        public void Remover(T entidade)
        {
            Debug.Write($"Excluindo entidade '{typeof(T).Name}' da base de dados{Environment.NewLine}");
        }

        public T Salvar(T entidade)
        {
            Debug.Write($"Persistindo entidade '{typeof(T).Name}' na base de dados{Environment.NewLine}");
            return null;
        }
    }
}
