using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.Arrays_Arreglos
{
    class Array1
    {
        
        public static void Main(String[] args) {

            int[] edades = { 15, 34, 67, 90 }; // delcaracion de array e inicialización 

            Console.WriteLine(edades[2]);

            //Array Implicitos

            var datos = new[] { "miguel", "juan", "Neil" };

            /* segun los datos que ingreses la array será de ese tipo en este caso al ser string no podemos ingresar de otro tipo de dato*/

            var valores = new[] { 12, 45, 67, 9.54 };

            /*En este caso si se puede porque c# puede determinar el tipo de dato de la array como double al ver que un dato lo es ya que ambo
             tipos de dato int y doube son de tipo numerico */

            //Array Objetos || en este existe dos formas de acerlo

            Empleados Ana = new Empleados("Ana",23); // creacion objeto ana
            
            Empleados[] arrayEmpleados = new Empleados[2]; // creacion array

            arrayEmpleados[0] = new Empleados("Sara", 37); // una de las formas es almacenar el objeto es creando mientras se almacena

            arrayEmpleados[1] = Ana; // y la otra es habiendo creado el objeto y despues almacenarlo


            //Array de tipos o clases anonimas

            var personas = new[] {

            new{Nombre ="juan", Edad=19},

            new{ Nombre = "carlos", Edad=23},

            new {Nombre = "luisa", Edad =30},
            };
        }
    }

    class Empleados {
        String nombre;
        int edad;

        public Empleados(String nombre, int edad) {

            this.nombre = nombre;
            this.edad = edad;
        
        }
    
    }
}
