using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Jan23
{
    class Bird:Animal
    {
        //fields
        private double wingSpanInMeters;
        private bool vegetarian;

        //properties
        public double WingSpanInMeters
        {
            get { return this.wingSpanInMeters; }
            set { this.wingSpanInMeters = value; }
        }
        public bool Vegetarian
        {
            get { return this.vegetarian; }
            set { this.vegetarian = value; }
        }

        //constructors
        public Bird()
        {
            this.wingSpanInMeters = .5;
            this.vegetarian = false;
        }

        //methods
        public void ShowBirdInfo()
        {
            Console.WriteLine("\n"+Name + " the  Bird");
            ShowInfo();
            Console.WriteLine("Wingspan: " + WingSpanInMeters+" meters");
            Console.WriteLine("Vegetarian: " + Vegetarian);
        }
        public void Fly()
        {
            Console.WriteLine("\n" + Name + " flew.");
            Energy -= 5;
            Nutrition -= 5;
            Hydration -= 5;
        }
    }
}
