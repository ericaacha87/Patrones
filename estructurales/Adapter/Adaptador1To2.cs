using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//IMPLEMENTA UNA INTERFAZ  
//CONTIENE la otra interfaz
namespace Adapter
{
    public class Adaptador1To2 : IExistente1  // 
    {
        IExistente2 _existente2;

        public Adaptador1To2(IExistente2 existente)
        {
            _existente2 = existente;
        }
            
        public int Sumar(int valor1, int valor2)
        {
            // realiza adaptacion/traduccion
            float valor_f1 =(float) valor1;
            float valor_f2 = (float)valor2;
            // llama a la interfaz 
            float result = _existente2.SumarValores(valor_f1, valor_f2);
            return Convert.ToInt32(result);
        }
    }
}
