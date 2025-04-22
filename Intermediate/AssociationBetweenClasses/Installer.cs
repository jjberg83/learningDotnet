namespace Intermediate.AssociationBetweenClasses;

public class Installer
{
    private readonly Logger _logger;

    public Installer()
    {
        _logger = new Logger();
    }

    public void Install()
    {
        _logger.Log("Vi installerer ting...");
    }
}
