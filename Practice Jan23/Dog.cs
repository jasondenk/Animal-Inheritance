﻿using System;
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
        public Dog(string name)
        {
            this.Name = name;
            this.legs = 4;
            this.breed = Breed;
            isGoodToEat = false;
        }

        //methods
        public void ShowDogInfo()
        {
            Console.WriteLine("Breed: " + Breed);
            ShowInfo();
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
