namespace Intermediate.Classes;

public class PersonPrivat
{
    // private DateTime _birthdate;

    // Masse boilerplate kode her (erstattes med Property, som er reduserer koden men oppnår det samme)
    // public void SetBirthdate(DateTime birthdate)
    // {
    //     _birthdate = birthdate;
    // }
    // public DateTime GetBirthdate()
    // {
    //     return _birthdate;
    // }

    // Samme som over kan skrives med en property slik
    // public DateTime BirthDate
    // {
    //     get { return _birthdate; }
    //     set { _birthdate = value; }
    // }

    // Det har ingen logikk, kan derfor forkortes enda mer til...
    // Og da trenger man ikke en gang å definere den private helt øverst!
    // Den skapes automatisk.
    // Ved å sette private foran set, sier man at Birtday kun kan defineres i 
    // konstruktøren, og aldri endres deretter. Før dette trengte man ikke å 
    // skrive konstruktøren eskplisitt, siden en blank konstruktør ble skapt
    // automatisk på baksiden. Nå må vi, fordi vi har et argument.
    public DateTime BirthDate { get; private set; }

    // Her skaper vi en ny property, denne gangen med logikk
    // Under panseret blir altså et privat felt opprettet
    // Trenger ingen setter, fordi alderen blir satt i getteren
    // Tøft at den er dynamisk
    public int Age 
    {
        get
        {
            if (BirthDate.Year == 0001)
                return 0; // Ellers ender folk opp med å være over 2000 år hvis alderen ikke er satt
            TimeSpan timeSinceBirth = DateTime.Today - BirthDate;
            int years = Convert.ToInt32(timeSinceBirth.Days / 365);// 
            int yearsWithLeap = Convert.ToInt32(timeSinceBirth.Days / 365.25);// .25 er for å ta høyde for skuddår, men får også bursdagen før jeg skal...
            return years;
        }
    }

    // Jeg har allerede en nyttig code snippet innebygget:
    // ved å skrive "prop" og så tab, lager vi først navn på hva som returneres, her "string"
    // så trykker man tab igjen og skriver navnet på propertien, her "Name"
    // Så tab og enter
    public string Name { get; set; }
    public string UserName { get; set; }

    public PersonPrivat(DateTime birthdate)
    {
        BirthDate = birthdate;
    }

    // Konvensjon for hvor ting skal plasseseres i klassen er:
    // 1 - auto implmented properties (de med bare get; set;)
    // 2 - konstruktør
    // 3 - properties med logikk
    // (4) - han sier det ikke, men her må jo metodene komme
}