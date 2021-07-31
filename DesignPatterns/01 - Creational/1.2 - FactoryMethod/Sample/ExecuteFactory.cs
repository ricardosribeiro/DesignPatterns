using System;

namespace DesignPatterns._01___Creational._1._2___FactoryMethod.Sample
{
    public class ExecuteFactory
    {
        public static void Execute()
        {
            Creator[] creators = new Creator[2];

            creators[0] = new ConcreteCreatorA();
            creators[1] = new ConcreteCreatorB();

            foreach (var creator in creators)
            {
                Product product = creator.FactoryMethod();
                Console.WriteLine("Created {0}", product.GetType().Name);
            }
        }
    }
}
