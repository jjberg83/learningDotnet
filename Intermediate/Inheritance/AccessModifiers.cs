namespace Intermediate.Inheritance;

public class AccessModifiers
{
    public static void Run()
    {
        // Snakker om hvorfor vi bruker encapsulation (lar klassene være som black boxes)
        // Det har ingenting med sikkerhet å gjøre, som jeg trodde var en del av grunnen
        // Grunnen er enkelt og greit at ved å gjøre klasser "vanskelige" å bruke, 
        // reduserer man avhengighetene til de. Hvis det er få avhengigheter, er effektene
        // av å endre en klasse så lav som mulig. Kun det som absolutt må brukes fra utsiden,
        // sendes ut. Se for deg en DVD spiller. Alt vi trykker på er et par knapper. Vi driter
        // i hvordan den ser ut fra innsiden. Vi er kun avhengige av knappene. Filmopplevelsen
        // spoleres ikke av en software oppdatering på dvd spilleren. Fordi vi aldri gjorde oss
        // avhengig av noe inni dvd spilleren. Vi er kun avhengig av knappene.

        // Vi har følgende access modifiers (kan fint bruke det på metoder også):
        // public
        // private
        // protected (samme som private, men derived classes (ikke instanser men child klasser) kan også nå protected field/metode). Unngå om mulig, reduserer encapsulation.
    }
}
