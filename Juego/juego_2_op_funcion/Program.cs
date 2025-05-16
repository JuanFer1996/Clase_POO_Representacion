using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juego_2_op_funcion
{
    internal class Program
    {
        static Random azar = new Random();
        static int posicion1,posicion2,pie1,pie2,cabecera1,cabecera2,cola,cabeza;
        static string nombre1,nombre2;
        static bool finjuego=false;

        static int AvanceJugador(int posicion, string nombre)
            {
            posicion = posicion + azar.Next(1, 7);

            if (posicion == cabeza)
            {
                Console.WriteLine(nombre + " pisaste serpiente");
                posicion = cola;
            }
            if (posicion == pie1)
            {
                Console.WriteLine("ESCALERA para "+nombre);
                posicion = cabecera1;
            }
            if (posicion == pie2)
            {
                Console.WriteLine("ESCALERA para "+nombre);
                posicion = cabecera2;
            }

            Console.WriteLine("Jugador "+nombre+" - Posición: " + posicion);
            return posicion;
        }

        static void Main(string[] args)
        {
            #region Iniciar posicion jugador 1 y 2
            posicion1 = 0;
            posicion2 = 0;
            #endregion

            #region solicitar nombre jugador 1 y 2
            Console.WriteLine("Ingrese nombre jugador 1");
            nombre1 = Console.ReadLine();
            Console.WriteLine("Ingrese nombre jugador 2");
            nombre2 = Console.ReadLine();
            #endregion

            pie1 = azar.Next(1, 100);
            pie2 = azar.Next(1, 100);
            cabecera1 = azar.Next(pie1, 100);
            cabecera2 = azar.Next(pie2, 100);


            cola = azar.Next(1, 100);
            cabeza = azar.Next(cola, 100);

            do
            {
                posicion1 = AvanceJugador(posicion1,nombre1);
                posicion2 = AvanceJugador(posicion2,nombre2);   

                finjuego = posicion1 >= 100 || posicion2 >= 100;

            } while (!finjuego);

            #region Determinar ganador
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
            #endregion

        }
    }
    
}
