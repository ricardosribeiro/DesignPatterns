using System;

namespace DesignPatterns._01___Creational._1._1___AbstractFActory.AutoSocorro
{
    //Produto Concreto
    public class GuinchoPequeno : Guincho
    {
        public GuinchoPequeno(Porte porte) : base(porte)
        {
        }

        public override void Socorrer(Veiculo veiculo)
        {
            Console.WriteLine("Socorrendo veículo de porte pequeno: " + veiculo.Modelo);
        }
    }


}