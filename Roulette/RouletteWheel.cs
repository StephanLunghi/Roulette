using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Roulette
{
    class RouletteWheel
    {
        private string[,] wheel;
        private Random random;
        private string winningNumber;
        private string winningColor;
        public RouletteWheel()
        {
            wheel = new string[,]
            {{"0","Green"},
             {"00", "Green"},
             {"1", "Red"},
             {"2", "Black"},
             {"3","Red"}, 
             {"4","Black"},
             {"5","Red"},
             {"6","Black"},
             {"7","Red"},
             {"8","Black"},
             {"9","Red"},
             {"10","Black"},
             {"11","Black"},
             {"12","Red"},
             {"13","Black"},
             {"14","Red"},
             {"15","Black"},
             {"16","Red"},
             {"17","Black"},
             {"18","Red"},
             {"19","Red"},
             {"20","Black"},
             {"21","Red"},
             {"22","Black"},
             {"23","Red"},
             {"24","Black"},
             {"25","Red"},
             {"26","Black"},
             {"27","Red"},
             {"28","Black"},
             {"29","Black"},
             {"30","Red"},
             {"31","Black"},
             {"32","Red"},
             {"33","Black"},
             {"34","Red"},
             {"35","Black"},
             {"36","Red"} };
            random = new Random();
        }

        public void SpinWheel()
        {
            // I think I need 39 rather than 38 because of the definition of Next
            int randIndex = random.Next(39);

            winningNumber = wheel[randIndex, 0];
            winningColor = wheel[randIndex, 1];
            
            Console.WriteLine($"{winningNumber} {winningColor}");





        }
    }
}
