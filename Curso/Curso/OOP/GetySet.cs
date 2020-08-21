using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.OOP
    /* Getters Y Setters || Seguiremos con el ecodigo del OppConstruc. En el codigo anterior se hizo uso de un getter ahora veremos como usar el
     setter. Tambien en el codgio anterior no usamos las propiedades climatizador ni tapiceria*/
{
    class GetySet
    {
        static void Main(String[] args)
        {


            Auto Carro1 = new Auto();  

            Auto Carro2 = new Auto(); 

            Auto carro3 = new Auto(45.6, 126.9); 

            Console.WriteLine(Carro1.getInfoAuto());

            carro3.setExtras(true, "Cuero"); // entonces establecemos que el carro 3 si posee los extras de climatizador y tapiceria 

            Console.WriteLine(carro3.getInfoAuto());

            Console.WriteLine(carro3.getExtras()); // us<mos el metodo getExtras para leer los datos extras que posee el carro 3

        }
        class Auto
        {
           
            public Auto()
            { 

                ruedas = 4;
                largo = 2300.5;
                ancho = 0.800;
            }

           
            public Auto(double LargoAuto, double AnchoAuto)
            {

                ruedas = 4;
                largo = LargoAuto;
                ancho = AnchoAuto;
            }

            public String getInfoAuto()
            {

                return "informacion del auto:\n " + "Ruedas: " + ruedas + "Largo: " + largo + "Ancho: " + ancho;
            }

            /*Los setters getters por lo general se crean en grupo en este caso debemos crear un get y un set para leer la informacion de los extras 
             usamos el set para establecer que carros tienen estos extras porque no todos los tienen por eso no establecimos valores para estos en el
            constructor por lo cual debemos establecer valores para estos entonces usamos un metodo set */
            public String getExtras() {

                return "Información extra de los carros: \n " + "Climatizador: " + climatizador + "\n Tapiceria: " + tapiceria;
            
            }
            public void setExtras(bool climatizador, String tapiceria) {

                this.climatizador = climatizador; // el uso del this es para diferenciar entre un campo de clase y un parametro. Donde el que usa el this es el campo de clase

                this.tapiceria = tapiceria; 
            
            }

            private int ruedas;

            private double largo;

            private double ancho;

            private bool climatizador;

            private String tapiceria;

            


        }
    }
}
