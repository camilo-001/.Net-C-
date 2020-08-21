using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.Bucles
{
    class DoWhile // a diferencia del while el do while nos garantiza la entrada al codigo una vez
    {
        private static void Main(string[] args)
        { // reutilizaremos el ejemplo anterior del DoWhile

            Console.WriteLine("A continuacion entrara definir su medio de transporte");

            string iterador;
            string medioTransporte;

            do
            {
                Console.WriteLine("¿Desea usted iniciar ahora? Escriba 'si' si desea iniciar y 'no' si no lo desea");

                iterador = Console.ReadLine();

                if (iterador == "si")
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
                    if (iterador == "no")
                    {
                        Console.WriteLine("gracias vuelva pronto");
                    }
                }
                else { Console.WriteLine("gracias vuelva pronto"); }

            } while (iterador != "no");

            Console.WriteLine("¿podemos ayudarle en algo más?");


        }
    }
}

