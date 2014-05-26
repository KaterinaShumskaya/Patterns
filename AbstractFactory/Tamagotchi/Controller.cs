using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    using Tamagotchi.BaseManagement;

    public class Controller
    {
        private readonly AnimalFactory _animal; 

        public Controller(AnimalFactory animal)
        {
            _animal = animal;
        }
        /// <summary>
        /// "Игра"
        /// </summary>
        public void Play()
        {
            Food food = _animal.CreateFood();
            Behavior behavior = _animal.CreateBehavior();
            Game game = _animal.CreateGame();

            food.Eat();
            behavior.Laugh();
            game.Start();
        }
    }
}
