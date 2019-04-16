using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
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
        private string winningBin;

        public RouletteWheel()
        {
            wheel = new string[,]
            {{"0", "Green"},
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
             {"36","Red"} ,
            { "00", "Green"}};
            
           random = new Random();
        }

        public void SpinWheel()
        {
            int randIndex = random.Next(38);
            
            winningNumber = wheel[randIndex, 0];
            winningColor = wheel[randIndex, 1];
            winningBin = winningNumber + " " + winningColor;
            Console.WriteLine($"Winner, {winningBin}!");
            Console.WriteLine();

            if (randIndex == 0)
            {
                Console.WriteLine("Number bet: 0 Green is the winner!");
            }
            else if (randIndex == 37)
            {
                Console.WriteLine("Number bet: 00 Green is the winner!");
            }
            else
            {
                EvensOdds(randIndex);
                HighsLows(randIndex);
                Dozens(randIndex);
                ColumnStreets(randIndex);
                Doubles(randIndex);
                SplitsCorners(randIndex);

            }
        }

        private void Doubles(int randIndex)
        {
            if (randIndex % 3 == 0 && randIndex != 36)
            {
                Console.WriteLine($"Double Row Winners: {randIndex - 2},{randIndex - 1},{randIndex},{randIndex + 1},{randIndex + 2},{randIndex + 3}");
            }
            if (randIndex % 3 == 1 && randIndex != 34)
            {
                Console.WriteLine($"Double Row Winners: {randIndex},{randIndex + 1},{randIndex + 2},{randIndex + 3},{randIndex + 4},{randIndex + 5}");
            }
            if (randIndex % 3 == 2 && randIndex != 35)
            {
                Console.WriteLine($"Double Row Winners: {randIndex - 1},{randIndex},{randIndex + 1},{randIndex + 2},{randIndex + 3},{randIndex + 4}");
            }
            if (randIndex == 35)
            {
                Console.WriteLine($"Double Row Winners: {randIndex - 4},{randIndex - 3},{randIndex - 2},{randIndex - 1},{randIndex},{randIndex + 1}");
            }
        }

        private void SplitsCorners(int randIndex)
        {
            if (randIndex % 3 == 1 && randIndex != 1 && randIndex != 34)
            {
                
                Console.WriteLine($"Split Winners: {randIndex - 3 }/{randIndex}, {randIndex}/{randIndex + 1}, {randIndex}/{randIndex + 3} ");
                Console.WriteLine($"Corner Winners: {randIndex - 3}/{randIndex - 2}/{randIndex}/{randIndex + 1}, {randIndex}/{randIndex + 1}/{randIndex + 3}/{randIndex + 4}");
            }
            if (randIndex == 1)
            {
                Console.WriteLine($"Split Winners: {randIndex}/{randIndex + 1}, {randIndex}/{randIndex + 3} ");
                Console.WriteLine($"Corner Winners: {randIndex}/{randIndex + 1}/{randIndex + 3}/{randIndex + 4}");
            }

            if (randIndex == 34)
            {
                Console.WriteLine($"Double Row Winners: {randIndex - 3},{randIndex - 2},{randIndex - 1},{randIndex},{randIndex + 1},{randIndex + 2}");
                Console.WriteLine($"Split Winners: {randIndex - 3}/{randIndex}, {randIndex}/{randIndex + 1} ");
                Console.WriteLine($"Corner Winners: {randIndex -3}/{randIndex - 2}/{randIndex}/{randIndex + 1}");
            }
            if (randIndex % 3 == 2 && randIndex != 2 && randIndex != 35)
            {
                Console.WriteLine($"Split Winners: {randIndex - 3 }/{randIndex}, {randIndex - 1}/{randIndex}, {randIndex}/{randIndex + 1}, {randIndex}/{randIndex + 3} ");
                Console.WriteLine($"Corner Winners: {randIndex - 4}/{randIndex - 3}/{randIndex - 1}/{randIndex}, {randIndex - 3}/{randIndex - 2}/{randIndex}/{randIndex + 1}, {randIndex - 1}/{randIndex}/{randIndex + 2}/{randIndex + 3}, {randIndex}/{randIndex + 1}/{randIndex + 3}/{randIndex + 4}");
            }

            if (randIndex == 2)
            {
                Console.WriteLine($"Split Winners: {randIndex - 1}/{randIndex}, {randIndex}/{randIndex + 1} ");
                Console.WriteLine($"Corner Winners: {randIndex - 1}/{randIndex}/{randIndex + 2}/{randIndex + 3}, {randIndex}/{randIndex + 1}/{randIndex + 3}/{randIndex + 4}");
            }

            if (randIndex == 35)
            {
                Console.WriteLine($"Split Winners: {randIndex - 1}/{randIndex}, {randIndex}/{randIndex + 1} ");
                Console.WriteLine($"Corner Winners: {randIndex - 4}/{randIndex - 3}/{randIndex - 1}/{randIndex}, {randIndex - 3}/{randIndex - 2}/{randIndex}/{randIndex + 1}");
            }

            if (randIndex == 3)
            {
                Console.WriteLine($"Split Winners: {randIndex - 1}/{randIndex}, {randIndex}/{randIndex + 3} ");
                Console.WriteLine($"Corner Winners: {randIndex - 1}/{randIndex}/{randIndex + 2}/{randIndex + 3}");
            }

            if (randIndex == 36)
            {
                Console.WriteLine($"Double Row Winners: {randIndex - 5},{randIndex - 4},{randIndex - 3},{randIndex - 2},{randIndex - 1},{randIndex}");
                Console.WriteLine($"Split Winners: {randIndex - 3}/{randIndex}, {randIndex - 1}/{randIndex} ");
                Console.WriteLine($"Corner Winners: {randIndex - 4}/{randIndex - 3}/{randIndex - 1}/{randIndex}");
            }

            if (randIndex % 3 == 0 && randIndex != 3 && randIndex != 36)
            {
                Console.WriteLine($"Split Winners: {randIndex - 3}/{randIndex}, {randIndex - 1}/{randIndex}, {randIndex}/{randIndex + 3} ");
                Console.WriteLine($"Corner Winners: {randIndex - 4}/{randIndex - 3}/{randIndex - 1}/{randIndex}, {randIndex - 1}/{randIndex}/{randIndex + 2}/{randIndex + 3}");
            }
        }

        private void ColumnStreets(int randIndex)
        {
            if (randIndex % 3 == 0)
            {
                Console.WriteLine("Third Column: Winner!");
                Console.WriteLine($"Street Winners: {randIndex - 2},{randIndex - 1},{randIndex}");
            }
            else if (randIndex % 3 == 1)
            {
                Console.WriteLine("First Column: Winner!");
                Console.WriteLine($"Street Winners: {randIndex},{randIndex + 1},{randIndex + 2}");
            }
            else
            {
                Console.WriteLine("Second Column: Winner!");
                Console.WriteLine($"Street Winners: {randIndex - 1},{randIndex},{randIndex + 1}");
            }
        }

        private void Dozens(int randIndex)
        {
            if (randIndex < 13)
            {
                Console.WriteLine("Dozens 1-12: Winner!");
            }
            else if (randIndex < 25)
            {
                Console.WriteLine("Dozens 13-24: Winner!");
            }
            else
            {
                Console.WriteLine("Dozens 25-36: Winner!");
            }
        }

        private void HighsLows(int randIndex)
        {
            if (randIndex < 19)
            {
                Console.WriteLine("Lows: Winner!");
            }
            else
            {
                Console.WriteLine("Highs: Winner!");
            }
        }

        private void EvensOdds(int randIndex)
        {
            if (randIndex % 2 == 0)
            {
                Console.WriteLine("Evens: Winner!");
            }
            else
            {
                Console.WriteLine("Odds: Winner!");
            }
        }
    }
}
