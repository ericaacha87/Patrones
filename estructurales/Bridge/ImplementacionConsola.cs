﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class ImplementacionConsola : Interfaz
    {
        public void Escribir(string contenido)
        {
            
            Console.WriteLine("Escribir desde ImplementacionConsola: "+contenido);
        }
    }
}
