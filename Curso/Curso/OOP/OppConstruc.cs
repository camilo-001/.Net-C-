using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.OOP
{
    class OppConstruc
        /*Em este programa podremos ver para y como se usan los constructores y el como podremos usar metodos accesores como getters y setters*/
    {
        static void Main(String[] args) {


            Auto Carro1 = new Auto(); // crear objeto /instancia de tipo Auto
            // este carro tiene como estado inicial 

            Auto Carro2 = new Auto(); // este segundo objeto tendra los mismos atributos del anterior

            Auto carro3 = new Auto(45.6, 126.9); // en este caso hemos llamado al segundo constructor en el cual podemos cambiar dos de sus atributos


            Console.WriteLine(Carro1.getInfoAuto()); // visualizaremos los atributos de este carro con los atributos del primer constructor o sea los atributos por defecto 
            Console.WriteLine(carro3.getInfoAuto()); // visualizaremos los atributos de este carro por medio del metodo getinfo con los atributos que hemos modificado para este carro

        }
    }

    class Auto {

        // Los metodos constructores tiene como finalidad establecer un estado inicial a los objetos de tipo Auto
        public Auto()
        { // Creamos nuestro metodo constructor

            ruedas = 4;
            largo = 2300.5;
            ancho = 0.800; 
         }
        
        // podemos crear otro constructor de la misma clas a esto se le conoce como sobre carga de constructores
        public Auto(double LargoAuto, double AnchoAuto) { // este segundo constructor va a recibir parametros y esto con la finalidad de que queramos construir otro objeto con otro valor de atributos

            ruedas = 4;
            largo = LargoAuto;
            ancho = AnchoAuto;
        }

        public String getInfoAuto() { // como vimos anteriormente no podemos dejar los atributos publicos así que creamos un metodo para acceder a el. En este caso creamos uno para acceder a todo pero solo a la lectura de estos

            return "informacion del auto:\n " + "Ruedas: " + ruedas + "Largo: " + largo + "Ancho: " + ancho;
        }

        private int ruedas;

        private double largo;

        private double ancho;

        private bool climatizador;

        private String tapiceria;

        /*NOTA: Para concluir vemos que podemos generar más de un constructor para una clase siempre y cuando estos reciban datos diferentes que podemos crear un metodo de LECTURA con el podemos acceder a los valores de los atributos
         para no permitir que estos sean modificados indiscriminadamente como lo habíamos visto antes.*/
        

    }
}
