using System;
using System.Collections.Generic;

namespace DesignPatterns._01___Creational.Singleton
{
    public sealed class LoadBalancer
    {
        private static readonly LoadBalancer Instance = new();

        private readonly List<Server> _servers;
        private readonly Random _random;

        private LoadBalancer()
        {
            _servers = new List<Server>
            {
                new Server{Id = Guid.NewGuid(), Name = "Server I", Ip = "192.168.1.2"},
                new Server{Id = Guid.NewGuid(), Name = "Server II", Ip = "192.168.1.3"},
                new Server{Id = Guid.NewGuid(), Name = "Server III", Ip = "192.168.1.4"},
                new Server{Id = Guid.NewGuid(), Name = "Server IV", Ip = "192.168.1.5"},
                new Server{Id = Guid.NewGuid(), Name = "Server V", Ip = "192.168.1.6"}
            };
        }

        public static LoadBalancer GetLoadBalancer()
        {
            return Instance;
        }

        public Server NextServer
        {
            get
            {
                var r = _random.Next(_servers.Count);
                return _servers[r];
            }
        }
    }
}
