using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi.Dogs
{
    using Tamagotchi.BaseManagement;

    public class DogGame : Game
    {
        public override void Start()
        {
            Console.WriteLine("Хозяин, что же ты медлишь? Кидай палку!");
        }

        public override void End()
        {
            Console.WriteLine("Я могу ещё и мяч приносить и тапочки!");
        }
    }
}
