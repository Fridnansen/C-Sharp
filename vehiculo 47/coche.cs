using System;
using System.Collections.Generic;
using System.Text;

namespace vehiculo_47
{
    class coche: vehiculo
    {

        public void Acelerar()
        {

            Console.WriteLine("Acelerando");

        }

        public void Frenar()
        {

            Console.WriteLine("Frenando");

        }

        public override void Conducir()
        {
            // base.Conducir();
            Console.WriteLine("Tomando las curvas con desición y destreza");
        }

    }
}
