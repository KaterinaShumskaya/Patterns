using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi.Facade
{
    using System.Collections;

    using Tamagotchi.BaseManagement;

    public class Facade
    {
        IList<Food> _foods = new List<Food>();

        public void Add(Food food)
        {
            _foods.Add(food);
        }

        public void Eat()
        {
            foreach (var food in _foods)
            {
                food.Eat();
            }
        }

        public void Drink()
        {
            foreach (var food in _foods)
            {
                food.Drink();
            }
        }
    }
}
