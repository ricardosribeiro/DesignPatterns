namespace DesignPatterns._01___Creational._1._1___AbstractFActory.AutoSocorro
{
    public abstract class AutoSocorroFactory
    {
        public abstract Guincho CriarGuincho();
        public abstract Veiculo CriarVeiculo(string modelo, Porte porte);
    }

    public enum Porte
    {
        Pequeno, 
        Medio,
        Grande
    }
}
