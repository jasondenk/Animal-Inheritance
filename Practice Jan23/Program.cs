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
            /*//personal tries
            Dog Magnus = new Dog("Magnus", "Cane Corso");
            Magnus.Nutrition = 60;            
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
            */
            
            Dog dog1 = new Dog("Chesty","Bandog",210);
            dog1.ShowDogInfo();

            Cat cat1 = new Cat("Grumpy", "Short", false,"Felix");
            cat1.ShowInfo();          

        }
    }
}
