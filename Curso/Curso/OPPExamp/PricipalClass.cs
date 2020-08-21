using System;
using System.Collections.Generic;
using System.Text;
 /*En este apartado en la carpeta que hemos creado se encontrarran dos clases las cuales nos servirán para realizar un ejemplo de como realizar llamadas de clases
  que se encuentren en otro fichero es decir en este ejemplo usaremos metodos que se encuentran en la clae Punto e implementaremos estos metodos para realizar un 
 ejemplo matematico para como ejemplo de como realizar estas llamadas.*/

namespace Curso.OPPExamp

{
    class PricipalClass
    {
        static void Main(String[] args) {

            realizarTarea(); // llamamos el metodo realzar tarea
        
        }

        static void realizarTarea()
        {
            

            Punto destino = new Punto(23,4); // creamos un objeto/estancia de un tipo de clase que se encuentra en otro fichero 

            Punto origen = new Punto(); // En la clase punto tenemos dos constructores por si se quisiera tener un objeto en el cual no enviaramos parametros

            Punto otroPunto = new Punto();

            double distancia = origen.DistanciaHasta(destino);

            Console.WriteLine($"la distancia entre los puntos es de: {distancia}");

             Console.WriteLine($"Numero de objetos creados: {Punto.ContadorDeObjetos()}");

            /* Como el metodo como la varibale son de tipo static solo pueden ser llamados con la clase en este caso la clase punto. Recordemos que la variable y el metodo
             fueron creados para contar cuantos objetos fueron creados es decir con el static puesto en ese metodo no podriamos usarlos con otro objeto solo con la clase como
            vemos en el console Wtriteline
            */

           

           
        }
    }


}
