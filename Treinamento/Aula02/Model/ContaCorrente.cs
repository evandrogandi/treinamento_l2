using System;
using System.Collections.Generic;
using System.Text;

namespace Aula02.Model
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente(int numero, int agencia)
        {
            Numero = numero;
            Agencia = agencia;
        }

        public override void Movimentar()
        {
            throw new NotImplementedException();
        }
    }
}
