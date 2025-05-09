using System.Collections;

namespace Intermediate.Inheritance;
internal class UpcastingAndDowncasting
{
    private static void IkkeDowncasting(Shape shape)
    {
        // shape.Draw();
        Console.WriteLine("Når ikke Draw metoden til Text herfra.");
    }
    private static void Downcasting(Shape shape)
    {
        Text text = shape as Text;// Går ikke dette blir output null, så det krasjer aldri
        if (text != null)
        {
            text.Draw();
            Console.WriteLine("Man når Draw metoden til Text klassen");
        }
        else
        {
            Console.WriteLine("Shape kan ikke downcastes til type Text, mao er ikke Text derived klasse av Shape");
        }
        
    }
    public static void Run()
    {
        Text text = new Text();
        // Her upcaster vi, det skjer implisitt. Begge disse to peker til samme plass i minne.
        // Men når man bruker base class får man ikke tak i derived class
        // sine fields og metoder.Man sier at de peker til samme plass i minnet, de har samme
        // referanse, men de har forskjellige views (altså at man ikke får tak i derived
        // klassens fields og metoder når man har en base class)
        Shape shape = text;

        text.Width = 100;
        shape.Width = 200;
        Console.WriteLine(text.Width); // Vil vise 200 siden de begge endrer samme referanse

        // StreamReader brukes for å lese data fra enhver kilde i C#
        // Stream er base class
        // Derived klasser er for eksempel FileStream, MemoryStream
        // https://learn.microsoft.com/en-us/dotnet/api/system.io.stream?view=net-9.0

        // Legg merke til at de fleste overloads til StreamReader tar inn en Stream som
        // parameter. Men siden for eksempel FileStream og MemoryStream er derived fra
        // stream, får man implisitt en upcasting når man legger inn disse (altså blir
        // de upcastet til type Stream).
        StreamReader memoryReader = new StreamReader(new MemoryStream());

        // På samme måte tar Add metoden til klassen ArrayList inn obj som parameter
        // Alt i C# er objekter. Dermed kan man legge hva man vil inn som argument til Add
        // metoden, og det blir upcastet til object.

        // Mosh adavarer mot å bruke ArrayLists fordi man kan legge inn alle datatyper her
        // Han mener det er bedre å ha lister som bare kan ta inn en datatype
        ArrayList arrayList = new ArrayList();
        arrayList.Add(42);
        arrayList.Add("Jørund");

        foreach(var element in arrayList)
        {
            // Men ser de beholder typen når jeg skriver dem ut her.
            Console.WriteLine(element.GetType());
        }

        // Lister kan inneholde en datatype (og alle dens derivete klasser)
        var shapeList = new List<Shape>();
        // Under ser man at man har lov til begge to
        shapeList.Add(new Text());
        shapeList.Add(new Shape());
    
        // Men andre klasser som ikke er derived har ikke lov
        // shapeList.Add(new Car("rfaløsdkjf"));

        // La oss nå se på downcasting
        // Ved compile time har denne variabelen typen Shape
        // og ved run time har den typen Text
        Shape shape2 = new Text();
        // Siden shape2 ved compile time er Shape, har den ikke adgang til 
        // fields og metoder i derived klassen Text (under ser vi ikke Draw, FontSize og FontName)
        // Med andre ord har vi ikke downcastet fullstendig, vi må gjøre det eksplisitt
        // shape2.
        // Downcaster vi (eksplisitt), går det
        Text downcastedShape2 = (Text)shape2;
        // Nå går det!
        downcastedShape2.Draw();

        // La meg gjøre det på nytt, men der jeg bare downcaster en gang
        Shape shape3 = new Shape();
        // shape3.Draw() // Jeg har ikke adgang, bra.
        Text shape3Downcastet = (Text)shape3;
        shape3Downcastet.Draw(); // Jeg har adgang!

        // Nå skal han vise et real world example hvor downcasting er en greie
        // Han lager et nytt prosjekt, men ikke Console Application
        // Han skal lage desktop application for windows, og sier man kan bruke
        // enten "Windows Form Application" eller "WPF Application" (den han brukte)
        // Med dette kunne han lage et form man kunne fylle ut på en Windows maskin
        // (finner det ikke igjen hos meg)

        // Hovedpoenget med leksjonen

        // Metoder som krever for eksempel object som parameter, bruker implisitt
        // upcasting når man legger inn en type, som vil være derived av object
        // siden alt i C# er objekter

        // Eksempel: 
        // metoden(object element)
        // kan brukes slik:
        // metoden(string "hei") stringen upcastes da til object

        // Motsatt vil man inni metoder som har slike "høye" parametere som object
        // eller andre base classes (som også har derived classes), trenge metoder
        // og fields fra en av derived klassene. Inni metoden under trenger man
        // Draw metoden til Text klassen, som er derived fra Shape klassen.
        // Men det er ikke før man downcaster eksplisitt at man får tak i den.
        // Mønsteret med <parameter as derivedKlasse> gir null hvis downcastingen ikke går
        
        Shape shape4 = new Shape();
        IkkeDowncasting(shape4);
        Console.WriteLine("-----------------");
        Downcasting(shape4);

    }
    
}
