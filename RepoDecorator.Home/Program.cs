using System;
using RepoDecorator.Home.Dominio;
using RepoDecorator.Home.Infraestrutura;

namespace RepoDecorator.Home
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var entidade = ObterEntidade();

            IRepositorio<Exemplo> repo = new RepositorioBase<Exemplo>();
            repo = new RepositorioArquivo<Exemplo>(repo);
            repo = new RepositorioValidadorEntidade<Exemplo>(repo);

            repo.Salvar(entidade);

            Console.ReadLine();
        }

        private static Exemplo ObterEntidade()
        {
            return new Exemplo();
        }
    }
}
