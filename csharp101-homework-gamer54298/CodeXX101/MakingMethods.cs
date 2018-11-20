using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeXX101
{
    public static class MakingMethods
    {

        //Functions are created as follows:
        //  access-specifier return data-type method-name ( parameters) { statements }

        //  access-types can be public, private, protected, internal
        //  See https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/access-modifiers

        
        //Create a private static method to return body temperatures
        private static double bodyTempF()
        {
            double temperature = 98.6;
            return temperature;
        }

        private static double bodyTempC()
        {
            double temperature = 37;
            return temperature;
        }

        //Now, create a method that's publically available to write the temperature
        public static void writeBodyTempF()
        {
            Console.WriteLine("The body is {0} degF.", bodyTempF());
        }


        //Let's send some arguments:
        public static double convertFtoC(double F)
        {
            double C = (F - 32) * 5.0 / 9.0;
            Console.WriteLine("{0} in deg F = {1} in deg C. Returning {1}", F, C);
            return C;
        }

        //Passing Multiple Arguments
        public static void personInDogYears(string name, int age)
        {
            int dogYears = age * 7;
            Console.WriteLine("In dog years, {0} is {1}.", name, dogYears);

        }

        //Overloading: Using the same name with different arguments
        private static double computeArea(double width)  //Would work for a circle
        {
            double radius = width / 2.0;
            return (radius * radius * 3.14159);
        }

        private static double computeArea(double width, double height) //for a rectangle
        {
            return (width * height);
        }

        private static double computeArea(double width, double height, char letter) //Triangle!?!
        {
            return (width / 2.0 * height);
        }

        public static void computeAreas()
        {
            //Using the overloaded methods, we can calculate lots of areas
            double areaC, areaR, areaT;
            areaC = computeArea(5);
            areaR = computeArea(5, 6);
            areaT = computeArea(5, 6, 'T');
            Console.WriteLine("Areas: C={0}, R={1}, T={2}", areaC, areaR, areaT);
           
        }


        //There are three ways to pass arguments into methods:
        // 1: By Value (copies the original value to the parameters, will not change original)
        //    This is the "default" way
        // 2: By Reference (sends the memory address, *will* change the original)
        //    Use "ref" keyword
        // 3: For Output (a bit advanced). Useful to return more than one output value to a method
        // See https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/out


        private static int retByValue(int x)
        {
            x = 70; //
            return x * x;
        }

        private static int retByRef(ref int x)
        {
            x = 70;
            return x * x;
        }

       public static void PassByValAndByRef()
        {
            int side = 5;
            int answ;

            answ = retByValue(side);
            Console.WriteLine("When input = {0}, return = {1}", side, answ);

            answ = retByRef(ref side);
            Console.WriteLine("When input = {0}, return = {1}", side, answ);

        }





    }
}
