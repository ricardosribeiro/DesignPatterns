namespace DesignPatterns._01___Creational._1._2___FactoryMethod.Sample
{
    public class ConcreteCreatorB : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProductB();
        }
    }
}
