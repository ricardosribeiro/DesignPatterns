namespace DesignPatterns._01___Creational._1._1___AbstractFActory.AutoSocorro
{
    //Abstrct Product
    public abstract class Veiculo
    {
        public Veiculo(string modelo, Porte porte)
        {
            Modelo = modelo;
            Porte = porte;
        }

        public string Modelo { get; }
        public Porte Porte { get; }
    }
}
