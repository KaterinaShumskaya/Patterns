using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi.Cats
{
    using Tamagotchi.BaseManagement;

    public class CatFood : Food       
    {
        public override void Drink()
        {
            Console.WriteLine("Мррр... люблю молочко!");
        }

        public override void Eat()
        {
            Console.WriteLine("Kitekat - еда энергичных кошек.");
        }
    }
}
