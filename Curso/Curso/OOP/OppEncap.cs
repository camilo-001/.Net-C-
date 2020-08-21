using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.OOP
{
    class OppEncap /*En esta ejemplo veremos como poder manejar el encapsulamiento en un ejemplo de conversor de monera basico*/
    {
        private static void Main(String[] args) {

            ConversorPesoDolar plata = new ConversorPesoDolar();

            Console.WriteLine("¿quieres cambiar el valor del dolar? si es así ingresa ' si ' de lo contrario ' no '");

            string Operador = Console.ReadLine();

            switch (Operador) {

                case "si":

                 plata.CambiarValorDolar(0);
               
                 Console.WriteLine(plata.convertirDolarPeso(0));
                break;
                
                 case "no":

                 Console.WriteLine(plata.convertirDolarPeso(0));
                 
                break;

                default:
                    Console.WriteLine("Ha ingresado una opcion no valida");
                break;

            }

        }

        class ConversorPesoDolar{ // creamos una clase para convertir dolares a pesos

            double dolar = 3.200f; /* este es el valor estandar del dolar si */

            public double convertirDolarPeso(double cantidad) {

                Console.WriteLine("ingresea la cantidad de dolares que quieres convertir a persos");

                cantidad = float.Parse(Console.ReadLine());

                return cantidad * dolar;


            }

            /*bien sabemos que el valor del dolar puede cambiar entonces esta debe ser modificado pero no podemos dejar accesible la var dolar ya que si en 
             llegado caso esta llega a ser modificada ya sea mal intencionadamente o por error por valores negativos tendremos un error en el programa para eso vamos a crear un metodo accesor para 
            moficiar la variable. Este metodo debe estar en la misma clase conversorPesoDolar*/

            public void CambiarValorDolar(double nuevoValor) { // creamos nuestro metodo accesor el cual es void porque no retorna nada
                Console.WriteLine("Por favor ingrese el nuevo valor del dolar");

                nuevoValor = double.Parse(Console.ReadLine()); // pedimos que se ingrese el nuevo valor

                if (nuevoValor < 0) // y aca es donde podemos controlar que este llegue a tomar un valor negativo si es asi el valor del dolar se mantiene 
                {

                    Console.WriteLine("el valor ingresado para el cambio de precio esta errado. Se tomara el valor por default");
                    dolar = 3.200f;

                }
                else // si el valor del dolar nuevo no es negativo entonces que se asigne a dolar el valor de la variable nuevo valor
                {
                  dolar = nuevoValor;
                }

                // ahora bien podemos si queremos cambiar el valor de la variable dolar sin colocar a esta public por medio de un metodo accesor verificar en la parte inicial del codigo y retira las barras para que deje de ser comentario
            
            

            }



        }
    }
}
