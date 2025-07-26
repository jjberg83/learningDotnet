namespace Advanced.Delegates;

public class Delegates
{
    public static void Run()
    {
        /*
        Delegates er et objekt som vet hvordan det skal kalle på en metode(eller flere) for oss. 
        En referanse til en funksjon. Vi trenger det for å skrive fleksible og utvidbare applikasjoner.
        Typisk frameworks. Her ser vi for oss at PhotoProcessor klassen er et slikt framework, med en
        samling nyttige metoder. Akkurat det vi løser her, kan vi også løse med interfaces og polymorphism.
        */

        /* Versjon_1 : I gammel versjon, kunne jeg bare kalle på metodene som lå i "frameworket" vi lagde i PhotoProcessor.
        Kjører jeg "dotnet run" her, kalles alle metodene i frameworket. Verken mer eller mindre, og alle kjøres. Man kan ikke
        legge til egne custom metoder som et tillegg til frameworket.
        */
        // var processor = new PhotoProcessor();
        // processor.Process("photo.jpg");

        /* Versjon_2: 
        */
        var processor = new PhotoProcessor();

        // Her er metodene jeg ønsker å bruke fra rammeverket
        // Først får jeg tilgang til alle default metodene
        var filtersJørund = new PhotoFilters();

        PhotoProcessor.PhotoFilterHandler filterHandlerJørund = filtersJørund.ApplyBrightness;
        filterHandlerJørund += filtersJørund.Resize;

        // Og her er de Benjamin ønsker å bruke
        var filtersBenjamin = new PhotoFilters();

        PhotoProcessor.PhotoFilterHandler filterHandlerBenjamin = filtersBenjamin.ApplyContrast;

        // Benjamin har også laget sin egen custom metode han vil bruke sammen med rammeverket.
        // Denne har han definert selv. Det viktigste er at den må følge samme signatur som delegaten
        // slik den er definert inni PhotoProcessor. Altså void Metodenavn(Photo photo)
        filterHandlerBenjamin += RemoveRedEye;

        processor.Process("photo.jpg", filterHandlerJørund); // Delegaten vet hvilke metoder som skal kalles her
        Console.WriteLine("---------------------");
        processor.Process("photo.jpg", filterHandlerBenjamin); // Delegaten vet hvilke metoder som skal kalles her
    }

    public static void RemoveRedEye(Photo photo)
    {
        Console.WriteLine("Removing red eyes");
    }
}