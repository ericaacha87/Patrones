using System;

// PERMITE independizar/desacoplar una clase monolitica en Abrastraccion e Implementaciones.
// Permite generar nuevas clases que hereden de Abstraccion de forma independiente de las implementaciones.

//por ejemplo dado un logger que escribe en 1 txt y en consola

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            //utilizo la abstraccion, indico que implementacion utilizara
            Abstraccion abstraccion = new Abstraccion( new ImplementacionConsola());
            abstraccion.Escribir("hola soy contenido");
            Console.ReadKey();
           
        }
    }
}
