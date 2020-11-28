using System;

using static System.Math;

using static System.Console;

namespace ConceptoPOO32
{
    class Program
    {
        static void Main(string[] args)
        {
            realizarTarea();
            Console.WriteLine("Hello World!");

            /*double raiz = Math.Sqrt(9);
            double potencia = Math.Pow(3, 9);

            Console.WriteLine(raiz);
            Console.WriteLine(potencia);
            
            var miVariable = new { Nombre = "Juan", Edad = 19 };

            Console.WriteLine(miVariable.Nombre + " " + miVariable.Edad  );

            var miotraVariable = new { Nombre = "Ana", Edad = 25 };

            miVariable = miotraVariable;
            */
        }

        static void realizarTarea()
        {
            
            Punto origen = new Punto();

            Punto destino = new Punto(125,80);

            Punto otropunto = new Punto();

            double distancia = origen.DistanciaHasta(destino);

            Console.WriteLine($"La distancia entre los puntos es de: {distancia}");

            Console.WriteLine($"Numero de objetos creados: {Punto.ContadorDeObjetos()}");
        }

        
    }
}
