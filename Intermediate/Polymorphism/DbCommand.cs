namespace Intermediate.Polymorphism;
public class DbCommand
{
    public DbConnection DbConnection { get; set; }
    public string Instruction { get; set; }
    public DbCommand(DbConnection dbConnection, string instruction)
    {
        if (dbConnection == null)
            throw new ArgumentNullException(nameof(dbConnection), "Argument i konstruktøren kan ikke være null");
        if (instruction == null)
            throw new ArgumentNullException(nameof(instruction), "Argument i konstruktøren kan ikke være null");
        if (string.IsNullOrWhiteSpace(instruction))
            throw new ArgumentException("Argument i konstruktøren kan ikke bare ha white space");

        DbConnection = dbConnection;
        Instruction = instruction;
    }

    // Metoden under bruker polymorphism. Denne klassen bryr seg ikke om hvilken implementasjon av
    // disse metodene som bilr brukt. Det er ikke denne klassens ansvar. Det håndteres internt 
    // mellom DbConnection (abstract base class), og de to derived klassene SqlConnection og OracleConnection
    // som begge to har overridet OpenConnection og CloseConnection metodene til base class

    // Summary under gjør at man ser det inni summary tagen når man hovrer over metoden i instanser
    // men en snodighet at man må bruke 3 dasher for at det skal virke
    /// <summary>
    /// Opens a connection to a database, sends a database instruction and then closes the connection.
    /// </summary>
    public void Execute()
    {
        DbConnection.OpenConnection();
        Console.WriteLine(Instruction);
        DbConnection.CloseConnection();
    }
}
