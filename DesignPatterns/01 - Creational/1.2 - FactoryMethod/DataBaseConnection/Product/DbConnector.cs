namespace DesignPatterns._01___Creational._1._2___FactoryMethod
{
    public abstract class DbConnector
    {
        //Abstract Product
        public DbConnector(string connectionString)
        {
            ConnectionString = connectionString;
        }

        protected string ConnectionString { get; set; }
        public abstract Connection Connect();
    }
}