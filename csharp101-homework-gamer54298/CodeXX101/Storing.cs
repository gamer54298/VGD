using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CodeXX101
{
    public static class Storing
    {

        //We'll use this later, but it *must* be placed here!
        enum Days { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };

        //We'll also use this later... but it needs to be here:
        struct _3DPoint
        {
            public int xVal;
            public int yVal;
            public int zVal;
        };

        public static void Initialize()
        {
            Console.WriteLine("Storing Class Initialized.");
            Console.Title = "Initializer";
        }

        private static void SetTitles(string title)
        {
            Console.Title = title;
            Console.WriteLine(title + "\n-------------------------\n");
        }

        public static void DemoVariables()
        {
            SetTitles("Demo Variables");
            //Variable types: 
            //int, uint, char, float, double, decimal, bool, string

            int integerNumber = -1;
            uint positiveInteger = 2;
            char letter = 'Z';
            float body = 98.6f;
            double e = 2.718281828459045;
            decimal income = 45_555.09m;
            bool IsEmpty = true;
            string text = "C# is fun, right!?!?";

            //Now, let's print (a few different ways)
            Console.WriteLine("The integer is \t\t" + integerNumber);
            Console.WriteLine("Positive Number:\t{0}\nLetter:\t\t\t{1}", positiveInteger, letter);
            Console.WriteLine(text);
            Console.WriteLine("IsEmpty value: " + IsEmpty);

        }

        public static void ReadingInput()
        {
            //How to read input from the console
            SetTitles("Reading Input");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("It's nice to meet you, {0}", name);
            Console.WriteLine("How old are you, {0} -- in years?", name);
            int years = Convert.ToInt16(Console.ReadLine());
            int months = years * 12;
            float days = (float)years * 365.25f;
            Console.WriteLine("That's approximately {0} months, or {1} days!", months, days);


            //Try other Convert.___ options

        }

        public static void UsingArrays()
        {
            //How to read input from the console
            SetTitles("Using Arrays");

            //Simple 1D arrays
            int[] numericalValues = new int[4];
            string[] wordValues = new string[4];

            numericalValues[0] = 12;
            wordValues[0] = "dozen";
            numericalValues[1] = 144;
            wordValues[1] = "gross";
            numericalValues[2] = 20;
            wordValues[2] = "score";
            numericalValues[3] = 13;
            wordValues[3] = "baker's dozen";

            int index = 2;
            Console.WriteLine("You have {0} birds, or a {1} of birds.", numericalValues[index], wordValues[index]);

            string[] cars = new string[4] { "BMW", "Mercedes", "Hyundai", "Scooter" };
            Console.WriteLine("Run them over with your {0}!", cars[index]);

            //2D arrays
            int[,] coords = new int[2, 3] { { 1, 2, 3 }, { 10, 20, 30 } };
            Console.WriteLine("Coordinate: " + coords[1, 2]); //Try a few!
            /* Here's the "map" for these:
             * 1  10
             * 2  20
             * 3  30
             */

            //Casting Data Types
            //Predict a few of these: (double)7/2; double(7/2); (double)(7/2)
            double result = 7 / 2;
            Console.WriteLine("The result is {0}", result);

            //Now... what about char?
            char letter = 'A';
            Console.Write("The letter {0} converts to: ", letter);
            Console.WriteLine((int)letter);



        }

        public static void ConstantsEnumsStructs()
        {
            SetTitles("Constants, Enums, and Structs");

            //How to use an enum  (see the top of the file)
            Console.WriteLine("The day is " + Days.Saturday);
            var daysType = typeof(Days);
            Console.WriteLine("Days type: " + daysType);
            var dayOfWeek = Days.Saturday;
            if (dayOfWeek == Days.Saturday || dayOfWeek == Days.Sunday)
            {
                Console.WriteLine("Happy Weekend!");
            }


            //How to use a constant
            const double pi = 3.14159265358979;
            Console.WriteLine("You can't change pi={0}", pi);
            //Try it:
            //pi = 3.14;

            //How to use a struct
            _3DPoint point;
            point.xVal = 4;
            point.yVal = 6;
            point.zVal = 19;

            Console.WriteLine("The coordinate of the point is ({0},{1},{2})", point.xVal, point.yVal, point.zVal);
                     
        }

    }
}
