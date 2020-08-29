using System;
using System.Collections.Generic;
using System.Text;

/* Las interaces podriamos definirlas como un conjunto de directrices que deben cunplir las clases. Las interfaces son parecidad a las clases pero con la diferencias es que en ellas
 solo se definen los metodos. Las clases pueden implementar de las interfaces o en otras palabras heredar de las interfaces */


namespace Curso.Interfaces
{
    // usaremos el codigo de ejemplos anteriores 
    class interfaces1
    {
        static void Main(string[] args)
        {
            Ballena Willy = new Ballena("Willy");
            Caballo Blancus = new Caballo("Blancus");
            Gorila Copito = new Gorila("Copito");

            Willy.CuidarCrias();
            Willy.Nadar();
            Blancus.CuidarCrias();
            Blancus.galopar();
            Blancus.NumeroPatas(); // Solo podran utilizar este metodo los caballos y gorilas

        }
    }
    /*Crearemos una interfaz que nos permita establecer que cuando se cree una clase
     que herede de mafieros que si esa clase pertence a un animal el cual puede tener 
    4 patas se especefique el numero de patas de este */

    interface IMamiferosTerrestres { // creacion de la interface 

        int NumeroPatas(); /*En C# las interfaces no llevan metodo accesor, solo por defecto 
                            public y los metodos solo se define no se codifican o sea no hay codigo en ellos*/
     
    }

    class Mamiferos
    {

        private String nombreSerVivo;



        public Mamiferos(string nombre)
        {

            nombreSerVivo = nombre; 

        }
        public void Respirar()
        {

            Console.WriteLine("puedo respirar");
        }

        public void CuidarCrias()
        {

            Console.WriteLine("cuido de mis crias hasta que se valgan por si solas");
        }

        public void getNombreSerVivo()
        { 

            Console.WriteLine("El nombre del ser vivo es: " + nombreSerVivo);
        }

      

    }

/* La sintaxis para que una clase herede una interfaz es la misma que como las clases 
   pero cuando esta ya esta heredando de otra clase se agrega coma y el nombre de la interfaz
   Tambien se debe seguir un orden en este caso, siempre van primero los nombres de las clases
   de las cuales se esten heredando y luego las de las interfaces*/
    class Caballo : Mamiferos, IMamiferosTerrestres 
    {
        public Caballo(string nombreCaballo) : base(nombreCaballo)
        { 

        }
       
        public void galopar()
        {

            Console.WriteLine("soy capaz de galopar");
        }

        public int NumeroPatas() { // Al implementar una interdaz estamos a obligados a implementar su metodo creandolo en la clase en la cual se implemento la interfaz

            return 4; 

        }
    }

    class Humano : Mamiferos
    {
        public Humano(string nombreHumano) : base(nombreHumano)
        {

        }

        public void pensar()
        {

            Console.WriteLine("Puedo pensar");
        }

    }

    class Gorila : Mamiferos, IMamiferosTerrestres {

        public Gorila(string NombreGorila) : base(NombreGorila) { 
        }

        public void Trepar() {

            Console.WriteLine("puedo teprar");
        }

        public int NumeroPatas() { // como el gorilla tiene patas pues usamos la interfaz

            return 2;
        }
    }

    class Ballena : Mamiferos {

        public Ballena(string NombreBallena) : base(NombreBallena) { 
        }

        public void Nadar() {

            Console.WriteLine("Puedo nadar");
        }
    
    }




}    
