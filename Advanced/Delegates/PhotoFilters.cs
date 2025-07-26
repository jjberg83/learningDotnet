namespace Advanced.Delegates;

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
