
using System;

namespace Exercicios_tratamento_exceçoes.Entities.Exeception
{
    class DomainExcepitions : ApplicationException
    {
        public DomainExcepitions(string message) : base(message)
        {
        }
    }
}
