namespace Intermediate.AssociationBetweenClasses;
public class Composition
{
    public static void Run()
    {
        DbMigrator dbMigrator = new DbMigrator(new Logger());
        Installer installer = new Installer(new Logger());

        // Poenger er at begge disse klassene bruker Log metoden
        // fra Logger klassen, vha composition.
        // Composition er når noe er felles mellom klasser, og man
        // flytter det som er fells over i en egen klasse (men denne klassen
        // er ikke parent, men det er et has-a forhold)
        dbMigrator.Migrate();
        installer.Install();
    }
}