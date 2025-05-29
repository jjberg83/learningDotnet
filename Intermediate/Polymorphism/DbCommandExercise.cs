namespace Intermediate.Polymorphism;

public class DbCommandExercise
{
    public static void Run()
    {
        var sqlCommand = new DbCommand(new SqlConnection("alkdjfadfo3984938@.&/&"), "SELECT * FROM db.FacSales");
        sqlCommand.Execute();

        Console.WriteLine();

        var oracleConnection = new OracleConnection("asdøalksdjføawerow38409q80)(=)(#_)");
        var oracleCommand = new DbCommand(oracleConnection, "SELECT _$_ FROM db.FacSales ____oracle.inc_____");
        oracleCommand.Execute();
    }
}
