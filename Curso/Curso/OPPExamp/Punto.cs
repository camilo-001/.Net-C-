using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.OPPExamp
{
    class Punto
    {
        private int x, y;
        private static int contadorDeObjetos = 0;

        /*Cunado declaramos una variable static esta pasa a pertenecer solamente a la clase donde fue declarada. Cuando una variable se declara
         en una clase y no se especifica el modificador de accesos static de esa clase se hacen copias para los objetos que la utilicen es decir
         que el objeto tiene su propia version de la variable pero con static eso no sucede los objetos no usarían una version de la variable usan
         el valor de la variable en sí*/

        public Punto(int x, int y) { // hemos creado un constructor donde recibe dos parametros de tipo entero 

            this.x = x; // el this hace referencia a la clase donde estamos 
            this.y = y;
            contadorDeObjetos++;
        }


        public Punto() { // hemos creado un nuevo constructor (sobre carga) por

            this.x = 0;
            this.y = 0;
            contadorDeObjetos++;
        }

        public double DistanciaHasta(Punto otroPunto) { // en este caso recive como parametro un objeto de tipo punto

            int xDif = this.x - otroPunto.x;
            int yDif = this.y - otroPunto.y;

            double distanciaPuntos = Math.Sqrt(Math.Pow(xDif, 2) + Math.Pow(yDif, 2));

            return distanciaPuntos;

        }

        public static int ContadorDeObjetos() { // creamos este metodo que es statico tembién para poder acceder a la variable contgadorDeObjetos 

            return contadorDeObjetos;
        }
    }
}
