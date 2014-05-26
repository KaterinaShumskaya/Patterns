using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi.Dogs
{
    using Tamagotchi.BaseManagement;

    public class DogBehavior : Behavior
    {
        public override void Laugh()
        {
            Console.WriteLine("Гав, гав! Я в отличном настоении!");
        }

        public override void Cry()
        {
            Console.WriteLine("Уууу-у-ууу!");
        }

        public override void Run()
        {
            Console.WriteLine("Я несусь сломя голову, сшибая всё на своём пути!");
        }
    }
}
