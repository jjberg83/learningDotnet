namespace Intermediate.Polymorphism;

public class DbConnectionExercise
{
    public static void Run()
    {
        // Siden DatabaseConnection klassen er abstract kan man ikke lage instans av den
        // var databaseConnection = new DatabaseConnection();

        // Man kan lage instanser av derived klasser av abstract base klasser, men her 
        // feiler det siden man ikke oppfyller kravene til konstruktøren
        // var sqlConnection = new SqlConnection(null);
        // var oracelConnection = new OracleConnection("   ");

        // Men her går det fordi disse kravene blir oppfylt
        var sqlConnection = new SqlConnection("aldkjf askdjføalskjf øla");
        var oracleConnection = new OracleConnection("ØLKJØLKølkjøj0iuoiu343");
        sqlConnection.OpenConnection();
        sqlConnection.CloseConnection();
        oracleConnection.OpenConnection();
        oracleConnection.CloseConnection();
    }
}
