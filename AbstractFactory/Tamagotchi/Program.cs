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
            var controller = new Controller(new CatFactory());
            controller.Play();

            controller = new Controller(new DogFactory());
            controller.Play();
            Console.ReadKey();
        }
    }
}
