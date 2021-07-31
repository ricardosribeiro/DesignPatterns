namespace DesignPatterns._01___Creational._1._1___AbstractFActory.AutoSocorro
{
    //Abstract Product
    public abstract class Guincho
    {
        public Guincho(Porte porte)
        {
            Porte = porte;
        }

        public abstract void Socorrer(Veiculo veiculo);

        public Porte Porte { get; set; }
    }


}