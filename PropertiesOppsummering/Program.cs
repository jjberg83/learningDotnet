/*
############################################
HVORFOR MAN ALDRI BØR BRUKE PUBLIC Fields
############################################

Her bruker vi to nesten identiske klasser. Den ene klassen bruker public foran et viktig field,
den andre private. Konsekvensen blir ganske stor, selv om klassene ellers er helt like. Man får
problemer som kan være vanskelige å oppdage ved å bruke public fields.
*/

var stopwatch_PublicField = new Stopwatch_PublicField();


stopwatch_PublicField.Start();
Thread.Sleep(2000);
stopwatch_PublicField.Stop();
// Her kommer problemet med å bruke public fields. Man finner ingen feil i selve klassen,
// problemet er at man her tukler med fieldet fra en annen klasse. Her stiller man 
// StartTime utenfra, og dermed passerer ikke valideringen internt i klassen.
// Man klarer ikke starte stoppeklokken igjen når StartTime != DateTime.MinValue...
// Men vanskelig å oppdage bugen, fordi feilen ligger skjer utenfor klassen. 
stopwatch_PublicField.StartTime = DateTime.MaxValue;
stopwatch_PublicField.Start();

// Så kjører vi akkurat samme kode bare fra en helt identisk klasse, med unntak av en ting.
// Fieldet StartTime er privat, og kan ikke nås fra utsiden. Mye bedre. Moral, ikke bruke
// public fields.
var stopwatch_PrivateField = new Stopwatch_PrivateField();
stopwatch_PrivateField.Start();
Thread.Sleep(3000);
stopwatch_PrivateField.Stop();

// Dette er rett og slett ikke lov utenfor klassen. Eneste forskjellen mellom de to stoppeklokke klassene.
// stopwatch_PrivateField._startTime = DateTime.MaxValue;
// stopwatch_PublicField.Start();

/*
############################################
SYNTAKS PROPERTIES
############################################

Properties uten logikk i getter og setter er i praksis det samme som et public field. Poenget er at man
KAN sette logikk og begrensninger, og man kan finstille logikk og begrensninger individuelt for getter og setter.

Her viser jeg først syntaksen for en tenkt privat field kalt _birthdate.


private DateTime _birthdate;

For at man fra utsiden skal kunne nå eller gjøre noe med dette private fieldet, må man ha egne metoder for det 
inni klassen.

public void GetBirthdate()
{
    return _birthdate;
}

public void SetBirthdate(Datetime birthdate)
{
    _birthdate = birthdate;
}

I stedet for å skrive så mye kode kan man oppnå akkurat det samme med properties. Det oppnår akkurat det
samme som koden over, men kan skrives slik:

public DateTime BirthDate
{
    get { return _birthdate; }
    set { _birthdate = value; }
}

Propertien over har ingen logikk, og kan derfor forkortes enda mer til...

public DateTime BirthDate { get; set; }

Og da trenger man ikke en gang å definere den private helt øverst!
Den skapes automatisk. Dette kalles auto-implemented property (uten eskplisitt backing field).
Man har da ikke mulighet for logikk og validering i getter og setter. 


############################################
HVORFOR VI BRUKER PROPERTIES
############################################

Properties brukes for å styre validering, logikk og finstyre hva man har tilgang
på når man bruker instanser av klassen i andre klasser. Man har 3 "våpen":

1 - Privat keywordet gjør at man kun kan gjøre noe med elementet inni selve klassen
2 - For å skape immutability, bruk readonly keywordet på et privat backing field, eller GETTER trikset under
3 - For å validere, bruk en av VALIDERINGSTEKNIKKENE under.

(2) - GETTER TRIKS:

Disse to er det samme i praksis.

public class Person
{
    public string Name { get; } // Read-only property, man kan ikke endre på denne etter at man har stilt den inn i enten constructor eller i fieldet selv.

    public Person(string name)
    {
        Name = name;
    }
}

Her ser vi klassen definert på annen måte, men funksjonaliteten er akkurat som over.

public class Person
{
    private readonly string _name; // eksplisitt backing field
    
    public string Name { get { return _name;}  } // Read-only property
    // Kan også skrives slik:
    public string Name => _name;

    public Person(string name)
    {
        _name = name;
    }
}

De gjør akkurat det samme, men den over bruker jo mindre kode, og er derfor bedre.

(3) - VALIDERINGSTEKNIKKER:
*/

// Jeg vil demonstrerer 3 måter å bruke validation logic for fields
// Først ut er auto-implemented property der valideringen gjøres
// i en annen metode, slik at man kan stille høyden mange ganger.
public class TreeOne
{
    public int Height { get; private set; }

    public void SetHeight(int height)
    {
        if(height > 0)
        {
            Height = height;
        }
        else
        {
            throw new ArgumentException("Høyde må være større enn 0");
        }
    }
}

// Her gjøres valideringen i constructoren i stedet, men da kan objektet (instansen av klassen)
// kun stille høyden EN gang, i det den skapes.
public class TreeTwo
{
    public int Height { get; private set; }

    public TreeTwo(int height)
    {
        if (height > 0)
        {
            Height = height;
        }
        else
        {
            throw new ArgumentException("Høyde må være større enn 0");
        }
    }
}

// Og her gjøres valideringen i setteren i stedet
// Men det krever en private backing field (og man kan bruke denne i getteren pluss value keywordet i setteren)
// Og siden man gjør shit i setteren, kan man ikke bare skrive
// get; den må skrives som nedenfor, selv om den gjør akkurat
// det samme som get; i auto-implemented properties.
public class TreeThree
{
    private int _height;
    public int Height { 
        get
        {
            return _height;
        }
        set // kan ikke bruke private her, uten å måtte lage enda en ny metode for validering, så de to øverste er bedre hvis man ønsker encapsulation og validering av input samtidig
        {
            if (value > 0)
            {
                _height = value;
            }
            else 
            {
                throw new ArgumentException("Høyde må være større enn 0");
            }
        } 
    }
}




