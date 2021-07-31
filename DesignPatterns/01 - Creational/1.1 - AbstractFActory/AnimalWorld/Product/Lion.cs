using DesignPatterns._01___Creational._1._1___AbstractFActory.World.Product.Abstract;
using System;

namespace DesignPatterns._01___Creational._1._1___AbstractFActory.World.Product
{
    public class Lion : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            Console.WriteLine(this.GetType().Name + " eats " + h.GetType().Name);
        }
    }
}
