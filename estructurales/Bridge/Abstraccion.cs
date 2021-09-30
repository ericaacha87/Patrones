using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Abstraccion
    {
        private Interfaz _interface;

        public Abstraccion(Interfaz interfaz)
        {
            _interface = interfaz;
        }

        public void Escribir(string contenido)
        {
            _interface.Escribir(contenido);
        }
    }
       
    
}
