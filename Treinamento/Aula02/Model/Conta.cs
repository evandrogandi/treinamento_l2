using System;
using System.Collections.Generic;
using System.Text;

namespace Aula02.Model
{
    public abstract class Conta
    {
        private List<Item> _extrato = new List<Item>();

        public int Agencia { get; set; }

        public int Numero { get; set; }

        public decimal Saldo { get; set; }

        public void Sacar(decimal valor)
        {
            Saldo -= valor;
            _extrato.Add(new Item()
            {
                Data = DateTime.Now,
                Valor = valor * -1

            });
        }

        public void Depositar(decimal valor)
        {
            Saldo += valor;
            _extrato.Add(new Item()
            {
            Data = DateTime.Now,
            Valor = valor

            });
        }

        public abstract void Movimentar();

        public Item[] ObterExtrato() {
            return _extrato.ToArray();
        }

    }
}
