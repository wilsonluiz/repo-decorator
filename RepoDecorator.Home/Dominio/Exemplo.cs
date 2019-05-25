using System;
using System.Collections.Generic;
using System.Text;

namespace RepoDecorator.Home.Dominio
{
    public class Exemplo : EntidadeBase
    {
        public Exemplo() 
            : this (Guid.NewGuid())
        {
        }

        public Exemplo(Guid id)
        {
            Id = id;
        }

        public override bool EstaValida()
        {
            return true;
        }
    }
}
