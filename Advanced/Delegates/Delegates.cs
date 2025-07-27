namespace Advanced.Delegates;
public class Delegates
{
    public static void Run()
    {
        /*
        Delegates er et objekt som vet hvordan det skal kalle på en metode(eller flere) for oss. 
        En referanse til en funksjon. Vi trenger det for å skrive fleksible og utvidbare applikasjoner.
        Typisk frameworks. Her ser vi for oss at PhotoFilters klassen er et slikt framework, med en
        samling nyttige metoder. Akkurat det vi løser her, kan vi også løse med interfaces og polymorphism.
        */

        /* Versjon_1 : I gammel versjon, kunne jeg bare kalle på metodene som lå i "frameworket" vi lagde i PhotoFilters
        (siden disse blir kalt på i Process metoden i PhotoProcessor).
        Kjører jeg "dotnet run" her, kalles alle metodene i frameworket. Verken mer eller mindre, og alle kjøres. Man kan ikke
        legge til egne custom metoder som et tillegg til frameworket (uten å endre koden i Process metoden).
        */
        // var processor = new PhotoProcessor();
        // processor.Process("photo.jpg");

        /* Versjon_2: 
        */
        var processor = new PhotoProcessor();

        // Her er metodene jeg ønsker å bruke fra rammeverket
        // Først får jeg tilgang til alle default metodene
        var filtersJørund = new PhotoFilters();

        // Her legger jeg til metoden ApplyBrightness fra klassen PhotoFilters til delegaten.
        // Legg merke til at vi inkluderer metoden som om den skulle vært et objekt. 
        PhotoProcessor.PhotoFilterHandler filterHandlerJørund = filtersJørund.ApplyBrightness;
        filterHandlerJørund += filtersJørund.Resize;

        // Og her er de Benjamin ønsker å bruke
        var filtersBenjamin = new PhotoFilters();

        PhotoProcessor.PhotoFilterHandler filterHandlerBenjamin = filtersBenjamin.ApplyContrast;

        // Benjamin har også laget sin egen custom metode han vil bruke sammen med rammeverket.
        // Denne har han definert selv. Det viktigste er at den må følge samme signatur som delegaten
        // slik den er definert inni PhotoProcessor. Altså void Metodenavn(Photo photo).
        // Å lage metoder inni Main klassen (her simulert med Delegates.Run()) er ingen god praksis.
        // Jeg gjør det bare for å vise at delegaten kan inneholde metoder fra mange plasser.
        filterHandlerBenjamin += RemoveRedEye;

        // Og her legger jeg til en av metodene fra en annen klasse, akkurat likt som jeg gjorde lenger oppe
        // bare her gjør vi det fra en annen klasse (og her har jeg gjort en av metodene statiske).
        // Først den statiske.
        filterHandlerBenjamin += ExtendedFrameWorkBenjamin.ChangeHue;
        // Og så over til den som ikke er statisk. Vi må altså intansiere først (lage et objekt av klassen).
        var filtersBenjaminExtended = new ExtendedFrameWorkBenjamin();
        filterHandlerBenjamin += filtersBenjaminExtended.Crop;

        // Over har jeg vist at hver delegate kan kalle på metoder som ligger vidt forskjellige plasser, noen
        // statiske og andre ikke. 

        processor.Process("photo.jpg", filterHandlerJørund); // Delegaten vet hvilke metoder som skal kalles her
        Console.WriteLine("---------------------");
        processor.Process("photo.jpg", filterHandlerBenjamin); // Delegaten vet hvilke metoder som skal kalles her
    }

    public static void RemoveRedEye(Photo photo)
    {
        Console.WriteLine("Removing red eyes");
    }
}