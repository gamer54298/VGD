using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ioop2starter
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("I.OOP.0x02:::::");

            //Create some pens...

            Pen myCrystalBic = new Pen();
            myCrystalBic.Name = "Crystal Bic";
            myCrystalBic.Color = "RED";
            myCrystalBic.Price = 0.50f;
            myCrystalBic.PercentInkRemaining = 100;
            myCrystalBic.IsEmpty = false;

            Pen mySharpie = new Pen("Sharpie", "BLACK", 1.49f, 100, false);



            //Try some methods...
            mySharpie.WriteName();
            mySharpie.WriteColor();
            mySharpie.WriteInkLevel();
            mySharpie.UseInk(10);
            mySharpie.WriteInkLevel();
            Console.WriteLine(mySharpie.GetCurrentMonetaryValue());
            mySharpie.Refill();
            mySharpie.WriteInkLevel();




            Console.ReadKey();
        }
    }
}
