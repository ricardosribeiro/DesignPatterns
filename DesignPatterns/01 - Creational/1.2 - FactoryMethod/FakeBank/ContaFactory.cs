using System;

namespace DesignPatterns._01___Creational._1._2___FactoryMethod.FakeBank
{
    public abstract class ContaFactory
    {
        public abstract Conta CreateConta();

        public static ContaFactory Conta(TipoConta tipoConta)
        {
            if (tipoConta == TipoConta.ContaCorrente)
                return new ContaCorrenteCreator();
            if (tipoConta == TipoConta.ContaPoupanca)
                return new ContaPoupancaCreator();

            throw new ApplicationException("Tipo de conta desconhecido.");
        }
    }

    public enum TipoConta
    {
        ContaCorrente, 
        ContaPoupanca
    }
}
