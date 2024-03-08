using System;
using System.Drawing;
using System.Runtime.ConstrainedExecution;

namespace SolucionPersona
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona Personal=new Persona("Verdes","187","85","V");
            Console.WriteLine("Descripción de la persona: ");
            Console.WriteLine("Ojos: "+ Personal.Ojos);
            Console.WriteLine("Altura: "+ Personal.Altura);
            Console.WriteLine("Peso: "+ Personal.Peso);
            Console.WriteLine("Sexo: "+ Personal.Sexo);

            Personal.Hablar("Me llamo Borja");
            Console.WriteLine("Color de mis ojos: "+ Personal.Ojos);
            Personal.correr(1000);
            Console.WriteLine("Mi peso actual es: "+ Personal.Peso);

            //LLamando a la clase heredada
            PersonaNadadora Persona1 = new PersonaNadadora("Verdes", "187", "85", "V");
            Console.WriteLine("Descripción de la persona:"); 
            Console.WriteLine("Ojos: "+ Persona1.Ojos);
            Console.WriteLine("Altura: "+ Persona1.Altura);
            Console.WriteLine("Peso: "+ Persona1.Peso);
            Console.WriteLine("Sexo: ", Persona1.Sexo);
            Persona1.Hablar("Me llamo Borja");
            Console.WriteLine("Color de mis ojos: "+ Persona1.Ojos); 
            Persona1.correr(1000);
            Console.WriteLine("Mi peso actual es:", Persona1.Peso);
            Persona1.Nadar();
            Console.WriteLine("Tras nadar peso:", Persona1.Peso);


            //Llamando a la clase coche
            Coche miCoche = new Coche("Ford", "Fiesta", "10","100");

            miCoche.Acelerar(10);
                     


        }
    }
   public class Persona
    {

        //Metodo constructor
        public Persona(string ojos, string altura, string peso,string sexo)
        {
            this.Ojos = ojos;
            this.Altura = altura;
            this.Peso = peso;
            this.Sexo = sexo;
        }

        public string Ojos;
        public string Altura;
        public string Peso;
        public string Sexo;
        public void Hablar(string texto)
        {
            // Se muestra la conversación a decir
            Console.WriteLine("Voy a decir:" + texto);
        }
        public void Comer(double calorias)
        {
            // Se indican las calorías que se ganan al comer
            Console.WriteLine("Ganando" + calorias + "Calorias");
            this.Peso += calorias / 1000;
        }
        public void correr(double calorias)
        {
            // Se indican las calorías que se pierden al correr
            Console.WriteLine("Perdiendo" + calorias + " calorías"); 
            this.Peso = Convert.ToString(calorias/1000);
           
        }
    }
    public class PersonaNadadora:Persona
    {
        public PersonaNadadora(string ojos, string altura, string peso, 
            string sexo) : base(ojos, altura, peso, sexo) {
        }
        public void Nadar()
        {
            //La práctica de la natación hará volver al peso inicial
            Console. WriteLine ("Nadando para volver al peso ideal") ;
            this.Peso = "85";
        }
    }
}
