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
            


        }
 
     }

    class Empleados {

        string nombrePersona;


        public Empleados(string nombre) {

            nombrePersona = nombre;

        }

        public void Trabajo() {

            Console.WriteLine("Trabajo en la empresa");
        }

        public void Carnet() {

            Console.WriteLine("Poseo un carnet para poder ingresar");
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

