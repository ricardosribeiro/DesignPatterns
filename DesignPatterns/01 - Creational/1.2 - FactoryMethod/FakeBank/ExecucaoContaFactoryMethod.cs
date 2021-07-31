using System;

namespace DesignPatterns._01___Creational._1._2___FactoryMethod.FakeBank
{
    public static class ExecucaoContaFactoryMethod
    {
        public static void Executar()
        {
            //var contasFactory = new ContaFactory[2];
            //contasFactory[0] = new ContaCorrenteCreator();
            //contasFactory[1] = new ContaPoupancaCreator();

            //foreach (var contaFactory in contasFactory)
            //{
            //    contaFactory.CreateConta()
            //        .Deposito(100);
            //}

            var contaPoupanca = ContaFactory.Conta(TipoConta.ContaPoupanca)
                .CreateConta();

            contaPoupanca.Deposito(100);
            contaPoupanca.Saque(50);
            contaPoupanca.ConsultarSaldo();

            contaPoupanca.Deposito(20);
            contaPoupanca.ConsultarSaldo();

            contaPoupanca.Saque(30);
            contaPoupanca.ConsultarSaldo();

            contaPoupanca.Deposito(150);
            contaPoupanca.ConsultarSaldo();
            

            Console.WriteLine();

            var contaCorrente = ContaFactory.Conta(TipoConta.ContaCorrente)
                .CreateConta();

            contaCorrente.Deposito(1200);
            contaCorrente.Saque(800);
            contaCorrente.ConsultarSaldo();
                


        }
    }
}
