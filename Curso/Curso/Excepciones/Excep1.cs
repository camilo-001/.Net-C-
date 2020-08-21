using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.Excepciones // Ejemplo de como se pueden manejar las excepciones 
{
    class Excep1
    {
        static void Main(string[] args) {  //Creamos un codigo donde el sistema cree un numero random del 1 al 100 y tendremos que advinarlo ingrsando numeros en consola


            Random numero = new Random(); // creamos nuestra variable numero la cual recibe el numero generado por el sistema

            int aleatorio = numero.Next(0, 100); // el numero debera sér entre 0 y 100

            int minumero;

            int intentos = 0;

            Console.WriteLine("Introduce un numero entre 0 y 100");

            do {

                intentos++; // aumentaremos en un 1 los intentos por cada vez que nos equivoquemos 

                try // en el bloque de try debemos colocar lo que tratará de hacer el codigo en caso de fallar o presentarse un error o expeción se pasará al catch
                {
                    minumero = int.Parse(Console.ReadLine()); /*Aca es donde podremos ver una excepcion no controlada a menos que no este en un bloque try catch ya que en cualquier
                                                           momento el usuario puede ingresar un valor que el int.Parse no pueda convertir a entero */
                }
                catch (FormatException ex)
                { // debemos definir de que tipo es la excepcipon y en este caso es una de formato y declaramos una variable para dicha excepcion (ex)

                    Console.WriteLine("No has indtroducido un valor numerico valido. Debido a esto se tomara el numero introducido como 0");
                    minumero = 0; // si usamos el try el valor de la variable mi numero quedaría vacía en el caso que el usuario introdusca ml el valor asi que debemos asignar un valor si esto sucede
                }
                catch (OverflowException ex) { /* en nuestro codigo puede generarse más de una sola excepcion por lo cual es posible crear dos o más catchs junto con un solo try en este caso
                                                el usuario podría ingresar un valor demasiado grande por lo que se genera una excepcón de tipo OverflowException */
                    Console.WriteLine("Has introducido un valor extremdamente grande que no solo sobre pasa el rango. Debido a esto se tomara el numero introducido como 0");
                    minumero = 0; 
                }
                
                if (minumero > aleatorio) Console.WriteLine("el numero es más bajo");
                if (minumero < aleatorio) Console.WriteLine("el numero es más alto");



            } while (aleatorio != minumero); 

            /*De momento logramos que el programa no se caiga que continue su funcionamiento en llegado caso que el usaurio ingrese un valor por error que no concuerda con el tipo de dato de asignado o
             ingrese un valor demasiado grande. Por esa razón hemos creado dos catchs aun que hubiesemos podido crear una excepcion más generica usando la excepcion 'Exception' la cual podría cubrir 
            cualquier tipo de excepcion que se presente en nuestro codigo pero esto es considerado como una mala practica.*/

            Console.WriteLine("Encontraste el numero correcto en:  "+intentos+"intentos");

            Console.WriteLine("Que sigue perro");


        
        }

    }

}

