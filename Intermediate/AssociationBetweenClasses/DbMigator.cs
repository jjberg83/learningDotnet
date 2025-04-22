namespace Intermediate.AssociationBetweenClasses;

public class DbMigrator
{
    private Logger _logger;

    public DbMigrator()
    {
        _logger = new Logger();
    }    

    public void Migrate()
    {
        _logger.Log("Vi migrerer bla bla bla");
    }
}
