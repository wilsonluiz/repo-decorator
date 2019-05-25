using System;
using System.Collections.Generic;
using System.Diagnostics;
using RepoDecorator.Home.Dominio;

namespace RepoDecorator.Home.Infraestrutura
{
    public class RepositorioValidadorEntidade<T> : RepositorioBaseDecorator<T>
        where T : EntidadeBase
    {
        public RepositorioValidadorEntidade(IRepositorio<T> repo) 
            : base (repo)
        {
        }

        public override void Atualizar(T entidade)
        {
            Debug.Write($"Validando entidade '{typeof(T).Name}' durante atualização{Environment.NewLine}");
            RepoBase.Atualizar(entidade);
        }

        public override IEnumerable<T> ListarTodos()
        {
            Debug.Write($"Validando entidades '{typeof(T).Name}' durante listagem{Environment.NewLine}");
            return RepoBase.ListarTodos();
        }

        public override T ObterPorId(Guid id)
        {
            Debug.Write($"Validando entidade '{typeof(T).Name}' durante busca por id #{id}{Environment.NewLine}");
            return RepoBase.ObterPorId(id);
        }

        public override void Remover(T entidade)
        {
            Debug.Write($"Validando entidade '{typeof(T).Name}' durante exlusão{Environment.NewLine}");
            RepoBase.Remover(entidade);
        }

        public override T Salvar(T entidade)
        {
            Debug.Write($"Validando entidade '{typeof(T).Name}' durante gravação{Environment.NewLine}");
            return RepoBase.Salvar(entidade);
        }
    }
}
