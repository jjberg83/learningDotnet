namespace Intermediate.Polymorphism;

public abstract class DbConnection
{
    public string ConnectionString { get; set; }
    public TimeSpan Timeout { get; set; }

    public DbConnection(string connectionString)
    {
        if (connectionString == null)
            throw new ArgumentNullException(nameof(connectionString), "Connection string kan ikke være null");
        if (string.IsNullOrWhiteSpace(connectionString))
            throw new ArgumentException("Connection string kan ikke være bare white space");
        ConnectionString = connectionString;
    }

    public abstract void OpenConnection();
    public abstract void CloseConnection();
}
