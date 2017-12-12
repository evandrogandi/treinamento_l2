using System;
using Aula02Poo.Model;

namespace Aula02Poo
{
    class Program
    {
        public static void Print(object o)
        {
            Console.WriteLine(o.ToString());
        }
        public static void Show(Interface1 Iinterface)
        {
            Console.WriteLine("{0} - {1}", Iinterface.Code, Iinterface.Size);
            Iinterface.Harvest();
        }


        static void Main(string[] args)
        {
            int i = 10;
            bool b = true;
            string s = "Sergio";


            Print(i);
            Print(b);
            Print(s);

            Sector L1 = new Sector("S1", 100);
            Farm farm1 = new Farm();
            farm1.Code = "F1";

            Block block1 = new Block();
            block1.Code = "B1";
            block1.Size = 50;

            Field field = new Field();
            field.Code = "F1";
            field.Size = 10;
            field.Culture = "Sugar Cane";



            Show(L1);
            Show(farm1);
            Show(block1);
            Show(field);
            Console.ReadKey();

        }
    }
}