using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    using Tamagotchi.BaseManagement;

    /// <summary>
    /// Абстрактная фабрика, описывающая методы создания типовых объектов, используемых животными.
    /// </summary>
    public abstract class AnimalFactory
    {
        /// <summary>
        /// Создать питание для животного.
        /// </summary>
        /// <returns></returns>
        public abstract Food CreateFood();

        /// <summary>
        /// Создать поведение животного.
        /// </summary>
        /// <returns></returns>
        public abstract Behavior CreateBehavior();

        /// <summary>
        /// Создать игру для животного.
        /// </summary>
        /// <returns></returns>
        public abstract Game CreateGame();
    }
}
