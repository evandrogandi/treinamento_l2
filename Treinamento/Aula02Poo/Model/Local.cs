using System;

namespace Aula01.Model
{
    class Local
    {
        public string Code { get; set; }

        public int Size { get; set; } = 100;

        public Local()
        {

        }

        public Local(string code, int size)
        {
            Code = code;
            Size = size;
        }

    }
    class Sector : Local, Interface1
    {


        public Farm[] Farms { get; set; }
        public Sector(string code, int size)
            : base(code, size)
        {

        }
        public void Harvest()
        {
            Console.WriteLine("Harvest Sector {0} ", Code);
        }
    }

    class Farm : Local, Interface1
    {


        public Block[] Blocks { get; set; }

        public void Harvest()
        {
            Console.WriteLine("Harvest Farm {0} ", Code);
        }
    }

    class Block : Local, Interface1
    {


        public Field[] Fields { get; set; }

        public void Harvest()
        {
            Console.WriteLine("Harvest Block {0} ", Code);
        }
    }
    class Field : Local, Interface1

    {


        private string _culture;
        public string Culture
        {
            get
            {
                return _culture;
            }
            set
            {
                _culture = value;
            }
        }
        public void Plant(string culture)
        {
            Culture = culture;
        }

        public void Harvest()
        {
            Console.WriteLine("Harvest Field {0} - {1} ", Code, Culture);
        }

    }
}
