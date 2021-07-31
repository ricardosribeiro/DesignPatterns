using System;

namespace DesignPatterns._01___Creational._1._2___FactoryMethod.FakeBank
{
    public class ContaPoupancaCreator : ContaFactory
    {
        public override Conta CreateConta()
        {
            return new ContaPoupanca();
        }
    }
}
