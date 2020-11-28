using System;

namespace vehiculo_47
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Probando el avión");

            avion miAvion = new avion();

            miAvion.ArrancaMotor("tracatatracata");

            miAvion.Despegar();

            miAvion.Conducir();

            miAvion.Aterrizar();

            miAvion.ParaMotor("Plooooof");

            Console.WriteLine();

            Console.WriteLine("Probando Coche");

            coche miCoche = new coche();

            miCoche.ArrancaMotor("Gruuuummm grummmmm");

            miCoche.Acelerar();
            
            miCoche.Conducir();
            
            miCoche.Frenar();

            miCoche.ParaMotor("Bluuuuuuuuu");

            Console.WriteLine();

            Console.WriteLine("Pimorfimos en acción");

            vehiculo miVehiculo = miCoche;

            miVehiculo.Conducir();

            miVehiculo = miAvion;
            
            miAvion.Conducir();

        }
    }
}
