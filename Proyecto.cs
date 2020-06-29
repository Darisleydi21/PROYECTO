using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            int d;
            string resultado = "";
            string maquina = "";
            string jug1 = "";

            Console.WriteLine("Inserte piedra, papel o tijeras");
        
            Random rnd = new Random();
            d = rnd.Next(1, 3);

            if (d == 1)
            {
                maquina = "piedra";
            }
            if (d == 2)
            {
                maquina = "papel";
            }
            if (d == 3)
            {
                maquina = "tijeras";
            }

            jug1 = Console.ReadLine();
            if (maquina == "piedra")
            {
                if (jug1 == "piedra")
                {
                    resultado = "Empate";
                }
                if (jug1 == "papel")
                {
                    resultado = "FELICIDADES, GANASTE";
                }
                if (jug1 == "tijeras")
                    resultado = "PERDISTE, INTENTE DE NUEVO";
            }
            if (maquina == "papel")
            {
                if (jug1 == "papel")
                {
                    resultado = "Empate";
                }
                if (jug1 == "tijeras")
                {
                    resultado = "FELICIDADES, GANASTE";
                }
                if (jug1 == "piedra")
                    resultado = "PERDISTE, INTENTE DE NUEVO";
            }
            if (maquina == "tiejras")
            {
                if (jug1 == "tijeras")
                {
                    resultado = "Empate";
                }
                if (jug1 == "piedra")
                {
                    resultado = "FELICIDADES, GANASTE";
                }
                if (jug1 == "papel")
                    resultado = "PERDISTE, INTENTE DE NUEVO";
            }
            Console.WriteLine("{0} vs {1}", jug1, maquina);
            Console.WriteLine(resultado);
            Console.ReadLine();
        }
    }
}
