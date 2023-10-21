using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Object_3D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using(var game = new Game(800, 600))
            {
                

                bool exit = false;
                do
                {
                    Console.WriteLine("Opciones, ¿qué desea hacer?:");
                    Console.WriteLine("1. Rotar");
                    Console.WriteLine("2. Escalar");
                    Console.WriteLine("3. Trasladar");
                    Console.WriteLine("0. Salir");

                    string input = Console.ReadLine();
                    int option;
                    if (int.TryParse(input, out option))
                    {
                        switch (option)
                        {
                            case 1:
                                game.isRotating = true;
                                game.Run(60);
                                break;
                            case 2:
                                game.isScaling = true;
                                game.Run(10);
                                break;
                            case 3:
                                game.isTranslating = true;
                                game.Run(10);
                                break;
                            case 0:
                                exit = true;
                                break;
                        }
                    }
                } while (!exit);
            }
        }
    }
}
