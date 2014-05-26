using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi.Cats
{
    using Tamagotchi.BaseManagement;

    public class CatFactory : AnimalFactory
    {
        public CatFactory()
        {
            Console.WriteLine("Привет, я - кот!");
        }

        public override Food CreateFood()
        {
            return new CatFood();
        }

        public override Behavior CreateBehavior()
        {
            return new CatBehavior();
        }

        public override Game CreateGame()
        {
            return new CatGame();
        }
    }
}
