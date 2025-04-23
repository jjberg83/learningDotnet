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

        // Men klarer ikke å nå fieldsene til Logger klassen
        // Det er kun metodene
        // Har prøvd forskjellige måter å omgås det på, men 
        // det virker ikke helt bra. Har jo lært at en klasses
        // fields er dens private anliggende, og det har ikke andre klasser
        // noe med. Det er hva klassen kan gjøre som skal kunne nås av andre
        // klasser. Ikke dens oppbygning. 
        // dbMigrator.CreationTime = new DateTime(1983, 07, 02);

        
    }
}