namespace DesignPatterns._01___Creational._1._2___FactoryMethod.PrivateBank
{
    internal class ProdutoInvestimentoPrivateCreator : ProdutoInvestimentoFactory
    {
        public ProdutoInvestimentoPrivateCreator()
        {
        }

        public override ProdutoInvestimento Create()
        {
            return new ProdutoInvestimentoPrivate();
        }
    }
}