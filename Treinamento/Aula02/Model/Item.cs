using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Aula02.Model
{
    public class Item
    {
        public DateTime Data { get; set; }

        public decimal Valor { get; set; }

        public decimal Saldo { get; set; }

        public TipoItem Tipo { get; set; }

        public override string ToString()
        {
            var culture = CultureInfo.GetCultureInfo("en-US");

            return $"Tipo: {Tipo.ToString()}- {Data.ToString("dd/MM/yyyy HH:mm")} - {Valor.ToString("C2", culture)} - Saldo: { Saldo.ToString("C2")}";
        }
    }
}
