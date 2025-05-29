namespace Intermediate.Polymorphism;

public class OracleConnection : DbConnection
{
    public OracleConnection(string connectionString) : base(connectionString)
    {
        
    }
    public override void OpenConnection()
    {
        Console.WriteLine("Connection to Oracle database is opened");
    }

    public override void CloseConnection()
    {
        Console.WriteLine("Connection to Oracle database is closed");
    }
}
