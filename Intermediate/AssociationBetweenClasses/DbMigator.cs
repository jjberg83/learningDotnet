namespace Intermediate.AssociationBetweenClasses;

public class DbMigrator
{
    private readonly Logger _logger;

    public DbMigrator(Logger logger)
    {
        _logger = logger;
    }    

    public void Migrate()
    {
        _logger.Log("Vi migrerer bla bla bla");
    }
}
