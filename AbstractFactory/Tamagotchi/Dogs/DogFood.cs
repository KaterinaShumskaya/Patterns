using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi.Dogs
{
    using Tamagotchi.BaseManagement;

    public class DogFood : Food
    {
        public override void Drink()
        {
            Console.WriteLine("Ух ты, повсюду брызги!");
        }

        public override void Eat()
        {
            Console.WriteLine("Рррр! Какая вкусная косточка!");
        }
    }
}
