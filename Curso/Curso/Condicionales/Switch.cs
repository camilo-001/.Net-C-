using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.Condicionales // condicional switch
{
    class Switch
    {
        static void Main(string[] args) {

            Console.WriteLine("Elige un medio de transporte (carro, barco, avion)");

            string medioTransporte = Console.ReadLine();

            switch (medioTransporte)
            {

                case "carro":
                    Console.WriteLine("velocidad media");
                    break;

                case "barco":
                    Console.WriteLine("velocidad media-alta");
                    break;

                case "avion":
                    Console.WriteLine("Velocidad muy alta");
                    break;

                default:
                    Console.WriteLine("Ha ingresado una opcion no valida");
                   break;


            }
        
        }
    }
}
