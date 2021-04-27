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

        private string name;
        /// <summary>
        /// Az állat életkora
        /// </summary>
        private int age;

    }
}
