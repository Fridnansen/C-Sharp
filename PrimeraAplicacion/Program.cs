using System;

namespace PrimeraAplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int edadPersona1;
            int edadPersona2;
            int edadPersona3;
            int edadPersona4;

            edadPersona1 = edadPersona2 = edadPersona3 = edadPersona4 = 27;*/

            /*Console.WriteLine("Introduce el primer número");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el segundo número");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("El resultado es: " + (num1 + num2));*/

            /*const int VALOR = 5;
            const int VALOR2 = 7;
            Console.WriteLine("El valor de la constante es: {0}", VALOR, VALOR2);*/

            const double PI = 3.1416;

            Console.WriteLine("Introduzca la cantidad de radio: ");

            double radio = double.Parse(Console.ReadLine());

            //double area = radio * radio * PI;

            double area = Math.Pow(radio, 2);

            Console.WriteLine($"El area del Circulo es: {area}");

         
        }
    }
}
