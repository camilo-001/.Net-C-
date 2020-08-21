using System;
using System.Collections.Generic;
using System.Text;
using static System.Math; // al utilizar esto podremos usar los metodos estaticos de la clase math sin tener que especificarla al inicio


namespace Curso.OOP
{
    class AnonimClass_ImportMetodStatic
    {
        static void Main(string[] args) {

            double raiz = Math.Sqrt(9); // Así usariamos de manera habitual la clase math y sus metodos

            double potencia = Pow(4, 2); // Y así al importar todos sus metodos


            var miVariable = new { Nombre = "Camilo", Edad = 19 }; // esta es la estructura de la clase anonima 

            /*Las clases anonimas deben cumplir con la siguiente estructura 
             - Solo pueden contener campos publicos (aunque no se declare public se toma por defecto)
             - Todos los campos deben estar iniciados
             - Los campos no pueden ser static
             - No se pueden definir metodos*/

        }
    }
}
