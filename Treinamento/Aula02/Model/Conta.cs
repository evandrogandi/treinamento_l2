using System;
using System.Collections.Generic;
using System.Text;

namespace Aula02.Model
{
    public abstract class Conta
    {
        protected List<Item> _extrato = new List<Item>();

        public int Agencia { get; set; }

        public int Numero { get; set; }

        public decimal Saldo { get; set; }

        public virtual void Sacar(decimal valor)
        {
            Saldo -= valor;
            _extrato.Add(new Item()
            {
                Data = DateTime.Now,
                Valor = valor * -1,
                Saldo = this.Saldo,
                Tipo = TipoItem.Saque,
            });
        }

        public virtual void Depositar(decimal valor)
        {
            Saldo += valor;
            _extrato.Add(new Item()
            {
                Data = DateTime.Now,
                Valor = valor,
                Saldo = this.Saldo,
                Tipo = TipoItem.Deposito

            });
        }

        public abstract void Movimentar();

        public Item[] ObterExtrato() {
            return _extrato.ToArray();
        }

    }
}
