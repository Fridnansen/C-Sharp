using System;
using System.Collections.Generic;
using System.Text;

namespace ConceptoPOO32
{
    class Punto
    {
        public Punto(int x, int y)
        {

            this.x = x;
            this.y = y;

            contadorDeObjetos++;
            
            Console.WriteLine($"Coodenada x: {x}, Coordenada y: {y}");

        }

        public Punto()
        {
            this.x = 0;
            this.y = 0;
            
            contadorDeObjetos++;

            Console.WriteLine("Este es el constructor por defecto");

        }

        public double DistanciaHasta(Punto otroPunto)
        {

            int xDif = this.x - otroPunto.x;

            int yDif = this.y - otroPunto.y;

            double distanciaPuntos = Math.Sqrt(Math.Pow(xDif, 2) + Math.Pow(yDif, 2));

            return distanciaPuntos;
        }

        /*public static int ContadorDeObjetos()
        {

            return contadorDeObjetos;

        }*/


        public static int ContadorDeObjetos()=> contadorDeObjetos;

        public const int constantePrueba = 7;

        private int x, y;

        private static int contadorDeObjetos = 0;
        
    }
}
