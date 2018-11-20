using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeXX101
{
    public static class ErrorTrapping
    {

        public static void DontCatchRunTime()
        {
            Console.WriteLine("The divider by zero issue:");
            int numerator = 10;
            for (int x = -3; x <= 3; x++)
            {
                int answer = numerator / x;
                Console.WriteLine("{0} / {1} = {2}", numerator,x,answer);
            }
        }


        public static void CatchRunTime()
        {
            Console.WriteLine("The divider by zero issue:");
            try
            {
                int numerator = 10;
                for (int x = -3; x <= 3; x++)
                {
                    int answer = numerator / x;
                    Console.WriteLine("{0} / {1} = {2}", numerator, x, answer);
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);

            }
        }


    }
}
