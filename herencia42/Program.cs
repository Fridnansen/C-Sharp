using System;

namespace herencia42
{
    class Program
    {
        static void Main(string[] args)
        {

            Caballo miBabieca = new Caballo("Babieca");

            Humano miJuan = new Humano("Juan");

            Gorila miCopito = new Gorila("Copito");


            /* miBucefalo = new Caballo("Bucefalo");

            Mamiferos persona = new Humano("Juan");

            Mamiferos miAnimal = new Mamiferos("Bucefalo");

            miAnimal = miBucefalo;

            miBucefalo = miAnimal;*/


            /* Object miAnimal = new Caballo("Bucefalo");

             Mamiferos[] almacenAnimales = new Mamiferos[3];

             almacenAnimales[0] = miBabieca;

             IMamiferosTerrestres ImiBabieca = miBabieca;

             IsaltoConPatas IBabieca = miBabieca;

             almacenAnimales[1] = miJuan;

             almacenAnimales[2] = miCopito;

             for(int i=0; i<3; i++)
             {
                 almacenAnimales[i].pensar();

             }

             Mamiferos miMamiferos = new Mamiferos("");

             miMamiferos.respirar();

             //almacenAnimales[1].getNombre();


            miJuan.getNombre();

             miBabieca.getNombre();

             miCopito.getNombre();

             Console.WriteLine("Hello World!");

             Ballena miWally = new Ballena("Wally");

             miWally.nadar();

             Console.WriteLine("Número de patas de Babieca: " + ImiBabieca.numeroPatas());

             Console.WriteLine("Número de patas de Babieca: " + IBabieca.numeroPatas());*/

            Lagartija Juancho = new Lagartija("Juancho");

            Juancho.getNombre();

            Humano Juan = new Humano("Juan");

            Juan.respirar();
        }
    }

interface IMamiferosTerrestres
    {
        int numeroPatas();

    }

interface IAnimalesYDeportes
    {

        string tipoDeporte();

        Boolean esOlimpico();

    }
interface IsaltoConPatas
    {

        int numeroPatas();


    }

    abstract class Animales
    {
        public void respirar()
        {

            Console.WriteLine("Soy capaz de respirar");

        }


        public abstract void getNombre();



    }

    class Lagartija : Animales
    {
        public Lagartija(String nombre)
        {

            nombreReptil = nombre;

        }

        public override void getNombre()
        {
            Console.WriteLine("El nombre del reptil es: " + nombreReptil);
        }

        private String nombreReptil;
    }
    class Mamiferos: Animales 
    {
        public Mamiferos(String nombre)
        {

            nombreServivo = nombre;

        }

        /*public void respirar()
        {

            Console.WriteLine("Soy capaz de respirar");

        }*/

        public virtual void pensar()
        {

            Console.WriteLine("Pensamiento basico institivo");

        }
        public void cuidarCrias()
        {

            Console.WriteLine("Cuidar de mis crias que se valga por si solas");

        }
        public override void getNombre()
        {

            Console.WriteLine("El nombre del ser vivo es: " + nombreServivo);

        }

        public int numeroPatas()
        {
            return patas;

        }

        private String nombreServivo;
        private int patas;
    }

    class Ballena : Mamiferos
    {

        public Ballena(String nombreBallena) : base(nombreBallena) { }

        public void nadar()
        {

            Console.WriteLine("Soy capaz de nadar");

        }


    }
    class Caballo : Mamiferos, IMamiferosTerrestres, IAnimalesYDeportes, IsaltoConPatas
    {
        public Caballo(String nombreCaballo): base(nombreCaballo) {}

        public void galopar()
        {

            Console.WriteLine("Soy Capaz de Galopar");
            respirar();

        }
        int IMamiferosTerrestres.numeroPatas()
        {

            return 4;

        }

        int IsaltoConPatas.numeroPatas()
        {

            return 2;

        }


        public string tipoDeporte()
        {

            return "Hipica";

        }
        public Boolean esOlimpico()
        {

            return true;
        }
    }

    class Humano : Mamiferos
    {

        public Humano(String nombreHumano): base(nombreHumano) { }
        
        public override void pensar()
        {

            Console.WriteLine("Soy capaz de pensar");
            
        }

    }
    /*
    class Adolecente : Humano
    {

        public Adolecente(string nombreAdolecente): base(nombreAdolecente)
        {


        }

        public override void pensar()
        {

            Console.WriteLine("Soy capaz de pensar");

        }

    }
    */

    class Gorila : Mamiferos, IMamiferosTerrestres
    {
        public Gorila(String nombreGorila): base(nombreGorila) { }
        
        public override void pensar()
        {

            Console.WriteLine("Pensamiento básico intintivo");

        }
        public void trepar()
        {

            Console.WriteLine("Soy capaz de trepar");
        }

        public int numeroPatas()
        {

            return 2;

        }

    }
    class Chimpance: Gorila
    {

        public Chimpance(string nombreChipance):base(nombreChipance)
        {



        }
    }

}
