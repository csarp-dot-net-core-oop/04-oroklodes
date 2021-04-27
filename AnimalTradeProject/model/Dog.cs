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
        /// I1.05 Készítsük el a kutya osztály konstruktorát
        ///       A fordító az Animal osztállyal kapcsolatos hibát jelez 
        public Dog(string name, int age)
            /// I1.06 Ösosztály konstruktorának meghívása
            ///       Tehát mielőtt lefut a kutya konstruktort meg kell hívni az "Animal" osztály = base konstruktorát
            : base(name, age)
        { 
        }
    }
}
