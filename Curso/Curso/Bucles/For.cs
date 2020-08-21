using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace Curso.Bucles
{
    class For
    {
    

        public static void Main(String[] args) {

            var valores = new[] { 15, 46, 20, 30.56,45 };

        // usaremos el bucle for para recorrer el array
         for(int i=0; i<5;i++){

                Console.WriteLine(valores[i]);
            
            }
         /*Usarmos el bucle for para leer un arreglo de objeto*/

            Empleados[] arrayEmpleados = new Empleados[2];

            arrayEmpleados[0] = new Empleados("Laura", 23);
            arrayEmpleados[1] = new Empleados("Victor", 34);

            for (int i = 0; i < arrayEmpleados.Length; i++) {

                Console.WriteLine(arrayEmpleados[i].getInfoEmpleados());

                //TODO
            }
        }

        class Empleados
        {
            String Nombre;
            int Edad;

            public Empleados(String Nombre, int Edad) {

                this.Nombre = Nombre;
                this.Edad = Edad;
            

            
            }
          public String getInfoEmpleados()
        {

                return "Nombre del Empleado: " + Nombre + "Edad: " + Edad;


        }

        }


      
    }


}
