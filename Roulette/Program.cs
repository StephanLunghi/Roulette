using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Run = true;
            
            RouletteWheel wheel = new RouletteWheel();

            while (Run)
            {
                Console.Clear();
                Console.WriteLine("ESC to quit, any other key to keep gambling\n");
                wheel.SpinWheel();

                if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                {
                    Run = false;
                }
            }
           
        }
    }
}
