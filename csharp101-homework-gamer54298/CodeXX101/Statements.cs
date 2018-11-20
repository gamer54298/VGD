using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeXX101
{
    public static class Statements
    {
        public static void BranchingIf()
        {
            int a = 7; //Try changing this to see the branches.

            if (a < 4)
            {
                Console.WriteLine("Number is less than 4");
            }
            else if (a >= 4 && a <= 10)
            {
                Console.WriteLine("Number is between 4 and 10 (inclusive)");
            }
            else
            {
                Console.WriteLine("Number is greater than 10.");
            }
        }


        public static void Switching()
        {
            int d = 2; //Try changing this (even to negative numbers)
            string day;

            switch (d)
            {
                case 1:
                    day = "Monday";
                    break;
                case 2:
                    day = "Tuesday";
                    break;
                case 3:
                    day = "Wednesday";
                    break;
                case 4:
                    day = "Thursday";
                    break;
                case 5:
                    day = "Friday";
                    break;
                default:
                    day = "Weekend! Yay!";
                    break;
            }
            Console.WriteLine("Day {0} is {1}", d, day);
        }

        public static void ForLoop()
        {
            //for (initializer; test-expression; updater) { statements }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("The value of i is {0}", i);
            }
            Console.WriteLine();


            //Nesting Loops
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("i: {0}", i);
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("\tj: {0}", j);
                }
            }
        }

        public static void WhileLoops()
        {

            //while {test-expression} {statements}
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine("For i, this is pass {0}", i);
                i++;
            }

            Console.WriteLine();
            //do {statements} while {test-expression}
            int j = 0;
            do
            {
                Console.WriteLine("For j, this is pass {0}", j);
                j++;
            } while (j < 5) ;

        }


        public static void LoopingArrays()
        {
            //This will store the square of a number in an array
            int[] square = new int[10];
            for (int i = 0; i < 10; i++)
            {
                square[i] = i * i;
            }
            Console.WriteLine(square[5]);

            //Now try going "out of bounds"
            //Console.WriteLine(square[12]);

        }

        public static void ForEachIterations()
        {
            string[] websites = new string[5] { "google", "facebook", "youtube", "bing", "yahoo"};
            int rank = 1;
            foreach( string site in websites)
            {
                Console.WriteLine("Website: {0}. Rank: {1}", site,rank);
                rank++;
            }

            Console.WriteLine();
            List<string> phones = new List<string>();
            phones.Add("iPhone");
            phones.Add("Samsung");
            phones.Add("Pixel");
            phones.Add("Flip Phone");

            foreach (string p in phones)
            {
                Console.WriteLine(p);
            }


        }


    }//Class

}
