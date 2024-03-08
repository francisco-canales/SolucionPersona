using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionPersona
{
    internal class Coche
    {
        //Atributos
        string Marca;
        String Modelo;
        String VelocidadMaxima;
        String VelocidadActual;
        //Constructor
        public Coche(string marca,string modelo,string velocidadmaxima,string velocidadactual)
        {
            
        }
        //Metodos
        public void Acelerar(int aceleracion)
        {
            aceleracion += 5;
            Console.WriteLine("Acelerando de 5 en 5"+ aceleracion);
            Console.ReadKey();


        }

        public void Decelera(int deceleracion)
        {
            deceleracion -= 5;
            Console.WriteLine("Acelerando de 5 en 5" + deceleracion);
            Console.ReadKey();


        }
    }
}
