using System;

// dadas dos interfaces incompatibles, adapter actua como un traductor entre las mismas.
// Adapter implementa Interfaz1 y contiene interfaz2 (llama a sus metodos)

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //objetivo IExistente1 quiere usar metodos de IExistente2
            IExistente2 existente2 = new Existente2();
            IExistente1 existente1 = new Adaptador1To2(existente2);


            existente1.Sumar(4,5);

            Console.WriteLine("press a key to finish");
            Console.ReadLine();
        }
    }
}
