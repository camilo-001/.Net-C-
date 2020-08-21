using Curso.Herencia;
using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.Herencia // Sintaxis basica de la herencia en C#
{
    class Herencia1
    {
        static void Main(string[] args) {

            Caballo caballito = new Caballo("Babieca"); // Como vimos con el tema del constructor debemos enviar por parametro un nombre
            Humano Juan = new Humano("juanclimaco");

            Juan.CuidarCrias();
            Juan.getNombreSerVivo(); // usamos el metdo get para poder ver el nombre del ser vivo

        }


    }

    class Mamiferos { // La clase mamiferos será nuestra super clase de la cual heredarán otras clases

        private String nombreSerVivo; // creamos variable

        /*Si nuestra super clase cuenta con un constructor que no es el constructor por defecto, todas las clases que están 
         heredando de ella sus constructores por defecto deben ser modificados igual debido a que si nuestra superclase solo
        tuviese el constructor por defecto las otras clases hijas llamarían a ese constructor desde sus constructores por defecto*/


        public Mamiferos(string nombre) /* Creamos el constructor el cual pretende definir un nombre para cada mamifero. Este constructor
                                        recibe como parametro un nombre  */
        {

            nombreSerVivo = nombre; // ese valor que recibe el parametro lo almacenamos en la variable que habíamos creado

        }
        public void Respirar() {

            Console.WriteLine("puedo respirar");
        }

        public void CuidarCrias() {

            Console.WriteLine("cuido de mis crias hasta que se valgan por si solas");
        }

        public void getNombreSerVivo(){ // como hemos visto anteriormente debemos tener un metodo para poder acceder

            Console.WriteLine("El nombre del ser vivo es: " + nombreSerVivo);
        }

        /*Este metodo get será heredado por todas las clases hijas */

    }


    class Caballo : Mamiferos  // Esta es la sintaxis para cuando una clase hereda de otra (En java se utiliza el extends aca los dos puntos)
    {
        public Caballo(string nombreCaballo) : base(nombreCaballo) { // entonces para que este constructor llame al constructor del padre usamos :base y el nombre del constructor
        
        }
        /* Creamos el constructor de la clase hija para que este pueda llamar al constructor
        de la clase padre para que establezca un estado inicial en este caso un nombre para
        cada mamifero o clase que herede de mamifero*/

        public void galopar() {

            Console.WriteLine("soy capaz de galopar");
        }
    }

    class Humano : Mamiferos
    {
        public Humano(string nombreHumano) : base(nombreHumano) { 
        
        
        } 

        public void pensar() {

            Console.WriteLine("Puedo pensar");
        }

    }

}


