using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ioop2starter
{
    class Pen
    {
        //Properties
        public string Name;
        public string Color;
        public float Price;
        public uint PercentInkRemaining;
        public bool IsEmpty;


        //Constructors
        public Pen()
        {

        }

        public Pen(string name, string color, float price, uint percentInkRemaining, bool isEmpty)
        {
            Name = name;
            Color = color;
            Price = price;
            PercentInkRemaining = percentInkRemaining;
            IsEmpty = isEmpty;
        }


        //Methods
        public void WriteName()
        {
            Console.WriteLine("My name is " + this.Name);
        }

        public void WriteColor()
        {
            Console.WriteLine("My color is " + this.Color);
        }

        public void WriteInkLevel()
        {
            Console.WriteLine("I have " + this.PercentInkRemaining + "% ink remaining.");
        }

        public void UseInk(uint percentToUse)
        {
            this.PercentInkRemaining -= percentToUse;
        }

        public void Refill()
        {
            this.PercentInkRemaining = 100;
        }

        public float GetCurrentMonetaryValue()
        {
            return (this.PercentInkRemaining / 100.0f * this.Price);
        }
    }
}
