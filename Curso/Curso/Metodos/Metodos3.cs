using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.Metodos
{
    class Metodos3 // SOBRE CARGA DE METODOS 
    {
        private static void Main(String[] args) {
            Console.WriteLine(SumarNumeros(3,4)); // realizamos el llamado de la clase pero como ven solo enviamos dos parametros y automaticamente tomara el metodo correspondiente 
            Console.WriteLine(SumarNumeros(4,5,7)); // lo mismo sucede en esta hemos llamado el metodo pero enviamos 3 parametros y automatcamente toma el metodo correspondiente 
            Console.WriteLine(SumarNumeros(5.6,6)); // al igual que aca 
           
        
        
        
        }


        static int SumarNumeros(int numero, int numero2) => numero + numero2; //Creamos nuestro metodo el cual recibe dos parametreos enteros   

        static int SumarNumeros(int operador1, int operador2, int operador3) => operador1 + operador2 + operador3; // Aca hemos creado otro metodo con el mismo nombre del anterior solo qe este recibe 3 parametros

        static double SumarNumeros( double caracter1, int caracter2) => caracter1 + caracter2; // hemos hecho lo mismo pero en este caso recive y retorna un double y suma un entero

        /*La sobre carga de metodos es tomar un metodo bajo el mismo nombre y crear varios con este mismo solo que cambian sus parametros en cada uno para efectos de cuando llamemos el metodo
         y pueda que los parametros que le enviemos sean diferentes solo tengamos que llamar un metodo aun que existan diferentes versiones de este
        */




    }
}
