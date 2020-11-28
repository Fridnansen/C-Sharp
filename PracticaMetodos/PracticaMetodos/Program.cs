using System;

namespace PracticaMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            sumaNumeros(7,9);
            
            Console.WriteLine("Mensaje desde el main");
            //mensajeEnPantalla();
            //mensajeEnPantalla();
        }
        /* static void mensajeEnPantalla()
         {
             Console.WriteLine("Mensaje desde el metodo mensajeEnPantalla");
         }*/

        static void sumaNumeros(int num1, int num2)
        {
            Console.WriteLine($"La suma de los numeros es: {num1+num2}");
        }
    }
}
