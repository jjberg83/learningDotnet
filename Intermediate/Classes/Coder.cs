namespace Intermediate.Classes;

public class Coder
{
    // Her definerer vi en default property
    public string Strenghts { get; set; }

    // Og her definerer vi en indekser, som fører til mindre kode når vi skal bruke klassen
    // i andre filer der vi lager instanser av den

    // Vi må lagre indexeren i en Backing field 

    public string this[string key] 
    { 
        get{}
        set{}  
    }
}