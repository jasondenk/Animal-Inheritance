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
            dog1.Run();

            Cat cat1 = new Cat("Grumpy", "Short", false,"Felix");
            cat1.ShowInfo();
            cat1.Speak();            

            Fish fish1 = new Fish(5, true, true, "salt");
            fish1.WeightLbs = 33;
            fish1.ShowInfo();
            fish1.Swim();
            fish1.ShowInfo();

        }
    }
}
