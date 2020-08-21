using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.Condicionales
{
    class If1 // los condiciones se manejan de manera habitual como en java tanto como los anidados

    {
        private static void Main(String[] args)
        {
            string carnet2 ="";

            Console.WriteLine("Introduce tu edad por favor");

            int edad = int.Parse(Console.ReadLine());

            if (edad >= 18)
            {

                Console.WriteLine("si tienes licencia pon si de lo contrario pon no");
                string carnet = Console.ReadLine();

                if (carnet == "si")
                {
                   

                    Console.WriteLine("puedes conducir");

                }
                else if (carnet == "no"){

                    
                    Console.WriteLine("no puedes conducir");
                }

                else Console.WriteLine("insertaste un valor no valido");

            }
            else Console.WriteLine("debes ser mayor de edad para poder conducir");

           
        }


    }
}

