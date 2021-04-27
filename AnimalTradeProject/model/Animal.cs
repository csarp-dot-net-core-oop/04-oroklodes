using System;
using System.Collections.Generic;
using System.Text;

namespace oop.model
{   
    /// <summary>
    /// Álat osztály
    /// I1.01 Absztrakt osztály
    ///       Az absztrakt osztályokból nem lehetséges a példányosítás (http://aries.ektf.hu/~hz/wiki7/mprog2ea/abstract)
    ///       Mivel olyan a természetbe konkrétan nincs, hogy állat egy példánya, nem is akarunk állatot példányosítani
    /// </summary>
    abstract class Animal
    {
        /// I1.02 Adattagok
        ///       Olyan adatokat adunk meg, amellyel minden állat rendelkezik
        /// <summary>
        /// Az állat neve
        /// </summary>        

        // I1.11 Az adatok csak akkor öröklődnek, ha protected láthatósággal adjuk meg őket
        protected string name;
        /// <summary>
        /// Az állat életkora
        /// </summary>
        protected int age;

        /// I1.03 Az összes állatra vonatkozó metódusok
        /// 
        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="name">Az állat neve</param>
        /// <param name="age">Az állat életkora</param>
        protected Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        /// <summary>
        /// Metódus amellyel köszönti a látogatót
        /// </summary>
        public void Greet()
        {
            Console.WriteLine("Helló, az én nevem " + name + " és " + age + " éves vagyok.");
        }

    }
}
