namespace DesignPatterns._01___Creational._1._2___FactoryMethod.PrivateBank
{
    public abstract class ProdutoInvestimento
    {
        public string Agencia { get; set; }
        public string Conta { get; set; }

        public abstract void MontarProdutoInvestimento();
    }
}
