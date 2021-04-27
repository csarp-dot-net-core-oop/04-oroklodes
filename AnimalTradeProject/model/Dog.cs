using System;
using System.Collections.Generic;
using System.Text;

namespace oop.model
{
    /// I1.04 Öröklődés
    ///       A kutya egy állat, tehát örököltetjük az "Animal" osztályból. Tehát bizonyos dolgokat átvesz abból az osztályból.
    ///       https://csharp.net-tutorials.com/hu/122/osztalyok/oroklodes-/
    /// <summary>
    /// Kutya osztály
    /// </summary>
    /// 
    class Dog : Animal
    {
        /// <summary>
        /// I1.07 A származtatott osztályra jellemző tulajdonság
        ///       A kutyára jellemző tulajdonság pl. a fajta
        /// </summary>
        private string breed;

        /// I1.05 Készítsük el a kutya osztály konstruktorát
        ///       A fordító az Animal osztállyal kapcsolatos hibát jelez 
        /// I1.08 A származtatott osztály tulajdonsága is a konstruktorba
        ///       A kutyára jellemző tulajdonságot is felvesszük a konstruktorba/// I1.08 A kutyára jellemző tulajdonságot is felvesszük a konstruktorba
        public Dog(string name, int age, string breed)
            /// I1.06 Ösosztály konstruktorának meghívása
            ///       Tehát mielőtt lefut a kutya konstruktort meg kell hívni az "Animal" osztály = base konstruktorát
            : base(name, age)
        {
            this.breed = breed;
        }
    }
}
