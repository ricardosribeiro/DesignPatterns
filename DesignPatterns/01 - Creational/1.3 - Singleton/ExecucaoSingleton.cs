using System;

namespace DesignPatterns._01___Creational.Singleton
{
    public class ExecucaoSingleton
    {
        public static void Executar()
        {
            var b1 = LoadBalancer.GetLoadBalancer();
            var b2 = LoadBalancer.GetLoadBalancer();
            var b3 = LoadBalancer.GetLoadBalancer();

            if (b1 == b2 && b2 == b3)
            {
                Console.Write("Mesma Instância \n");
            }
        }
    }
}
