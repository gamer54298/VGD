using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeXX101
{
    public static class Operations
    {

        public static void Arithmetic()
        {
            //Use the debugger (in Main) to watch the values change! 
            int a = 9;
            int b = 6;

            int c;
            a++;
            b--;
            c = a + b;
            c = a - b;
            c = a * b;
            c = a / b;
            c = a % b;
            c = b % a;

            //Assignment...
            a += b;
            a -= b;
            a *= b;
            a /= b;
            a %= b;
            a = b;

        }

        public static void Comparison() {
            int a = 10;
            int b = 45;
            int c = 10;
            Console.WriteLine(a == b);
            Console.WriteLine(a != b);
            Console.WriteLine(a > c);
            Console.WriteLine(a >= c);
            Console.WriteLine(a < c);
            Console.WriteLine(a <= c);


        }

        public static void Logic()
        {
            //Try changing these to see the truth values
            bool a = true;
            bool b = false;
            Console.WriteLine(a && b);
            Console.WriteLine(a || b);
            Console.WriteLine(!a);

        }

        public static void Ternary()
        {
            //  {test expression} ? if-true-return-this : if-false-return-this
            int a, b, c;
            a = 4;
            b = 6;

            c = (a < b) ? a : b;
            Console.WriteLine(c);

        }




    }
}
