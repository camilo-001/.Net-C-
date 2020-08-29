 using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.Herencia
{
    class Herencia2
    {
        /*En este ejemplo veremos el uso de palabras reservadas "new" "virtual y "override"*/
        static void Main(string[] args) {

            Director directorgeneral = new Director("manuel");
            Secretaria secretariagerencia = new Secretaria("juanita");

            secretariagerencia.getNombrePersona();
            secretariagerencia.Trabajo();
             secretariagerencia.Carnet();
            secretariagerencia.LLamadas();
            
            directorgeneral.Reuniones();
            secretariagerencia.Reuniones();



        }
 
     }

    class Empleados {

       private string nombrePersona; // private = encapsulada 


        public Empleados(string nombre) {

            nombrePersona = nombre;

        }

        public void Trabajo() {

            Console.WriteLine("Trabajo en la empresa");
        }

        public void Carnet() {

            Console.WriteLine("Poseo un carnet para poder ingresar");
        }

        public virtual void Reuniones() {
        /* Hemos tomado este metodo y lo hemos copiado de la clase hija director, pero hemos agregado 
        la palabra virtual y esto quiere decir que todos las clases que hereden de empleados tendran 
         este metodo y que si alguna otra clase tiene este metodo como propio y con modificaciones como
         en el caso de la clase Director que tiene su propio metodo Reuniones entonces ese metodo será
        independiente del de la clase padre Empleados y cunado queramos usar ese metodo dentro de la clase
        director mostrar un mensaje diferente al de la clase empleados */


            Console.WriteLine("Asisto a reuniones");
        }

        public void getNombrePersona() {

            Console.WriteLine("El Nombre de la persona es :  "+nombrePersona);
        
        }
    }



    class Director : Empleados {

        public Director(string NombreDirector) : base(NombreDirector) { 
        
        }

        public void Decisiones() {

            Console.WriteLine("soy el unico que puede tomar decicisones importantes de la empresa ");
        }

        override public void Reuniones() { /* como vemos este metodo propio de la clase director tambien lo tenemos en la superclase
                                   si no anteponemos la palabra override en este metodo visual nos mostrará una advertencia y con la 
                                    palabra override indicamos que este metodo es una modificación del original */

            Console.WriteLine("Puedo asistir a reuniones ");
        }


    }

    class Secretaria: Empleados
    {
        public Secretaria(string NombreSecretaria) : base(NombreSecretaria) { 
        
        }

        public void LLamadas() {

            Console.WriteLine("soy la unica persona que puede recibir llamadas importantes");

            
        }


    }



}

