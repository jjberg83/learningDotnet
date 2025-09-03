namespace Advanced.ExceptionHandling;

public class ExceptionHandling
{
    public static void Run()
    {
        try
        {
            var calculator = new Calculator();
            calculator.Divide(3, 0);
        }
        catch (Exception e)
        {
            Console.WriteLine("En uventet feil skjedde");
        }
    }
}