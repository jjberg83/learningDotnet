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
    public DateTime BirthDate { get; set; }

    // Her skaper vi en ny property, denne gangen med logikk
    // Under panseret blir altså et privat felt opprettet
    // Trenger ingen setter, fordi alderen blir satt i getteren
    // Tøft at den er dynamisk
    public int Age 
    {
        get
        {
            TimeSpan timeSinceBirth = DateTime.Today - BirthDate;
            int years = Convert.ToInt32(timeSinceBirth.Days / 365);
            return years;
        }
    }
}