namespace DesignPatterns._01___Creational._1._2___FactoryMethod
{
    //Concrete Creator
    public class OracleFactory : DbFactory
    {
        //Factory Method
        public override DbConnector CreateConnector(string connectionString)
        {
            return new OracleDbConnector(connectionString);
        }
    }
}
