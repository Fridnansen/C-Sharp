using System;
using System.IO;

namespace Destructor59
{
    class Program
    {
        static void Main(string[] args)
        {
            ManejoArchivos miArchivo = new ManejoArchivos();
            miArchivo.mensaje();

            Console.WriteLine("Hello World!");
        }
    }

    class ManejoArchivos
    {
        StreamReader archivo = null;

        int contador = 0;

        string linea;

        public ManejoArchivos()
        {

            archivo = new StreamReader(@"C:\Users\Lenovo\Desktop\Tirar.txt");

            while ((linea = archivo.ReadLine()) != null)
            {

                Console.WriteLine(linea);

                contador++;

            }

        }

        public void mensaje()
        {

            Console.WriteLine("Hay {0} lineas", contador);

        }

        ~ManejoArchivos()
        {

            archivo.Close();

        }
    }
}
