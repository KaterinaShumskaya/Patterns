using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi.Cats
{
    using Tamagotchi.BaseManagement;

    public class CatGame : Game
    {
        public override void Start()
        {
            Console.WriteLine("Муррр, новая игра!");
        }

        public override void End()
        {
            Console.WriteLine("Мне понравилось играть! Поиграем ещё?");
        }
    }
}
