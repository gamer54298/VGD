using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeXX101
{
    public static class StringWork
    {
        public static void StringFeatures()
        {
            Console.WriteLine("Please Enter Text:\n");
            string text = Console.ReadLine();
            if (String.IsNullOrEmpty( text ))
            {
                Console.WriteLine("\nError: No Text Found!");
            } else
            {
                Console.WriteLine("Thanks. You entered: \n'{0}'\n",text);
                string query = text.StartsWith("C#") ? "Does" : "Does Not";
                Console.WriteLine("Text " + query + " start with 'C#'");
                query = text.EndsWith("easy") ? "does" : "does not";
                Console.WriteLine("Text " + query + " end with 'easy'");
                query = text.Contains("is") ? "does" : "does not";
                Console.WriteLine("Text " + query + " contain 'is'");
                
            }

        }

        public static void ManipulatingStrings()
        {
            Console.WriteLine("Please Enter Text:\n");
            string text = Console.ReadLine();
            Console.WriteLine("\nThanks! You entered '{0}'", text);
            Console.WriteLine("\tText Length: {0}", text.Length);
            text = text.Trim();
            Console.WriteLine("\tTrimmed Text Length: {0}", text.Length);

            string upper = text.ToUpper();
            string lower = text.ToLower();
            Console.WriteLine("\tUC Version: {0}\n\tLC Version:{1}", upper, lower);
            upper = upper.PadLeft(40);
            lower = lower.PadRight(40, '#');
            text = text.PadLeft(30, '*').PadRight(40, '*');
            Console.WriteLine("\nPadded Left:\t{0}", upper);
            Console.WriteLine("\nPadded Right:\t{0}", lower);
            Console.WriteLine("\nPadded Both:\t{0}", text);
            Console.WriteLine("\nTrimmed Start\t{0}", upper.TrimStart());
            Console.WriteLine("\nTrimmed End\t{0}", upper.TrimEnd('*'));

            
        }

        public static void JoiningAndComparing()
        {
            //A few different ways to join (using arrays)
            string []  a = new string[3] { "Alpha", "Bravo", "Charlie" };
            string s = String.Concat(a[0], a[1]);
            Console.WriteLine("Concatenated: {0} ", s);
            s = String.Join(" ", a[0], a[1]);
            Console.WriteLine("Joined: {0} ", s);
            s = String.Join("\t\t", a);
            Console.WriteLine("Joining entire array: {0}", s);

            //Comparing Strings... lets you know the "sort order"  Try a few different combinations
            int num = String.Compare(a[0], a[1]);
            Console.WriteLine("{0} vs {1}:\t{2}", a[0], a[1], num);

            //Also possible to use booleans to see if strings are equal.
            Console.WriteLine(a[0] == a[0]);
            Console.WriteLine(String.Compare(a[0], a[0]));

        }

        //SKIPPED: Copying & Swapping Strings using string.CopyTo()

        public static void FindingSubstrings()
        {
            //This uses the private "report" method below
            string phrase = "the quick brown fox jumped over the lazy, lazy, lazy, dog.";
            string searchterm = "lazy";
            int pos = phrase.IndexOf(searchterm);  //Also, try LastIndexOf
            report(pos, searchterm);
            Console.WriteLine("--------------");

            //How can we find all locations of the search string?
            pos = 0;
            while (phrase.IndexOf(searchterm,pos) != -1) //There are 8 overloads of IndexOf !!!
            {
                pos = phrase.IndexOf(searchterm,pos); 
                report(pos, searchterm);
                pos++;
            }
        }

        private static void report(int pos, string sub)
        {
            if (pos != -1)
            {
                Console.WriteLine("'{0}' found at position {1}", sub, pos);
            }
            else
            {
                Console.WriteLine("'{0}' NOT FOUND", sub);
            }
        }
       

        public static void FormattingStrings()
        {
            //There are some "specifiers"...
            // G = General, F = Fixed Point, N = Number (with ',' at 1000s), C = Currency, P = Percentage, 00.0000 = Zero Padding
            int number = 3500;
            Console.WriteLine("Currency String {0}", number.ToString("C"));
            Console.WriteLine("General String {0}", number.ToString("G"));
            Console.WriteLine("Fixed Point String {0:F}", number); //Notice, we can do this in the braces!
            Console.WriteLine("Number String {0:N}", number);
            Console.WriteLine("Percent String {0:P}", number);
            Console.WriteLine("Zero Padding String {0:00.0000}", number);

            //Splitting!
            string data = "Alpha,Bravo,Charlie,Delta";
            string[] items = data.Split(',');
            foreach (string item in items)
            {
                Console.WriteLine("\n{0}", item);
            }


        }

        public static void DateStrings()
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            Console.WriteLine(now.DayOfWeek);
            Console.WriteLine(now.ToShortDateString() );
            Console.WriteLine(now.ToShortTimeString() );

            DateTime future = now.AddYears(4);
            Console.WriteLine(future);

            //Make your own...
            DateTime birthday = new DateTime(1999, 08, 04);
            Console.WriteLine(birthday.DayOfWeek);
            //Can also use the {} syntax:
            Console.WriteLine("Birthday is on a {0:dddd}", birthday); 
            //Other options include {0:D}, {0:T}, {0:M}, {0:YYYY}, {0:HH}, etc...



        }


    }
}
