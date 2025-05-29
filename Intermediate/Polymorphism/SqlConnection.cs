namespace Intermediate.Polymorphism;

public class SqlConnection : DbConnection
{
    public SqlConnection(string connectionString) : base(connectionString)
    {

    }

    public override void OpenConnection()
    {
        Console.WriteLine("Connection to Sql database is opened");
    }

    public override void CloseConnection()
    {
        Console.WriteLine("Connection to Sql database is closed");
    }
}
