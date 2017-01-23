using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Jan23
{
    class Fish:Animal
    {
        //fields
        private bool scales;
        private bool teeth;
        private string waterType;
        private int fins;

        //properties
        //Updates water type
        public string WaterType
        {
            get { return this.waterType; }
            set { this.waterType = value; }
        }
        //Updates scales
        public bool Scales
        {
            get { return this.scales; }
            set { this.scales = value; }
        }
        //Updates teeth
        public bool Teeth
        {
            get { return this.teeth; }
            set { this.teeth = value; }
        }
        //Updates # of fins
        public int Fins
        {
            get { return this.fins; }
            set { this.fins = value; }
        }

        //constructors
        public Fish(int fins, bool scales, bool teeth, string waterType):base("Nemo","Silver")
        {
            this.fins = fins;
            this.scales = scales;
            this.teeth = teeth;
            this.waterType = waterType;
        }

        //method
        public void Swim()
        {
            Console.WriteLine("\n"+Name + " swam.");
            Energy -= 5;
            Nutrition -= 5;
            Hydration -= 5;
        }


    }
}
