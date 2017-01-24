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
        public Dog(string name,string breed,int weightLbs)
        {
            this.Name = name;            
            this.legs = 4;
            this.breed = breed;
            this.WeightLbs = weightLbs;
            isGoodToEat = false;
        }
        public Dog(string name, string color, string breed, int weightLbs)
        {
            this.Color = color;
            this.Name = name;
            this.legs = 4;
            this.breed = breed;
            this.WeightLbs = weightLbs;
            isGoodToEat = false;
        }

        //methods
        public override void ShowInfo()
        {
            Console.Write("\nAnimal: Dog, Name: ");
            base.ShowInfo();
            Console.WriteLine("Breed: " + Breed);
            Console.WriteLine("# of Legs: " + Legs);            
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
