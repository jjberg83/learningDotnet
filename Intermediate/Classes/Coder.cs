namespace Intermediate.Classes;

public class Coder
{
    // Her definerer vi en default property
    public string Strenghts { get; set; }

    public DateTime CertificationExpiry { get; set; }

    // Og her definerer vi en indekser, som fører til mindre kode når vi skal bruke klassen
    // i andre filer der vi lager instanser av den

    // Vi må lagre indexeren i en Backing field 
    // husk, readonly gjør at man bare kan initialisere denne en gang
    // Er ikke gjort her pga det som skjer i metoden GetAllEntries under
    private Dictionary<string, string> _dictionary = new Dictionary<string, string>();

    public string this[string key] 
    { 
        get
        {
            return _dictionary[key];
        }
        set
        {
            _dictionary[key] = value;
        }  
    }

    public IEnumerable<KeyValuePair<string, string>> GetAllEntries()
    {
        // Setter man readonly foran dette fieldet (_dictionary over), kan man ikke med et uhell slette alt i 
        // _dictionary ved å re-initialisere den som under
        _dictionary = new();
        return _dictionary;
    }

    
}