using System;

namespace ejemploPPO
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo miCirculo; // creación de objeto de tipo Circulo. Variable / objeto de tipo circulo 

            miCirculo = new Circulo(); //iniciación de variable /objeto de tipo Circulo. Instanciar una clase
            // Intanciación. Ejemplarizar. Creación de ejemplar de clase

            Console.WriteLine(miCirculo.CalculoArea(5));

            Circulo miCirculo2 = new Circulo();

            Console.WriteLine(miCirculo2.CalculoArea(9));

            Console.WriteLine(miCirculo.CalculoArea(5));

            CoversorEuroDolar obj = new CoversorEuroDolar();
            
            obj.cambiaValorEuro(-1.45);

            Console.WriteLine(obj.convierte(50));
        }
    }

    class Circulo
    {

        private const double pi = 3.1416; // propiedad de la clase circulo. Campo de Clase
        public double CalculoArea(int radio) //metodo de clase ¿Que puede hacer los objetos de tipo circulo?
        {
            return pi * radio * radio;
        }

    }

    class CoversorEuroDolar
    {

        private double euro = 1.253;

        public double convierte(double cantidad)
        {

            return cantidad * euro;

        }



        public void cambiaValorEuro(double nuevoValor)
        {
            if (nuevoValor < 0) euro = 1.253;

            else
            euro = nuevoValor;

        }
    }
}