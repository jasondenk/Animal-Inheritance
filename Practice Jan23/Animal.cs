using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Jan23
{
    class Animal
    {
        //fields
        private int nutrition;
        private int hydration;
        private int energy;
        private int weightLbs;

        protected string color;
        protected string name;

        protected bool isGoodToEat;

        //properties
        //Updates Name
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        //Updates Energy Level
        public int Energy
        {
            get { return this.energy; }
            set { this.energy = value; }
        }
        //Updates Hunger Level
        public int Nutrition
        {
            get { return this.nutrition; }
            set { this.nutrition = value; }
        }
        //Updates Thirst Level
        public int Hydration
        {
            get { return this.hydration; }
            set { this.hydration = value; }
        }
        //Updates Weight
        public int WeightLbs
        {
            get { return this.weightLbs; }
            set { this.weightLbs = value; }
        }
        //Updates is good to eat
        public bool IsGoodToEat
        {
            get { return this.isGoodToEat; }
            set { this.isGoodToEat = value; }
        }

        //constructors
        public Animal()
        {
            this.energy = 50;
            this.nutrition = 50;
            this.hydration = 50;            
        }
        public Animal(string name, string color)
        {
            this.name = name;
            this.color = color;
        }
        public Animal(int energy, int nutrition, int hydration, int weightLbs)
        {
            this.energy = energy;
            this.nutrition = nutrition;
            this.hydration = hydration;
            this.weightLbs = weightLbs;
        }

        //methods
        public void ShowInfo()
        {
            Console.WriteLine("\n" + Name );
            Console.WriteLine("Color: " + color);
            Console.WriteLine("Energy: " + Energy);
            Console.WriteLine("Nutrition: " + Nutrition);
            Console.WriteLine("Hydration: " + Hydration);
            Console.WriteLine("Weight: " + WeightLbs + " lbs");
            Console.WriteLine("Good to eat: " + isGoodToEat);
        }

        protected void WhoAmI()
        {
            Console.WriteLine("I am an animal.");
        }        
}
}
