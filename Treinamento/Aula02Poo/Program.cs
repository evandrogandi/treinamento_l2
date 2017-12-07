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

        public static void Show(Local local)
        {
            Console.WriteLine("{0} - {1}", local.Code, local.Size);
        }

        static void Main(string[] args)
        {
            int i = 10;
            bool b = true;

            string s = "Evandro";


            Print(i);
            Print(s);
            Print(b);

            Sector l1 = new Sector("S1", 100);
            Farm f1 = new Farm();
            f1.Code = "F1";

            Field f2 = new Field("Field2");
            f2.Culture = "Soja";

            Show(l1);

            Show(f2);

            Console.ReadKey();
        }
    }
}
