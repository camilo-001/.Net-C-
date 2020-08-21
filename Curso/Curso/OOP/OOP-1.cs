using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.OOP // como vrear objetos basados en una clase. En este ejemplo veremos eso
{
    class OOP_1
    {       /*  En esta parte veremos como crear un objeto a partir de una clase    */
        private static void Main(String[] args) {

            Circulo Micirculo; // creacion de objeto de tipo Circulo

            Micirculo = new Circulo(); // iniciacion de variable / objeto de tipo de Circulo. Instanciar una clase

            Console.WriteLine(Micirculo.CalculoArea(5)); // asi podremos visualizar el valor que retorna el cosdigo al usar el metodo en nuestro objeto Micirculo
             

        }
    }

    public class Circulo {

      private double Pi = 3.1416; // propeidad de clase circulo o campo de clase
        // las propiedades pueden ser cambiadas dentro del objeto es decir asignarle un valor diferente a menos que las definamos como const = constantes
        // las ENCAPSULACIONES normalmente se hacen usando el private y así podemos evitar que metodos o propiedades sean usadas fuera de una clase como en este caso PI
         

       public double CalculoArea(int radio) // Metodo de clase (comportamiento de clase)
            // debemos definir el metoo de acceso para este metodo ya que si no lo hacemos publico no podremos usarlo en nuestros objetos creados
        {
         return Pi * Math.Pow(radio, 2);
        }


    }

}
