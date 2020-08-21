using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.Metodos
{
    class Metodos2
    {

        private static void Main(String[] args) {


            Console.WriteLine(SumandoNUmeros(12, 23)); // Llamamos el metodo pero para poder visualizar el resultado debemos llamarlo dentro de un console
        
   
        }

        static int SumandoNUmeros(int num1, int num2) {// Colocamos el int a diferencia de void debido a que este metodo debe dolvernos un valor de tipo int

            return num1 + num2; // debemos colocar el return porque como dijimos este metodo debe devolvernos un valor y ese valor es la suma de esos dos parametros
        
        } // Como anotacion debemos saber que le metodo puede funcionar si hubiesemos colcoado al inicio de este en lugar de int colocaramos double, pero la idea es mantener una relación de tipos de datos
    }
}
