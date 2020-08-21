 using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.Excepciones // Captura de Excepciones con filtros
{
    class Excep2

    {
        static void Main(string[] args)
        {  


            Random numero = new Random();

            int aleatorio = numero.Next(0, 100); 

            int minumero;

            int intentos = 0;

            Console.WriteLine("Introduce un numero entre 0 y 100");

            do
            {

                intentos++; 

                try 
                {
                    minumero = int.Parse(Console.ReadLine());
                }
                catch (Exception ex) when (ex.GetType() != typeof(FormatException)) /* Usualmente no podemos utilizar en el cathc una excepcion generalziada antes que una especifica lo que debemos hacer
                                                                                     es utilziar una condicion en esa captura generalizada filtrandola para indicarle que no queremos que trate una excepcion
                                                                                     en especifico en este caso la excepcion de formato ya que esta la trataremos nosotros de manera especial*/
                { 

                    Console.WriteLine("Se ha producido un error. Debido a esto se tomara el numero introducido como 0");
                    minumero = 0; 
                }
                catch (FormatException ex)
                { 
                    Console.WriteLine("Has introducido un valor que no corresponde a un numero. Debido a esto se tomara el numero introducido como 0");
                    minumero = 0;
                }

                if (minumero > aleatorio) Console.WriteLine("el numero es más bajo");
                if (minumero < aleatorio) Console.WriteLine("el numero es más alto");



            } while (aleatorio != minumero);

            /*De esta forma podríamos usar una excepcion generalizada en nuestro codigo siempre y cunado esta sea posible y no genera una mala lectura o adminsitración de nuestro codigo*/

            Console.WriteLine("Encontraste el numero correcto en:  " + intentos + "intentos");

            Console.WriteLine("Que sigue perro");



        }
    }
}
