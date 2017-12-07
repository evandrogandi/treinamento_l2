using System;
using System.Collections.Generic;
using System.Text;

namespace Aula02Poo.Model
{
    class Local
    {
        public int Size { get; set; } = 10;

        public string Code { get; set; }


        public Local()
        {

        }

        public Local(string code, int size)
        {
            Code = code;
            Size = size;
        }

        public virtual void Harvest()
        {


        }

    }

    class Sector : Local
    {
        
        public Farm[] Farms { get; set; }

        public Sector(string code, int size)
            : base(code, size)
        {
        }

        public override void Harvest()
        {
            Console.WriteLine("Harvest Sector {0}", Code);
        }
    }

    class Farm : Local
    {
        public Block[] Blocks { get; set; }

        public override void Harvest()
        {
            Console.WriteLine("Harvest Blocks {0}", Code);
        }

    }

    class Block : Local
    {

        public Field[] Fields { get; set; }

        public override void Harvest()
        {
            Console.WriteLine("Harvest Block {0}", Code);
        }

    }

    class Field : Local
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
                Culture = _culture;
            }
        }
        public void Plant(string culture)
        {
            Culture = culture;
        }

        public Field(string code)
        {
            Code = code;
        }

        public override void Harvest()
        {
            Console.WriteLine("Harvest Field {0} Culture {1}", Code, Culture);
        }

    }
}
