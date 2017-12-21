using System;
using Aula02.Model;
using System.Text;

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


            //int i = 10;

            //Console.WriteLine("Input a number: ");
            //int n = Console.Parse(Console.ReadLine());

            //if (!(i == n)) {


            //}else if (i != n) 

            //StringBuilder sb = new StringBuilder;

            //sb.Append("ABC");

           // var name = "1,2,3,4,5";

           // var a = name.Split(",");

           
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
