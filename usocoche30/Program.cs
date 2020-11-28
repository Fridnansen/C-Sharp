using System;

namespace usocoche30
{
    class Program
    {
        static void Main(string[] args)
        {

            Coche coche1 = new Coche(); //crear objeto/instancia de tipo coche
            // dar un estado inicial a nuestro coche
            Coche coche2 = new Coche();

            //coche2 getRuedas = 27;

            Console.WriteLine(coche1.getInfoCoche());
            Console.WriteLine(coche2.getInfoCoche());
            Console.WriteLine(coche2.getExtras());
            Coche coche3 = new Coche(4500.25, 1200.35);

            Console.WriteLine(coche3.getInfoCoche());
            coche3.setExtras(true, "cuero");
            Console.WriteLine(coche3.getExtras());
        }
    
    }
    partial class Coche
    {
        public Coche()
        {
            ruedas = 4;

            largo = 2300.5;

            ancho = 0.800;

            climatizador = true;

            tapiceria = "Tela";


        }

        public Coche(double largoCoche, double anchoCoche)
        {
            ruedas = 4;

            largo = largoCoche;

            ancho = anchoCoche;

        }
        public int getRuedas()
        {
            return ruedas;
        }
    }


    partial class Coche
    { 
        public String getInfoCoche()
        {
            return "Información del coche: " + "\nRuedas:" + ruedas + "\nLargo:" + largo + "\nAncho:" + ancho;
        }

        public void setExtras(bool climatizador, String tapiceria)
        {
            this.climatizador = climatizador;
            
            this.tapiceria = tapiceria;

        }
        
        public String getExtras()
        {

            return "Extras del coche: " + "\nTapiceria:" + tapiceria + "\nClimatizador:" + climatizador;
        }

        private int ruedas;

        private double largo;

        private double ancho;

        private bool climatizador;

        private String tapiceria;

    }

    
}   
 
