namespace Advanced.Delegates;

// Her samler jeg noen metoder bare for å vise at man kan inkludere
// metodene fra denne klassen også i delegaten. Alle metodene som skal
// inkluderes i den må følge delegatens signatur:
// public delegate void PhotoFilterHandler(Photo photo);
public class ExtendedFrameWorkBenjamin
{
    public static void ChangeHue(Photo photo)
    {
        Console.WriteLine("Changing hue in photo");
    }
    public void Crop(Photo photo)
    {
        Console.WriteLine("Cropping photo");
    }
}
