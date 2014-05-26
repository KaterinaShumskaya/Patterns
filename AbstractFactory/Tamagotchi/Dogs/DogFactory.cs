using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi.Dogs
{
    using Tamagotchi.BaseManagement;

    public class DogFactory : AnimalFactory
    {
        public DogFactory()
        {
            Console.WriteLine("Я - самый верный друг! Меня зовут Шарик!");
        }

        public override Food CreateFood()
        {
            return new DogFood();
        }

        public override Behavior CreateBehavior()
        {
            return new DogBehavior();
        }

        public override Game CreateGame()
        {
            return new DogGame();
        }
    }
}
