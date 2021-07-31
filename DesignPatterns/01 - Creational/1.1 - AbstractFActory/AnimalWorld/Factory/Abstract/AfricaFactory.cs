using DesignPatterns._01___Creational._1._1___AbstractFActory.World.Product;
using DesignPatterns._01___Creational._1._1___AbstractFActory.World.Product.Abstract;
using System;

namespace DesignPatterns._01___Creational._1._1___AbstractFActory.World.Factory.Abstract
{
    public class AfricaFactory : ContinentFactory
    {
        public override Carnivore CreateCarnivore()
        {
            return new Lion();
        }

        public override Herbivore CreateHerbivore()
        {
            return new Wildebeest();
        }
    }
}
