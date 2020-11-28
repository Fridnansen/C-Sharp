using System;

namespace Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1 = 7;
            double valor2 = 5.2;
            double valor3 = 8.3;
            Console.WriteLine(suma(valor1,valor2));
        }

        private static double suma(int v1, double v2, double v3=0)
        {
            return v1 + v2 + v3;
        }
        private static double suma(int v1, double v2)
        {
            return v1 + v2;
        }
        /* static int suma(int operador1, int operador2) => operador1 + operador2;

         static int suma(int operador1, int operador2, int operador3) => operador1 + operador2;

         static int suma(int operador1, int operador2, int operador3, int operador4) => operador1 + operador2;
         */
    }
}
