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
            //create bird, show info, fly, show info
            Bird Billy = new Bird();
            Billy.Name = "Billy";
            Billy.WeightLbs = 6;
            Billy.Vegetarian = true;
            Billy.ShowInfo();
            Billy.Fly();            
            Billy.ShowInfo();
            
            //create dog, show info, run
            Dog dog1 = new Dog("Chesty","Bandog",210);
            dog1.ShowInfo();
            dog1.Run();

            //create cat, show info, speak
            Cat cat1 = new Cat("Grumpy", "Short", false,"Felix");
            cat1.ShowInfo();
            cat1.Speak();            

            //create fish, show info, swim, show info
            Fish fish1 = new Fish(5, true, true,true, "salt");
            fish1.WeightLbs = 33;
            fish1.ShowInfo();
            fish1.Swim();
            fish1.ShowInfo();

            //create dog with no breed, show info
            Dog dog2 = new Dog("Clifford", "red", "GIANT", 3000);
            dog2.ShowInfo();

        }
    }
}
