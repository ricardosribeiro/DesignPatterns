using DesignPatterns._01___Creational._1._1___AbstractFActory.World.Product.Abstract;

namespace DesignPatterns._01___Creational._1._1___AbstractFActory.World.Factory.Abstract
{
    public abstract class ContinentFactory
    {
        public abstract Herbivore CreateHerbivore();
        public abstract Carnivore CreateCarnivore();
    }
}
