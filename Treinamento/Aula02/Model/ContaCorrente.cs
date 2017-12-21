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

        const decimal CPMF = 0.001m;

        public override void Movimentar()
        {
            throw new NotImplementedException();
        }

        private void TributarImposto(decimal valor) {
            var imposto = (valor * CPMF);

            this.Saldo -= imposto;

            _extrato.Add(new Item()
            {
                Data = DateTime.Now,
                Saldo = this.Saldo,
                Tipo = TipoItem.Imposto,
                Valor = imposto * -1
            });

        }

        public override void Sacar(decimal valor)
        {
            base.Sacar(valor);

            TributarImposto(valor);
            
        }

        public override void Depositar(decimal valor)
        {
            base.Depositar(valor);

            TributarImposto(valor);

        }
    }
}
