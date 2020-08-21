using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.Bucles // blucle indeterminado While
{
    class BucleWhile
    {
       private static void Main(string[] args) {

            Console.WriteLine("A continuacion entrara definir su medio de transporte");

            Console.WriteLine("¿Desea usted iniciar ahora? Escriba 'si' si desea iniciar y 'no' si no lo desea");

            string iterador = Console.ReadLine();
            string medioTransporte;



            while (iterador != "no")
            {
                Console.WriteLine("Elige un medio de transporte (carro, barco, avion)");

                medioTransporte = Console.ReadLine();

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


                Console.WriteLine("¿Desea continuar consultando? si es así escriba 'si' de lo contrario escriba 'no'");
                iterador = Console.ReadLine();

  
            }if (iterador == "no") {
                    Console.WriteLine("gracias vuelva pronto");
                }

        }
    }
}
 