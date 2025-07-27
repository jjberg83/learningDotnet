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
    public delegate void PhotoFilterHandler(Photo photo);

    public void Process(string path, PhotoFilterHandler filterhandler)
    {
        var photo = Photo.Load(path);

        filterhandler(photo);
        
        photo.Save();

    }
}
