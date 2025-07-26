using System.Security.Cryptography.X509Certificates;

namespace Advanced.Delegates;

// Denne klassen representerer et "framework", med mange nyttige metoder inni seg.
public class PhotoProcessor
{
    // Versjon_1: Slik så vårt framework ut først. Her hardcoder man alle metodene man vil skal
    // kjøre nå vi bruker frameworket. Man kan ikke velge hvilke metoder som kjøres uten
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
    // matche denne signaturen.
    public delegate void PhotoFilterHandler(Photo photo);

    public void Process(string path, PhotoFilterHandler filterhandler)
    {
        var photo = Photo.Load(path);

        filterhandler(photo);
        
        photo.Save();

    }
}
