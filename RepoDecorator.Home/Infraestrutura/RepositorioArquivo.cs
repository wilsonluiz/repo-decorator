using System;
using System.Collections.Generic;
using System.Diagnostics;
using RepoDecorator.Home.Dominio;

namespace RepoDecorator.Home.Infraestrutura
{
    public class RepositorioArquivo<T> : RepositorioBaseDecorator<T> 
        where T : EntidadeBase
    {
        public RepositorioArquivo(IRepositorio<T> repo) : base (repo)
        {
        }

        public override void Atualizar(T entidade)
        {
            

            Debug.Write($"Gerando arquivo da entidade '{typeof(T).Name}' que foi atualizada.{Environment.NewLine}");
            RepoBase.Atualizar(entidade);
        }

        public override IEnumerable<T> ListarTodos()
        {
            Debug.Write($"Gerando arquivo da lista de todas as entidades '{typeof(T).Name}'{Environment.NewLine}");
            return RepoBase.ListarTodos();
        }

        public override T ObterPorId(Guid id)
        {
            Debug.Write($"Gerando arquivo da entidade '{typeof(T).Name}' obtida a partir do id #{id}{Environment.NewLine}");
            return RepoBase.ObterPorId(id);
        }

        public override void Remover(T entidade)
        {
            Debug.Write($"Gerando arquivo da exlusão da entidade '{typeof(T).Name}'{Environment.NewLine}");
            RepoBase.Remover(entidade);
        }

        public override T Salvar(T entidade)
        {
            Debug.Write($"Gerando arquivo da entidade '{typeof(T).Name}' persistida{Environment.NewLine}");
            return RepoBase.Salvar(entidade); ;
        }
    }
}
