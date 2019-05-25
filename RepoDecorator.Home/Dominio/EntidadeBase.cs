using System;
using System.Collections.Generic;
using System.Text;

namespace RepoDecorator.Home.Dominio
{
    public abstract class EntidadeBase
    {
        public Guid Id { get; set; }

        public abstract bool EstaValida();
    }
}
