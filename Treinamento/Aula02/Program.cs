using System;
using Aula02.Model;

namespace Aula02
{
    class Program
    {
        static void ImprimirExtrato(Conta c)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("-IMPRIMINDO EXTRATO----------------");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($" Agencia {c.Agencia}   Conta {c.Numero}");
            Console.WriteLine("-----------------------------------\n");

            Item[] extrato = c.ObterExtrato();

            foreach (Item item in extrato)
            {
                if (item.Valor < 0 || item.Valor == 0) {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }               

                Console.WriteLine(item);
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("-----------------------------------");
        }

        static void Main(string[] args)
        {
            Conta c = new ContaCorrente(70, 13);

            c.Depositar(100m);

            ImprimirExtrato(c);

            c.Sacar(50m);
            c.Depositar(150m);

            ImprimirExtrato(c);

            Console.ReadKey();
        }
    }
}
