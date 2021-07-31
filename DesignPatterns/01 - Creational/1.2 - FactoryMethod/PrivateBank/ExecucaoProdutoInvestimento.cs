namespace DesignPatterns._01___Creational._1._2___FactoryMethod.PrivateBank
{
    public class ExecucaoProdutoInvestimento
    {
        public static void Executar()
        {
            var factory = new ProdutoInvestimentoFactory[2];
            factory[0] = ProdutoInvestimentoFactory.ProdutoInvestimento(TipoCliente.Varejo);
            factory[1] = ProdutoInvestimentoFactory.ProdutoInvestimento(TipoCliente.Private);

            factory[0].Create().MontarProdutoInvestimento();
            factory[1].Create().MontarProdutoInvestimento();
        }
    }
}
