using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Jan23
{
    class Cat:Animal
    {
        //fields
        private string breed;
        private string furLength;

        private bool declawed;

        //constructors
        public Cat(string breed, string furLength, bool declawed, string name):base(50,50,50,15)
        {
            this.name = name;            
            this.breed = breed;
            this.furLength = furLength;
            this.declawed = declawed;
            isGoodToEat = false;
        }
    }
}
