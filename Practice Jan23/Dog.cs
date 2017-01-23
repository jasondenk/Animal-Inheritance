using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Jan23
{
    class Dog : Animal
    {
        //fields
        private int legs;
        private string breed;

        //properties
        //Updates # of Legs
        public int Legs
        {
            get { return this.legs; }
            set { this.legs = value; }
        }
        //Updates Breed
        public string Breed
        {
            get { return this.breed; }
            set { this.breed = value; }
        }

        //constructors
        public Dog()
        {            
            this.legs = 4;
            this.breed = "Cane Corso";
        }

        //methods
        public void ShowDogInfo()
        {
            Console.WriteLine("\n" + Name + " the " + Breed);
            ShowInfo();
            Console.WriteLine("# of Legs: " + Legs);
            Console.WriteLine("Breed: " + Breed);
        }
        public void Run()
        {
            Console.WriteLine("\n" + Name + " ran.");
            Energy -= 5;
            Nutrition -= 5;
            Hydration -= 5;
        }
    }
}
