using System;

namespace ejer4
{ /// <summary>
    /// Leer datos desde teclado
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Suma de dos números");
            Console.Write("Ingresa número 1: ");
            string dato = Console.ReadLine();
            int n1 = int.Parse(dato);

            Console.WriteLine("Ingresa número 2: ");
            dato = Console.ReadLine();
            int n2 = int.Parse(dato);
            int suma = n1 + n2;
            Console.WriteLine("El resultado es: {0}", suma);
        }
    }
}
