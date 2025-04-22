namespace Intermediate.AssociationBetweenClasses;
public class Composition
{
    public static void Run()
    {
        DbMigrator dbMigrator = new DbMigrator();
        Installer installer = new Installer();

        // Poenger er at begge disse klassene bruker Log metoden
        // fra Logger klassen, vha composition.
        // Composition er når noe er felles mellom klasser, og man
        // flytter det som er fells over i en egen klasse (men denne klassen
        // er ikke parent, men det er et has-a forhold)
        dbMigrator.Migrate();
        installer.Install();

        // La meg prøve å nå ikke bare metodene til Logger klassen, 
        // men også fieldsene
        dbMigrator.CreationTime = new DateTime(1983, 07, 02);

        
    }
}