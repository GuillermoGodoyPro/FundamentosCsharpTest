using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosCsharp.Models
{
    internal class Vino : Bebida , IbebidaAlcoholica
    {
        public int Alcohol { get; set; }

        public void MaxRecomendado()
        {
            Console.WriteLine("El máximo recomendado son 4 copas");
        }

        public Vino(int Cantidad, string Nombre = "Malbec")
            : base(Nombre, Cantidad)
        {

        }
    }
}
