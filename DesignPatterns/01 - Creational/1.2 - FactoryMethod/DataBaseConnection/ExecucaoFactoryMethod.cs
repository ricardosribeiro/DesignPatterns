namespace DesignPatterns._01___Creational._1._2___FactoryMethod
{
    public class ExecucaoFactoryMethod
    {
        public static void Executar()
        {
            var sqlCn = DbFactory.Database(DataBase.SqlServer)
                .CreateConnector("minhaCS ")
                .Connect();

            sqlCn.ExecuteCommand("select * from minhaTabela");
            sqlCn.Close();



            var oracleCn = DbFactory.Database(DataBase.Oracle)
                .CreateConnector("minhaCS")
                .Connect();

            oracleCn.ExecuteCommand("select * from minhaTabela");
            oracleCn.Close();

        }
    }
}
