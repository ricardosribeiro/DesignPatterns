namespace DesignPatterns._01___Creational._1._2___FactoryMethod
{
    //Concrete Creator
    class SqlFactory : DbFactory
    {
        //Factoy Method
        public override DbConnector CreateConnector(string connectionString)
        {
            return new SqlServerConnector(connectionString);
        }
    }
}
