using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.Metodos
{
    class Metodos
    {
        static void Main(string[] args) {

            int numero1 = 34;
            int numero2 = 36;


            DecirHola(); // llamamos al metodo

            SumaNumeros(2,4); // llammos al metodo el cual recibe dos parametros y hemos pasado los parametros por valor 


            SumaNumeros(numero1, numero2); // ahora hemos llamado al metodo y hemos pasado los parametros por referencia


        
        }

            // decalramos nuestro metodo. El metodo tenemos que declar el metodo statico para que nos arroje error

            static void DecirHola() { // este es un ejemplo de metodo que no recibe parametros 

                Console.WriteLine("hola mis amigs");


            }


             static void SumaNumeros(int num1, int num2) { // en este metodo hemos definido que debe recibir dos parametros para realizar su codigo

            int Sum = num1 + num2; // aca definimos la operación que se hara con esos dos parametros que recibira el metodo

            Console.WriteLine("La suma de los numeros es: " + Sum); // imprimimos esa variable sum que es la que nos arroja el resultado 
        
                }


        // Estos metodos que hemos realziado son metodos los cuales no retornan ningun valor por eso es que en su definicion hemos usado el " void " más adelante veremos los que si han de retornar valores
    } 
            



}