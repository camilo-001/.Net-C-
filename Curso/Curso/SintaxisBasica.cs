using System; /* Esta sentencia nos indica que estamos usando el namesapce "System" en el cual vienen almacenadas clases predefinidas en el propio lenguaje 
               lo que quiere decir que si quisieramos usar la clase predefinida "Console" la cual esta almacenada en el namespace de System sin haber declarado
               el uso de este namesapce nos arrojaria un error ya que no encuentra donde se ha defindido la clase Console, pero si quisieramos usar la clase 
                Console sin haber definido el uso de System tendriamos que anteponer en Console la palabra "System." --> System.Console*/


// C# es un lenguaje fuertemente tipado y case sensitive al igual que java

namespace Curso
{
    class SintaxisBasica
    {
        static void Main(string[] args) // Metodo main
        {
            // Console.WriteLine("Hello World!"); // usar el Console.WriteLine imprime un mensjae en consola

            // la delcaracion de variables se hace de la manera habitual 

            int edad; // empezando por el tipo de dato y luego con el nombre de la variable donde si quisieramos podriamos inicializarla

            edad = 28; // O luego asignarle el valor despues de haberla definido 

            const int VALOR = 5; // Con las constantes no es del todo igual una constante debe ser inicializada a penas se ha declarado 

            Console.WriteLine(edad); // imprimos la variable

            /*

             // CONVERSIONES

             //Conversion Explicita

             //casting, se denomina a una variable que almacena un tipo de dato diferente al que intentamos almacenar en ella y se debe convertir



             double Temperatura = 34.5;
             int TemperaturaBogota;

             TemperaturaBogota = (int)Temperatura; // para poder realizar el casting debemos anteponer el tipo de dato al cual deseamos convertir la variable

             Console.WriteLine(TemperaturaBogota); // al imprimir la variable TempraturaBogota vemos como el valor no es 34.5 sino 34 solamente ya que pasamos de un tipo de dato decimal a uno entero

             //Conversion Implisita 
             // esta presente cuando pasamos de un tipo de datoa otro tipo de dato pero que se encuentra en su misma caterogoria pero de diferente alcance

             float HabitantesCiduad = 7.456F;

             double HabitantesDeCiudad2019 = HabitantesCiduad;



             */





            /* recuerda eliminar las /* para quitar el codigo de comentario


            //Convertir de un tipo de dato de texto o cadena de caracteres a un tipo de dato numerico

            Console.WriteLine("Introduce un el primer numero"); // vamos a pedirle al usuario que ingrese los numeros por consola

            int num1 = int.Parse(Console.ReadLine()); // con Console.ReadLine podemos permitirle al usuario ingresar valores por consola 

            Console.WriteLine("Introduce el siguiente numero");

            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("El resultado es " + (num1 + num2)); /* El usuario a dijitado dos numeros y hemos convertidos estos que estaban con un tipo de dato por defecto string a un tipo numerico
                                                                    esto no quiere decir que no se generen excepciones debido a que el usuario pueda digitar algo que no sea un numero este tipo de 
                                                                    conversiones pueden llevarse a cabo siempre y cuando sea posible realizar lo solicitado *
            
            
             
             */


            /*
             
             //Clase Math 

            const double PI = 3.1416;

            Console.WriteLine("Indtroduce la medidad del radio");

            double radio =double.Parse(Console.ReadLine());

            double area = (Math.Pow(radio, 2))* PI;

            Console.WriteLine("El area es: "+ area);
         

            int numero1 = 9;

            double raiz = Math.Sqrt(numero1);
            Console.WriteLine(raiz);

             */

    


        }
    }
}
