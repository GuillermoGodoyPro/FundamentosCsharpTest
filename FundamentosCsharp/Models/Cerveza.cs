using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FundamentosCsharp.Models
{
    internal class Cerveza : Bebida, IbebidaAlcoholica
    {
        public int Alcohol { get; set; }

        public void MaxRecomendado()
        {
            Console.WriteLine("El máximo recomendado son 4 pintas");
        }

        public Cerveza( int Cantidad, string Nombre = "Stout Imperial") 
            : base(Nombre , Cantidad)
        {
       
        }


    }
}
