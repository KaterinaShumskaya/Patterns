using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    using Tamagotchi.Cats;
    using Tamagotchi.Dogs;

    class Program
    {
        static void Main(string[] args)
        {
            var cat = new CatFactory();
            var dog = new DogFactory();
            var facade = new Facade.Facade();
            facade.Add(cat.CreateFood());
            facade.Add(dog.CreateFood());
            facade.Eat();
            facade.Drink();
  
            Console.ReadKey();
        }
    }
}
