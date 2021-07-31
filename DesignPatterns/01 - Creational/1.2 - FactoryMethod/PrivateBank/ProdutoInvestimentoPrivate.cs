using System;

namespace DesignPatterns._01___Creational._1._2___FactoryMethod.PrivateBank
{
    public class ProdutoInvestimentoPrivate : ProdutoInvestimento
    {
        public override void MontarProdutoInvestimento()
        {
            Console.WriteLine($"Você está montando um produto do tipo " +
                $"{this.GetType().Name}");
        }
    }
}
