namespace DesignPatterns._01___Creational._1._2___FactoryMethod.FakeBank
{
    public abstract class Conta
    {
        protected static decimal Saldo;
        public abstract void Saque(decimal valor);
        public abstract void Deposito(decimal valor);
        public abstract void ConsultarSaldo();

    }
}
