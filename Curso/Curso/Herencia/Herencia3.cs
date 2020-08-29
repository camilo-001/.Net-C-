using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.Herencia
{

    // TALLER 
    class Herencia3
    {
        static void Main(String[] args) {

            Avion yeiyei = new Avion("ModeloB2");
            Carro McQueen = new Carro("ModeloV11");
            yeiyei.ArrancarMotor();
            yeiyei.Conducir();
            yeiyei.getModelo();
            McQueen.ArrancarMotor();
            McQueen.Conducir();
            McQueen.getModelo();


        }
   
    }




    class Automovil {

        public string ModeloMotor;

        public Automovil(string Nombre) {

            ModeloMotor = Nombre;
        }

        public void ArrancarMotor() {

            Console.WriteLine("Arrancando el Motor");
        }

        public void DetenerMotor() {

            Console.WriteLine("Detieniendo el Motor");

        }

        public virtual void Conducir() {

            Console.WriteLine("El vehiculo está siendo conducido");
        
        }

        public void getModelo() {

            Console.WriteLine("El modelo del motor del Vehiculo es : "+ ModeloMotor);
        }

    }


    class Avion : Automovil {

        public Avion(string ModeloMotorAvion) : base(ModeloMotorAvion) {

        }

        override public void Conducir(){
            Console.WriteLine("El Avion está siendo Piloteado");
        }

        public void ProbandoControles() {

            Console.WriteLine("Se estan probando los controles de vuelo");
        }
    }

    class Carro : Automovil {

        public Carro(string ModelorMotorCarro) : base(ModelorMotorCarro) { 
        }
    }


}




