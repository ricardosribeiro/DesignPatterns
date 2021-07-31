using System;

namespace DesignPatterns._01___Creational._1._2___FactoryMethod.FakeBank
{
    public class ContaPoupanca : Conta
    {
        public static int ContadorConsultas;
        public override void ConsultarSaldo()
        {
            if (ContadorConsultas >= 3)
                Console.WriteLine("Limite de consultas atingido.");

            ContadorConsultas++;
            Console.WriteLine("Seu saldo em " + this.GetType().Name + " é de " + Saldo);
        }

        public override void Deposito(decimal valor)
        {
            Saldo = valor;
            Console.WriteLine("Deposito em " + this.GetType().Name + " no valor de " + valor);
        }

        public override void Saque(decimal valor)
        {
            Saldo = Saldo - valor;
            Console.WriteLine("Saque em " + this.GetType().Name + " no valor de " + valor);
        }
    }
}
