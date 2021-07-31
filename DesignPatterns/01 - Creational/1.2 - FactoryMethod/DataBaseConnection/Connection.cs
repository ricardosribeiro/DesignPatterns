﻿using System;

namespace DesignPatterns._01___Creational._1._2___FactoryMethod
{
    public class Connection
    {
        public string ConnectionString { get; set; }
        public bool Opened { get; set; }

        public Connection(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public void ExecuteCommand(string command)
        {
            Console.WriteLine("Executando Comando: " + command);
        }

        public void Open()
        {
            Opened = true;
            Console.WriteLine("Conexão aberta");
        }

        public void Close()
        {
            Console.WriteLine("Conexão fechada");
        }
    }
}