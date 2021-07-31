using DesignPatterns._01___Creational._1._1___AbstractFActory.World.Factory.Abstract;
using DesignPatterns._01___Creational._1._1___AbstractFActory.World.Product.Abstract;

namespace DesignPatterns._01___Creational._1._1___AbstractFActory.World.Client
{
    public class AnimalWorld
    {
        private readonly Herbivore _herbivore;
        private readonly Carnivore _carnivore;

        public AnimalWorld(ContinentFactory continentFactory)
        {
            _carnivore = continentFactory.CreateCarnivore();
            _herbivore = continentFactory.CreateHerbivore();
        }

        public void RunFoodChain()
        {
            _carnivore.Eat(_herbivore);
        }
    }
}
