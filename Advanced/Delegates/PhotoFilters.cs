namespace Advanced.Delegates;

// Denne klassen representerer et "framework", med mange nyttige metoder inni seg.
// I dette eksempelet ser man for seg at disse er de som følger med i "pakken".
// Trenger man andre metoder i tillegg, må man lage disse. Enten her inne i denne 
// klassen (hvis frameworket hadde tillatt det), eller i egenlagde klasser.
public class PhotoFilters
{
    public void ApplyBrightness(Photo photo)
    {
        Console.WriteLine("Applying brightness to photo");
    }
    public void ApplyContrast(Photo photo)
    {
        Console.WriteLine("Applying contrast to photo");
    }

    public void Resize(Photo photo)
    {
        Console.WriteLine("Resizing photo");
    }
}
