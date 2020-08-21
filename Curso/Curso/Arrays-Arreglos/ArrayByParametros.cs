using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.Arrays_Arreglos
{
    class ArrayByParametros /*Enviaremos una array como parametro para ser usada como metodo */
    {
        static void Main(String[] args) {

            int[] numeros = new int[4]; // creamos nuestra array definiendo lo que contiene manualmente

            numeros[0]= 4;
            numeros[1] = 14;
            numeros[2] = 54;
            numeros[3] = 34;

            ProcesaDatos(numeros); // llamamos a nuestro metodo y enviamos la array numeros como parametro a nuestro metodo

            foreach (int i in numeros) { // usamos el ciclo for each para leer la array: recordar que se usa el ciclo foreach solo para lectura

                Console.WriteLine(i);

                //TODO
            }

        }

        static void ProcesaDatos(int[] datos) { // primero creamos nuestro metodo en el cual definimos que recivira una raid como paramentro y no retornará nada solo procesara datos

            for (int i = 0; i < datos.Length; i++) { /* definimos el bucle for para indicar que se le suamara a cada posicion de la array 10 
                                                      pero esta array es la que reciviremos como parametro. Recordar que el ciclo for nos permite
                                                      modificar datos de un array a diferencia del each ya que ese solo nos ayuda a leer datos */

                datos[i] += 10;
            
            }
        
        }


    }
}
