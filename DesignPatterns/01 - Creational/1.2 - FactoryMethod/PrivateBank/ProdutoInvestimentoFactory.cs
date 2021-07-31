using System;

namespace DesignPatterns._01___Creational._1._2___FactoryMethod.PrivateBank
{
    public abstract class ProdutoInvestimentoFactory
    {
        public abstract ProdutoInvestimento Create();
        public static ProdutoInvestimentoFactory ProdutoInvestimento(TipoCliente tipoCliente) =>
         tipoCliente switch
         {
             TipoCliente.Private => new ProdutoInvestimentoPrivateCreator(),
             TipoCliente.Varejo => new ProdutoInvestimentoVarejoCreator(),
             _ => throw new ApplicationException("Tipo Investimento não identificado.")
         };
    }
}

public enum TipoCliente
{
    Varejo,
    Private
}
