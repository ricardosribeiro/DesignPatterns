using System;

namespace DesignPatterns._01___Creational._1._2___FactoryMethod
{
    //Abstract Creator
    public abstract class DbFactory
    {
        //Factory Method
        public abstract DbConnector CreateConnector(string connectionString);

        public static DbFactory Database(DataBase database)
        {
            //Returns Concrete Creators
            if (database == DataBase.SqlServer)
                return new SqlFactory();
            if (database == DataBase.Oracle)
                return new OracleFactory();

            throw new ApplicationException("Banco de dados não reconhecido.");
        }
    }

    public enum DataBase
    {
        SqlServer,
        Oracle
    }
}
