using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.Arrays_Arreglos
{ /* A diferencia del codigo anterior aca vemos como un metodo devuelve una array*/
    class ArrayByParametros2
    {
        static void Main(String[] args) {

            int[] arrayElementos = LeerDatos(); // almacenamos en la arrayElementos lo que el metodo LeerDatos devuelve que es un array 


            foreach (int i in arrayElementos) { // creamos el foreach para la lectura de la array

                Console.WriteLine(i);
            }
        }

        static int[] LeerDatos() {

            Console.WriteLine("¿Cuantos elementos quieres que tenga el array?"); // indicamos al usuario que siga cuantos datos almacenara el array

            string respuesta = Console.ReadLine(); //almacenamos la respuesta que el usuario digita     

            int numElementos = int.Parse(respuesta); // tenemos que convertir el tipo de dato

            int[] datos = new int[numElementos]; // ahora creamos la array e indicamos que esta tendra como longitud lo digitado por el usuario

            for (int i = 0; i < numElementos; i++) { // creamos el bucle for para ir llenando las posiciones de la array con lo que el usuario digite

                Console.WriteLine($"introduce el dato para la posicion{i}"); // le indicamos al usaurio que quiere introducir en la posicion de la array

                respuesta = Console.ReadLine(); // almacenamos lo digitado por el usuario 

                int datosElemento = int.Parse(respuesta); //convertimos el tipo de dato

                datos[i] = datosElemento; // y almacenamos el valor en la posicion correspondiente del array datos


            }
            return datos; // indicamos que retornamos la array datos
        }
    }
}
