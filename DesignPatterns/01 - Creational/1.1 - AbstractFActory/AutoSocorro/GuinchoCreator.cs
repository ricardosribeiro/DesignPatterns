using System;

namespace DesignPatterns._01___Creational._1._1___AbstractFActory.AutoSocorro
{
    public class GuinchoCreator
    {
        public static Guincho Criar(Porte porte)
        {
            switch (porte)
            {
                case Porte.Pequeno:
                    return new GuinchoPequeno(porte);
                case Porte.Medio:
                    return new GuinchoMedio(porte);
                case Porte.Grande:
                    return new GuinchoGrande(porte);
                default: throw new ApplicationException("Porte de Guincho desconhecido.");
            }
        }
    }


}