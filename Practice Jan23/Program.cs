using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Jan23
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog Magnus = new Dog();
            Magnus.Nutrition = 60;
            Magnus.Name = "Magnus";
            Magnus.WeightLbs = 120;
            Magnus.ShowDogInfo();

            Bird Billy = new Bird();
            Billy.Name = "Billy";
            Billy.WeightLbs = 6;
            Billy.Vegetarian = true;
            Billy.ShowBirdInfo();

            Magnus.Run();
            Billy.Fly();
            Magnus.ShowDogInfo();
            Billy.ShowBirdInfo();
        }
    }
}
