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
                game.Run();
            }
        }
    }
}
