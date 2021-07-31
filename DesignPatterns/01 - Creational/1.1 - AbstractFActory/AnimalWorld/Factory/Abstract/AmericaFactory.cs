using DesignPatterns._01___Creational._1._1___AbstractFActory.World.Product;
using DesignPatterns._01___Creational._1._1___AbstractFActory.World.Product.Abstract;

namespace DesignPatterns._01___Creational._1._1___AbstractFActory.World.Factory.Abstract
{
    public class AmericaFactory : ContinentFactory
    {
        public override Carnivore CreateCarnivore()
        {
            return new Wolf();
        }

        public override Herbivore CreateHerbivore()
        {
            return new Wildebeest();
        }
    }
}
