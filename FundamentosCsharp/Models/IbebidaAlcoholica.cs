using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosCsharp.Models
{
    internal interface IbebidaAlcoholica
    {
        public int Alcohol {  get; set; }

        public void MaxRecomendado();
    }
}
