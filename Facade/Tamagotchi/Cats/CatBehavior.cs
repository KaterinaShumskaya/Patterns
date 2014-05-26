using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi.Cats
{
    using Tamagotchi.BaseManagement;

    public class CatBehavior : Behavior
    {
        public override void Laugh()
        {
            Console.WriteLine("Mур-мяу, мур-мяу");
        }

        public override void Cry()
        {
            Console.WriteLine("Мя-а-а-а-а-у");
        }

        public override void Run()
        {
            Console.WriteLine("Я бегаю тихо. Меня не слышно!");
        }
    }
}
