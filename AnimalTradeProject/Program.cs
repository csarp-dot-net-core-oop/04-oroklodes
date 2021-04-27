using System;

using oop.model;

namespace AnimalTradeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // I1.13 Tesztkód

            // Animal a = new Animal();
            Dog f = new Dog("Frakk", 3, "németjuhász");
            f.Greet();
            f.MyDatas();

            // I1.14 Nézzük meg az osztályok UML diagramját
        }
    }
}
