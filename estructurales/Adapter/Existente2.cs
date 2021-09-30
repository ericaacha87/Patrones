using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Existente2 : IExistente2
    {
        public float SumarValores(float valor1, float valor2)
        {
            Console.WriteLine("Desde sumarValores de Existente2");
            return valor1 + valor2;
        }
    }
}
