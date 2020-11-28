using System;
using System.Collections.Generic;
using System.Text;

namespace vehiculo_47
{
    class vehiculo
    {

        public void ArrancaMotor(string sonidoAlArrancar)
        {

            Console.WriteLine($"Arraque el motor: {sonidoAlArrancar}");

        }
        public void ParaMotor(string sonidoAlParar)
        {

            Console.WriteLine($"Apagar el Motor: {sonidoAlParar}");

        }
        public virtual void Conducir()
        {

            Console.WriteLine("Este el codigo generico para metodo conducir");

        }

    }
}
