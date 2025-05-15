using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerpienteEscaleras
{
    internal class Program
    {   static Random azar = new Random();

        static void Main(string[] args)
        {
            int posicion1=0;
            int posicion2=0;
            string nombre1;
            string nombre2;
            bool finjuego;
            Console.WriteLine("Ingrese nombre jugador 1");
            nombre1=Console.ReadLine();
            Console.WriteLine("Ingrese nombre jugador 2");
            nombre2 = Console.ReadLine();

            int pie1 = azar.Next(1,100);
            int pie2 = azar.Next(1,100);
            int cabecera1 = azar.Next(pie1,100);
            int cabecera2 = azar.Next(pie2,100);

            
            int cola = azar.Next(1,100);
            int cabeza = azar.Next(cola,100);

            do
            {
                posicion1 = posicion1 + azar.Next(1, 7);

                if (posicion1 == cabeza)
                {
                    Console.WriteLine("1 pisaste serpiente");
                    posicion1 = cola;
                }
                if (posicion1 == pie1)
                {
                    Console.WriteLine("ESCALERA para 1");
                    posicion1 = cabecera1;
                }
                if (posicion1 == pie2)
                {
                    Console.WriteLine("ESCALERA para 1");
                    posicion1 = cabecera2;
                }
                Console.WriteLine("pocicion jugador "+ nombre1+" " + posicion1);

                //juagador 2
                posicion2 = posicion2 + azar.Next(1, 7);


                if (posicion2 == cabeza)
                {
                    Console.WriteLine(" 2 pisaste serpiente");
                    posicion2 = cola;
                }
                if (posicion2 == pie1)
                {
                    Console.WriteLine("ESCALERA para 2");
                    posicion2 = cabecera1;
                }
                if (posicion2 == pie2)
                {
                    Console.WriteLine("ESCALERA para 2");
                    posicion2 = cabecera2;
                }
                Console.WriteLine("pocicion jugador "+ nombre2+ " " + posicion2);


                finjuego = posicion1 >= 100 || posicion2 >= 100;
            } while (!finjuego);

            if (posicion1 >= 100 ^ posicion2 >= 100)
            {
                if (posicion1 >= 100)
                {
                    Console.WriteLine("ganador " + nombre1);
                }
                else
                {
                    Console.WriteLine("ganador " + nombre2);
                }
            }
            else
            {
                Console.WriteLine("no hay ganador");
            }

             
        }
    }
}

