using System.Security.Cryptography.X509Certificates;

namespace Advanced.Delegates;

public class PhotoProcessor
{
    // Versjon_1: PhotoFilters er "frameworket". I denne klassen bruker man frameworket, ved å 
    // kalle på de forskjellige metodene i klassen PhotoFilters. Her hardcoder man alle metodene man vil skal
    // kjøre nå vi bruker frameworket. Man kan ikke velge hvilke metoder som kjøres (i Delegates.cs) uten
    // å endre koden inni her, og ønsker man å legge til egen custom metoder som et tillegg
    // til frameworket, går ikke det uten å endre koden inni her.
    // public void Process(string path)
    // {
    //     var photo = Photo.Load(path);

    //     var filters = new PhotoFilters();
    //     filters.ApplyBrightness(photo);
    //     filters.ApplyContrast(photo);
    //     filters.Resize(photo);

    //     photo.Save();
    // }

    // Versjon_2:

    // Her lager vi delegaten, som vet hvilke metoder som skal kalles fra gang til gang.
    // Når vi lager nye custom metoder som et tillegg til frameworket, må disse metodene
    // matche denne signaturen. Denne delegaten er altså en samling referanser til metoder
    // som skal igangsettes (de kan ligge hvor som helst, inni denne klassen, i andre klasser osv).
    // Også viktig å poengtere at denne linjen ikke er et field, men et såkalt "type definition".
    // Den trengs for å lage variabler som "filterHandlerJørund" og "filterHandlerBenjamin" i Delegates.cs.
    // Variablene vi lager der overskriver ikke hverandre, slik de ville gjort hvis linjen under var et field

    // public delegate void PhotoFilterHandler(Photo photo);

    // public void Process(string path, PhotoFilterHandler filterhandler)
    // {
    //     var photo = Photo.Load(path);

    //     filterhandler(photo);

    //     photo.Save();

    // }

    // Versjon_3:

    // Over var delegaten vår en såkalt custom delegate, en vi lagde fra bunnen av.
    // I C# finnes også to default delegate typer som kan lette jobben vår, slik at vi slipper å lage fra bunnen av.
    //  De heter: action og func. action peker til metoder som 
    // ikke returnerer noe, altså void. func peker til metoder som returnerer en eller annen verdi.
    // Action en generisk og en ikke-generiske variant, func har bare generiske variant.

    // Først action variant (se hva som kommer etter punktumet- System.Action er den ikke-generiske, System.Action<> er den generiske)
    // System.Action<>
    // System.Action

    // Andre varianten, func
    // System.Func<>

    // I denne varianten trenger vi ikke å lage en custom delegate, så vi dropper linjen under
    // public delegate void PhotoFilterHandler(Photo photo);

    // Siden vi fortsatt trenger funksjonaliteten fra linjen over, men vi ikke ønsker å lage hjulet på nytt,
    // bruker vi action<>, som er generisk og returnerer void, som den over. Vi endrer andre argument i metoden Process.
    // I stedet for at filterhandler skal være av typen PhotoFilterHander som er delegaten definert ovenfor (og nå kommentert ut),
    // er den av typen action<>

    public void Process(string path, Action<Photo> filterhandler)
    {


        var photo = Photo.Load(path);

        filterhandler(photo);

        photo.Save();

    }
}
