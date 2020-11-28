using System;
using System.Collections.Generic;
using System.Text;

namespace vehiculo_47
{
    class avion:vehiculo
    {

        public void Aterrizar()
        {

            Console.WriteLine("Aterrizando");

        }

        public void Despegar()
        {

            Console.WriteLine("Despegando");

        }

        public override void Conducir()
        {
            //base.Conducir();
            Console.WriteLine("Surcendo los cielos del globo");
        }
    }
}
