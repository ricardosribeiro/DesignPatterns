namespace DesignPatterns._01___Creational._1._2___FactoryMethod.PrivateBank
{
    internal class ProdutoInvestimentoVarejoCreator:ProdutoInvestimentoFactory
    {

        public override ProdutoInvestimento Create()
        {
            return new ProdutoInvestimentoVarejo();
        }
    }
}